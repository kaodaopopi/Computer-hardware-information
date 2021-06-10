**結果圖**
![GITHUB](https://github.com/kaodaopopi/Computer-hardware-information/blob/main/CI.JPG)

# 事前準備

## 第一步

`需使用OpenHardwareMonitor套件，官方網站：http://openhardwaremonitor.org/，`

## 第二步

`檔案解壓縮，會發現有一個 OpenHardwareMonitorLib.dll 檔案，將您的 .Net 專案 參考 OpenHardwareMonitorLib.dll。(對參考右鍵 -> 加入參考 -> 找到 OpenHardwareMonitorLib.dll)`

## 第三步

`對專案右鍵 -> 加入 -> 類別 -> 找到應用程式資訊清單檔案(預設名稱:app.manifest) -> 按下新增`

## 第四步

`點開app.manifest，修改程式碼，將asInvoker改成requireAdministrator(為了使程式以系統管理員身分執行)`

```'*.cs'
<requestedExecutionLevel level="asInvoker" uiAccess="false" />
```
變成
```'*.cs'
<requestedExecutionLevel level="requireAdministrator" uiAccess="false" />
```

## 第五步

`對專案右鍵 -> 屬性 -> 安全性 -> 取修勾選 啟用ClickOnce安全性設定`
![GITHUB](https://github.com/kaodaopopi/Computer-hardware-information/blob/main/1.JPG)

# 注意
## 本程式並不支援AMD的顯示卡(如要支援，請將Form1.cs裡面的GpuNvidia改成GpuAti)
<font color=#FFD700>金色</font>



