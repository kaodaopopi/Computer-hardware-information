using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
namespace Computer_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ST_Timer();
            WF_Timer();
        }
             
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void CPU_T_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        //設置初始值
        public float cpu_TP = 0;
        public float cpu_UR = 0;
        public float cpu_GHz = 0;
        public int gpu_TP = 0;
        public int gpu_UR = 0;
        public float gpu_GHz = 0;
        public float ram_UR = 0;
        public int coreCount = 0;
        //System.Windows.Forms.Timer
        public void WF_Timer()
        {
            //UI元件刷新
            System.Windows.Forms.Timer wf_timer = new System.Windows.Forms.Timer();
            wf_timer.Interval = 1000;
            wf_timer.Tick += new System.EventHandler(UI_Refresh);
            wf_timer.Start();
        }
        //System.Timers
        public void ST_Timer()
        {
            //function刷新
            System.Timers.Timer st_timer = new System.Timers.Timer();
            st_timer.Interval = 1000;
            st_timer.Elapsed += ComputerData_Refresh;
            st_timer.AutoReset = true;
            st_timer.Enabled = true;
            st_timer.Start();
        }
        //UI界面更新
        public void UI_Refresh(object sender, EventArgs e)
        {
            CPU_T.Text = cpu_TP.ToString();
            CPU_UR.Text = (Math.Round(cpu_UR, 2, MidpointRounding.AwayFromZero)).ToString();
            CPU_GHz.Text = (Math.Round(cpu_GHz / ((coreCount) * 1000), 2, MidpointRounding.AwayFromZero)).ToString();
            
            GPU_T.Text = gpu_TP.ToString();
            GPU_UR.Text = gpu_UR.ToString();
            GPU_GHz.Text = gpu_GHz.ToString();

            RAM_UR.Text = ram_UR.ToString();

        }
        //背景資料更新
        public void ComputerData_Refresh(object sender, EventArgs e)
        {
            Computer_Status();         
        }
        //取得硬體資訊
        public void Computer_Status()
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.GPUEnabled = true;
            computer.RAMEnabled = true;
            computer.Accept(updateVisitor);

            //取得核心數          
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            
             for (int i = 0; i < computer.Hardware.Length; i++)
             {
                //取得CPU資訊
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        //CPU溫度
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)   //每個core溫度
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Package")              //只取名稱為Package
                                cpu_TP = (float)computer.Hardware[i].Sensors[j].Value;
                        //CPU使用率
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)          //每個core使用率
                            if (computer.Hardware[i].Sensors[j].Name == "CPU Total")                //只取名稱為CPU Total
                                cpu_UR = (float)computer.Hardware[i].Sensors[j].Value;
                        //CPU時脈
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)         //每個core時脈
                            if (computer.Hardware[i].Sensors[j].Name != "Bus Speed")                //不取名稱為Bus Speed
                                if ((float)computer.Hardware[i].Sensors[j].Value != 0)
                                {
                                    cpu_GHz = cpu_GHz + (float)computer.Hardware[i].Sensors[j].Value;
                                }
                    }
                }

                //取得GPU資訊
                if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        //GPU溫度
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)   //每個core溫度
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")              
                                gpu_TP = (int)computer.Hardware[i].Sensors[j].Value;
                        //GPU使用率
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)          //使用率
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")                
                                gpu_UR = (int)computer.Hardware[i].Sensors[j].Value;
                        //GPU時脈
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Clock)         //時脈
                            if (computer.Hardware[i].Sensors[j].Name == "GPU Core")                //不取名稱為Bus Speed
                                gpu_GHz = (int)computer.Hardware[i].Sensors[j].Value;
                    }
                }
                //取得RAM資訊
                if (computer.Hardware[i].HardwareType == HardwareType.RAM)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {                      
                        //RAM使用率
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Load)          
                            if (computer.Hardware[i].Sensors[j].Name == "Memory")                   
                                ram_UR = (int)computer.Hardware[i].Sensors[j].Value;                                                                                     
                    }
                }
            }
            computer.Close();          
        }
        //關閉程式處理程序
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //強制殺死所有執行續
            Process.GetCurrentProcess().Kill();
        }

 
    }
}
