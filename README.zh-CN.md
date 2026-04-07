# Extractor GUI

语言：简体中文 | [English](README.md) | [繁體中文](README.zh-TW.md)

注意：本项目在开发过程中使用了 AI 辅助生成部分内容。发布或再次分发前，仍建议手动审查源码、结构与最终调整内容。

这是一个为 [sk-zk/Extractor](https://github.com/sk-zk/Extractor) 制作的 Windows 图形界面，可更方便地解压 SCS 文件。

## 功能

- 自动下载：从 GitHub Releases 下载最新的 Extractor 可执行文件
- 图形界面：提供简单的文件与文件夹选择操作
- 完整选项：支持 Extractor 常用参数，例如 --all、--deep、--separate、--skip-existing、-q
- 多语言：支持英文、繁体中文、简体中文
- 实时日志：可查看解压进度与错误信息
- 单一可执行文件：可发布为单一 EXE

## 需求

- Windows 10 或更高版本
- 从源码构建时需要 .NET 10.0 SDK
- 首次下载 Extractor 时需要网络连接

## 使用方式

1. 启动 ExtractorGui.exe
2. 点击 Download Extractor 下载最新版 Extractor
3. 选择输入的 .scs 文件或文件夹
4. 选择输出文件夹
5. 按需勾选参数：
- All：处理目录内所有文件
- Deep：深度扫描嵌套内容
- Separate：每个封包分开输出
- Skip Existing：跳过已存在的文件
- Quiet：避免等待按键，建议开启
6. 点击 Run Extractor 开始解压
7. 在日志区域查看进度与错误

## 从源码构建

### 前置需求

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### 构建命令

```bash
dotnet build --configuration Release
```

输出文件位于 bin/Release/net10.0-windows/ExtractorGui.exe。

### 发布单一可执行文件

```bash
dotnet publish --configuration Release --runtime win-x64 --self-contained true --output publish
```

发布完成后，单一可执行文件位于 publish 文件夹。

## 语言支持

目前支持：
- English
- 繁體中文
- 简体中文

可通过右下角语言菜单切换。

## 许可

本 GUI 项目可按你的 fork 规则发布。Extractor 主程序是在运行时从 [sk-zk/Extractor](https://github.com/sk-zk/Extractor) 下载。

## AI 声明

本 GUI 项目在设计与实现过程中使用了 AI 辅助。正式发布前，请自行确认功能、安全性、依赖许可与发布内容是否符合需求。

## 贡献

欢迎提交 issue 或 pull request。