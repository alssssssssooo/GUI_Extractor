[README.md](https://github.com/user-attachments/files/26510960/README.md)
# Extractor GUI
*Note: This project was created using AI.

A Windows GUI application for [sk-zk/Extractor](https://github.com/sk-zk/Extractor) that provides an easy-to-use interface for extracting SCS files.

## Features

- **Automatic Download**: Downloads the latest Extractor executable from GitHub releases
- **User-Friendly Interface**: Simple GUI with file/folder selection
- **Multiple Options**: Support for all Extractor command-line options (--all, --deep, --separate, --skip-existing, -q)
- **Multi-Language Support**: English, Traditional Chinese, and Simplified Chinese
- **Real-time Logging**: Monitor extraction progress and errors
- **Single Executable**: Self-contained application with no external dependencies

## Requirements

- Windows 10 or later
- .NET 8.0 Runtime (automatically included in published executable)
- Internet connection for downloading Extractor

## Usage

1. Launch the ExtractorGUI.exe
2. Click "Download Extractor" to download the latest Extractor executable
3. Select an input .scs file or folder
4. Choose an output folder
5. Select extraction options as needed:
   - **All**: Extract all files
   - **Deep**: Extract nested archives
   - **Separate**: Extract to separate folders
   - **Skip Existing**: Skip files that already exist
   - **Quiet**: Suppress keypress prompts (recommended)
6. Click "Run Extractor" to start extraction
7. Monitor the log output for progress and any errors

## Building from Source

### Prerequisites

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Build Steps

1. Clone or download this repository
2. Open a terminal in the project directory
3. Run the following command to build:

```bash
dotnet build --configuration Release
```

4. The executable will be created in `bin/Release/net10.0-windows/ExtractorGui.exe`

### Publishing as Single Executable

To create a self-contained executable:

```bash
dotnet publish --configuration Release --runtime win-x64 --self-contained true --output publish
```

The single executable will be in the `publish` folder.

## Language Support

The application supports three languages:
- English
- Traditional Chinese (繁體中文)
- Simplified Chinese (简体中文)

You can switch languages using the dropdown in the bottom-right corner.

## License

This project is open source. The Extractor executable is downloaded from the [sk-zk/Extractor](https://github.com/sk-zk/Extractor) project.

## Contributing

Feel free to submit issues and pull requests on GitHub.
