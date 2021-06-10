
namespace Computer_Information
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CPU_label = new System.Windows.Forms.Label();
            this.GPU_label = new System.Windows.Forms.Label();
            this.RAM_label = new System.Windows.Forms.Label();
            this.CPU_T = new System.Windows.Forms.Label();
            this.CPU_Temperature_label = new System.Windows.Forms.Label();
            this.CPU_Degree_label = new System.Windows.Forms.Label();
            this.CPU_UR_label = new System.Windows.Forms.Label();
            this.CPU_UR = new System.Windows.Forms.Label();
            this.CPU_Percentage_label = new System.Windows.Forms.Label();
            this.CPU_Clock_label = new System.Windows.Forms.Label();
            this.CPU_GHz = new System.Windows.Forms.Label();
            this.CPU_GHz_label = new System.Windows.Forms.Label();
            this.GPU_GHz_label = new System.Windows.Forms.Label();
            this.GPU_GHz = new System.Windows.Forms.Label();
            this.GPU_Clock_label = new System.Windows.Forms.Label();
            this.GPU_Percentage_label = new System.Windows.Forms.Label();
            this.GPU_UR = new System.Windows.Forms.Label();
            this.GPU_UR_label = new System.Windows.Forms.Label();
            this.GPU_Degree_label = new System.Windows.Forms.Label();
            this.GPU_Temperature_label = new System.Windows.Forms.Label();
            this.GPU_T = new System.Windows.Forms.Label();
            this.RAM_Percentage_label = new System.Windows.Forms.Label();
            this.RAM_UR = new System.Windows.Forms.Label();
            this.RAM_UR_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPU_label
            // 
            this.CPU_label.AutoSize = true;
            this.CPU_label.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_label.Location = new System.Drawing.Point(146, 52);
            this.CPU_label.Name = "CPU_label";
            this.CPU_label.Size = new System.Drawing.Size(66, 32);
            this.CPU_label.TabIndex = 0;
            this.CPU_label.Text = "CPU";
            this.CPU_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // GPU_label
            // 
            this.GPU_label.AutoSize = true;
            this.GPU_label.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_label.Location = new System.Drawing.Point(528, 52);
            this.GPU_label.Name = "GPU_label";
            this.GPU_label.Size = new System.Drawing.Size(66, 32);
            this.GPU_label.TabIndex = 1;
            this.GPU_label.Text = "GPU";
            // 
            // RAM_label
            // 
            this.RAM_label.AutoSize = true;
            this.RAM_label.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RAM_label.Location = new System.Drawing.Point(904, 52);
            this.RAM_label.Name = "RAM_label";
            this.RAM_label.Size = new System.Drawing.Size(66, 32);
            this.RAM_label.TabIndex = 2;
            this.RAM_label.Text = "RAM";
            // 
            // CPU_T
            // 
            this.CPU_T.AutoSize = true;
            this.CPU_T.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_T.Location = new System.Drawing.Point(213, 138);
            this.CPU_T.Name = "CPU_T";
            this.CPU_T.Size = new System.Drawing.Size(21, 24);
            this.CPU_T.TabIndex = 5;
            this.CPU_T.Text = "0";
            this.CPU_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPU_T.Click += new System.EventHandler(this.CPU_T_Click);
            // 
            // CPU_Temperature_label
            // 
            this.CPU_Temperature_label.AutoSize = true;
            this.CPU_Temperature_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_Temperature_label.Location = new System.Drawing.Point(43, 138);
            this.CPU_Temperature_label.Name = "CPU_Temperature_label";
            this.CPU_Temperature_label.Size = new System.Drawing.Size(108, 24);
            this.CPU_Temperature_label.TabIndex = 6;
            this.CPU_Temperature_label.Text = "CPU溫度:";
            // 
            // CPU_Degree_label
            // 
            this.CPU_Degree_label.AutoSize = true;
            this.CPU_Degree_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_Degree_label.Location = new System.Drawing.Point(286, 138);
            this.CPU_Degree_label.Name = "CPU_Degree_label";
            this.CPU_Degree_label.Size = new System.Drawing.Size(31, 24);
            this.CPU_Degree_label.TabIndex = 7;
            this.CPU_Degree_label.Text = "°C";
            this.CPU_Degree_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // CPU_UR_label
            // 
            this.CPU_UR_label.AutoSize = true;
            this.CPU_UR_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_UR_label.Location = new System.Drawing.Point(43, 227);
            this.CPU_UR_label.Name = "CPU_UR_label";
            this.CPU_UR_label.Size = new System.Drawing.Size(132, 24);
            this.CPU_UR_label.TabIndex = 8;
            this.CPU_UR_label.Text = "CPU使用率:";
            // 
            // CPU_UR
            // 
            this.CPU_UR.AutoSize = true;
            this.CPU_UR.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_UR.Location = new System.Drawing.Point(213, 227);
            this.CPU_UR.Name = "CPU_UR";
            this.CPU_UR.Size = new System.Drawing.Size(21, 24);
            this.CPU_UR.TabIndex = 9;
            this.CPU_UR.Text = "0";
            this.CPU_UR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPU_Percentage_label
            // 
            this.CPU_Percentage_label.AutoSize = true;
            this.CPU_Percentage_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_Percentage_label.Location = new System.Drawing.Point(288, 227);
            this.CPU_Percentage_label.Name = "CPU_Percentage_label";
            this.CPU_Percentage_label.Size = new System.Drawing.Size(29, 24);
            this.CPU_Percentage_label.TabIndex = 10;
            this.CPU_Percentage_label.Text = "%";
            // 
            // CPU_Clock_label
            // 
            this.CPU_Clock_label.AutoSize = true;
            this.CPU_Clock_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_Clock_label.Location = new System.Drawing.Point(43, 318);
            this.CPU_Clock_label.Name = "CPU_Clock_label";
            this.CPU_Clock_label.Size = new System.Drawing.Size(108, 24);
            this.CPU_Clock_label.TabIndex = 11;
            this.CPU_Clock_label.Text = "CPU時脈:";
            // 
            // CPU_GHz
            // 
            this.CPU_GHz.AutoSize = true;
            this.CPU_GHz.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_GHz.Location = new System.Drawing.Point(213, 318);
            this.CPU_GHz.Name = "CPU_GHz";
            this.CPU_GHz.Size = new System.Drawing.Size(21, 24);
            this.CPU_GHz.TabIndex = 12;
            this.CPU_GHz.Text = "0";
            this.CPU_GHz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPU_GHz_label
            // 
            this.CPU_GHz_label.AutoSize = true;
            this.CPU_GHz_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CPU_GHz_label.Location = new System.Drawing.Point(288, 318);
            this.CPU_GHz_label.Name = "CPU_GHz_label";
            this.CPU_GHz_label.Size = new System.Drawing.Size(52, 24);
            this.CPU_GHz_label.TabIndex = 13;
            this.CPU_GHz_label.Text = "GHz";
            // 
            // GPU_GHz_label
            // 
            this.GPU_GHz_label.AutoSize = true;
            this.GPU_GHz_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_GHz_label.Location = new System.Drawing.Point(654, 316);
            this.GPU_GHz_label.Name = "GPU_GHz_label";
            this.GPU_GHz_label.Size = new System.Drawing.Size(56, 24);
            this.GPU_GHz_label.TabIndex = 23;
            this.GPU_GHz_label.Text = "MHz";
            // 
            // GPU_GHz
            // 
            this.GPU_GHz.AutoSize = true;
            this.GPU_GHz.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_GHz.Location = new System.Drawing.Point(573, 316);
            this.GPU_GHz.Name = "GPU_GHz";
            this.GPU_GHz.Size = new System.Drawing.Size(21, 24);
            this.GPU_GHz.TabIndex = 22;
            this.GPU_GHz.Text = "0";
            this.GPU_GHz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPU_Clock_label
            // 
            this.GPU_Clock_label.AutoSize = true;
            this.GPU_Clock_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_Clock_label.Location = new System.Drawing.Point(414, 316);
            this.GPU_Clock_label.Name = "GPU_Clock_label";
            this.GPU_Clock_label.Size = new System.Drawing.Size(109, 24);
            this.GPU_Clock_label.TabIndex = 21;
            this.GPU_Clock_label.Text = "GPU時脈:";
            // 
            // GPU_Percentage_label
            // 
            this.GPU_Percentage_label.AutoSize = true;
            this.GPU_Percentage_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_Percentage_label.Location = new System.Drawing.Point(654, 225);
            this.GPU_Percentage_label.Name = "GPU_Percentage_label";
            this.GPU_Percentage_label.Size = new System.Drawing.Size(29, 24);
            this.GPU_Percentage_label.TabIndex = 20;
            this.GPU_Percentage_label.Text = "%";
            // 
            // GPU_UR
            // 
            this.GPU_UR.AutoSize = true;
            this.GPU_UR.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_UR.Location = new System.Drawing.Point(573, 225);
            this.GPU_UR.Name = "GPU_UR";
            this.GPU_UR.Size = new System.Drawing.Size(21, 24);
            this.GPU_UR.TabIndex = 19;
            this.GPU_UR.Text = "0";
            this.GPU_UR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPU_UR_label
            // 
            this.GPU_UR_label.AutoSize = true;
            this.GPU_UR_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_UR_label.Location = new System.Drawing.Point(414, 225);
            this.GPU_UR_label.Name = "GPU_UR_label";
            this.GPU_UR_label.Size = new System.Drawing.Size(133, 24);
            this.GPU_UR_label.TabIndex = 18;
            this.GPU_UR_label.Text = "GPU使用率:";
            // 
            // GPU_Degree_label
            // 
            this.GPU_Degree_label.AutoSize = true;
            this.GPU_Degree_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_Degree_label.Location = new System.Drawing.Point(652, 136);
            this.GPU_Degree_label.Name = "GPU_Degree_label";
            this.GPU_Degree_label.Size = new System.Drawing.Size(31, 24);
            this.GPU_Degree_label.TabIndex = 17;
            this.GPU_Degree_label.Text = "°C";
            // 
            // GPU_Temperature_label
            // 
            this.GPU_Temperature_label.AutoSize = true;
            this.GPU_Temperature_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_Temperature_label.Location = new System.Drawing.Point(414, 136);
            this.GPU_Temperature_label.Name = "GPU_Temperature_label";
            this.GPU_Temperature_label.Size = new System.Drawing.Size(109, 24);
            this.GPU_Temperature_label.TabIndex = 16;
            this.GPU_Temperature_label.Text = "GPU溫度:";
            // 
            // GPU_T
            // 
            this.GPU_T.AutoSize = true;
            this.GPU_T.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GPU_T.Location = new System.Drawing.Point(573, 136);
            this.GPU_T.Name = "GPU_T";
            this.GPU_T.Size = new System.Drawing.Size(21, 24);
            this.GPU_T.TabIndex = 15;
            this.GPU_T.Text = "0";
            this.GPU_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAM_Percentage_label
            // 
            this.RAM_Percentage_label.AutoSize = true;
            this.RAM_Percentage_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RAM_Percentage_label.Location = new System.Drawing.Point(1026, 138);
            this.RAM_Percentage_label.Name = "RAM_Percentage_label";
            this.RAM_Percentage_label.Size = new System.Drawing.Size(29, 24);
            this.RAM_Percentage_label.TabIndex = 29;
            this.RAM_Percentage_label.Text = "%";
            // 
            // RAM_UR
            // 
            this.RAM_UR.AutoSize = true;
            this.RAM_UR.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RAM_UR.Location = new System.Drawing.Point(949, 138);
            this.RAM_UR.Name = "RAM_UR";
            this.RAM_UR.Size = new System.Drawing.Size(21, 24);
            this.RAM_UR.TabIndex = 28;
            this.RAM_UR.Text = "0";
            this.RAM_UR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAM_UR_label
            // 
            this.RAM_UR_label.AutoSize = true;
            this.RAM_UR_label.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RAM_UR_label.Location = new System.Drawing.Point(767, 136);
            this.RAM_UR_label.Name = "RAM_UR_label";
            this.RAM_UR_label.Size = new System.Drawing.Size(139, 24);
            this.RAM_UR_label.TabIndex = 27;
            this.RAM_UR_label.Text = "RAM使用率:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1126, 403);
            this.Controls.Add(this.CPU_label);
            this.Controls.Add(this.GPU_label);
            this.Controls.Add(this.CPU_GHz_label);
            this.Controls.Add(this.CPU_GHz);
            this.Controls.Add(this.CPU_Clock_label);
            this.Controls.Add(this.CPU_Percentage_label);
            this.Controls.Add(this.CPU_UR);
            this.Controls.Add(this.CPU_UR_label);
            this.Controls.Add(this.CPU_Degree_label);
            this.Controls.Add(this.CPU_T);
            this.Controls.Add(this.CPU_Temperature_label);
            this.Controls.Add(this.RAM_Percentage_label);
            this.Controls.Add(this.RAM_UR);
            this.Controls.Add(this.RAM_UR_label);
            this.Controls.Add(this.GPU_GHz_label);
            this.Controls.Add(this.GPU_GHz);
            this.Controls.Add(this.GPU_Clock_label);
            this.Controls.Add(this.GPU_Percentage_label);
            this.Controls.Add(this.GPU_UR);
            this.Controls.Add(this.GPU_UR_label);
            this.Controls.Add(this.GPU_Degree_label);
            this.Controls.Add(this.GPU_Temperature_label);
            this.Controls.Add(this.GPU_T);
            this.Controls.Add(this.RAM_label);
            this.Name = "Form1";
            this.Text = "CI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPU_label;
        private System.Windows.Forms.Label GPU_label;
        private System.Windows.Forms.Label RAM_label;
        private System.Windows.Forms.Label CPU_T;
        private System.Windows.Forms.Label CPU_Temperature_label;
        private System.Windows.Forms.Label CPU_Degree_label;
        private System.Windows.Forms.Label CPU_UR_label;
        private System.Windows.Forms.Label CPU_UR;
        private System.Windows.Forms.Label CPU_Percentage_label;
        private System.Windows.Forms.Label CPU_Clock_label;
        private System.Windows.Forms.Label CPU_GHz;
        private System.Windows.Forms.Label CPU_GHz_label;
        private System.Windows.Forms.Label GPU_GHz_label;
        private System.Windows.Forms.Label GPU_GHz;
        private System.Windows.Forms.Label GPU_Clock_label;
        private System.Windows.Forms.Label GPU_Percentage_label;
        private System.Windows.Forms.Label GPU_UR;
        private System.Windows.Forms.Label GPU_UR_label;
        private System.Windows.Forms.Label GPU_Degree_label;
        private System.Windows.Forms.Label GPU_Temperature_label;
        private System.Windows.Forms.Label GPU_T;
        private System.Windows.Forms.Label RAM_Percentage_label;
        private System.Windows.Forms.Label RAM_UR;
        private System.Windows.Forms.Label RAM_UR_label;
    }
}

