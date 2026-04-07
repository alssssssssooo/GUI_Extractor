# Extractor GUI

語言：繁體中文 | [English](README.md) | [简体中文](README.zh-CN.md)

注意：本專案在開發過程中有使用 AI 輔助產生部分內容。發佈或再次散布前，仍建議手動審查原始碼、結構與最終調整內容。

這是一個為 [sk-zk/Extractor](https://github.com/sk-zk/Extractor) 製作的 Windows 圖形化介面，可更方便地解壓 SCS 檔案。

## 功能

- 自動下載：從 GitHub Releases 下載最新的 Extractor 執行檔
- 圖形介面：提供簡單的檔案與資料夾選擇操作
- 完整選項：支援 Extractor 常用參數，例如 --all、--deep、--separate、--skip-existing、-q
- 多語系：支援英文、繁體中文、簡體中文
- 即時日誌：可查看解壓進度與錯誤訊息
- 單一執行檔：可發佈為單一 EXE

## 需求

- Windows 10 或更新版本
- 從原始碼建置時需要 .NET 10.0 SDK
- 首次下載 Extractor 時需要網路連線

## 使用方式

1. 啟動 ExtractorGui.exe
2. 點擊 Download Extractor 以下載最新版 Extractor
3. 選擇輸入的 .scs 檔案或資料夾
4. 選擇輸出資料夾
5. 依需求勾選參數：
- All：處理目錄內所有檔案
- Deep：深度掃描巢狀內容
- Separate：每個封包分開輸出
- Skip Existing：略過已存在的檔案
- Quiet：避免等待按鍵，建議開啟
6. 點擊 Run Extractor 開始解壓
7. 在日誌區域查看進度與錯誤

## 從原始碼建置

### 前置需求

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### 建置指令

```bash
dotnet build --configuration Release
```

輸出檔案位於 bin/Release/net10.0-windows/ExtractorGui.exe。

### 發佈單一執行檔

```bash
dotnet publish --configuration Release --runtime win-x64 --self-contained true --output publish
```

發佈完成後，單一執行檔會位於 publish 資料夾。

## 語言支援

目前支援：
- English
- 繁體中文
- 简体中文

可透過右下角語言選單切換。

## 授權

本 GUI 專案可依你的 fork 規則發佈。Extractor 主程式是執行時從 [sk-zk/Extractor](https://github.com/sk-zk/Extractor) 下載。

## AI 聲明

本 GUI 專案在設計與實作過程中有使用 AI 輔助。正式發佈前，請自行確認功能、安全性、相依授權與釋出內容是否符合需求。

## 貢獻

歡迎提交 issue 或 pull request。