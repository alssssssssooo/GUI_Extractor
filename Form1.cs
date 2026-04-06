using System.Diagnostics;
using System.IO.Compression;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;

namespace ExtractorGui;

public partial class Form1 : Form
{
    private readonly Dictionary<string, string> _english = new()
    {
        ["Title"] = "Extractor GUI",
        ["DownloadExtractor"] = "Download Extractor",
        ["RunExtractor"] = "Run Extractor",
        ["Help"] = "Help",
        ["InputPath"] = "Input file / folder:",
        ["OutputPath"] = "Output folder:",
        ["BrowseFile"] = "Browse File...",
        ["BrowseFolder"] = "Browse Folder...",
        ["Options"] = "Extraction Options",
        ["All"] = "--all (extract all .scs in folder)",
        ["Deep"] = "--deep (HashFS deep scan)",
        ["Separate"] = "--separate (separate output folders)",
        ["SkipExisting"] = "--skip-existing (do not overwrite)",
        ["Quiet"] = "-q (do not wait for keypress)",
        ["Language"] = "Language",
        ["StatusReady"] = "Ready.",
        ["StatusDownloading"] = "Downloading latest Extractor...",
        ["StatusDownloaded"] = "Extractor installed: {0}.",
        ["StatusDownloadFailed"] = "Download failed.",
        ["StatusExtractorMissing"] = "Extractor executable not found. Please download first.",
        ["StatusRunning"] = "Running Extractor...",
        ["StatusCompleted"] = "Extractor finished with exit code {0}.",
        ["StatusSelectInput"] = "Please select an input file or folder.",
        ["StatusSelectOutput"] = "Please select an output folder.",
        ["Error"] = "Error: {0}",
        ["LogHeader"] = "Log output",
        ["StatusExtractorReady"] = "Extractor is ready.",
        ["DownloadFailedNoAsset"] = "Cannot find a Windows release asset.",
        ["HelpTitle"] = "Usage Guide",
        ["UsageText"] = "1. Click 'Download Extractor' to download the latest Extractor executable.\r\n2. Choose an input .scs file or folder.\r\n3. Choose an output folder.\r\n4. Select options as needed: --all, --deep, --separate, --skip-existing, -q.\r\n5. Click 'Run Extractor' to extract files.\r\n6. Monitor the log output for progress and errors.\r\n7. Use the language selector to switch between English and Chinese.",
        ["DownloadFailedHttp"] = "HTTP download failed.",
    };

    private readonly Dictionary<string, string> _traditionalChinese = new()
    {
        ["Title"] = "Extractor GUI",
        ["DownloadExtractor"] = "下載 Extractor",
        ["RunExtractor"] = "執行 Extractor",
        ["Help"] = "使用說明",
        ["InputPath"] = "輸入檔案 / 資料夾：",
        ["OutputPath"] = "輸出資料夾：",
        ["BrowseFile"] = "選擇檔案...",
        ["BrowseFolder"] = "選擇資料夾...",
        ["Options"] = "提取選項",
        ["All"] = "--all（提取資料夾內所有 .scs）",
        ["Deep"] = "--deep（HashFS 深度掃描）",
        ["Separate"] = "--separate（分別輸出）",
        ["SkipExisting"] = "--skip-existing（不覆蓋既有檔案）",
        ["Quiet"] = "-q（不等待按鍵）",
        ["Language"] = "語言",
        ["StatusReady"] = "準備就緒。",
        ["StatusDownloading"] = "正在下載最新 Extractor...",
        ["StatusDownloaded"] = "已安裝 Extractor：{0}。",
        ["StatusDownloadFailed"] = "下載失敗。",
        ["StatusExtractorMissing"] = "找不到 Extractor 可執行檔。請先下載。",
        ["StatusRunning"] = "正在執行 Extractor...",
        ["StatusCompleted"] = "Extractor 已完成，退出代碼 {0}。",
        ["StatusSelectInput"] = "請選擇輸入檔案或資料夾。",
        ["StatusSelectOutput"] = "請選擇輸出資料夾。",
        ["Error"] = "錯誤：{0}",
        ["LogHeader"] = "日誌輸出",
        ["StatusExtractorReady"] = "Extractor 準備就緒。",
        ["DownloadFailedNoAsset"] = "找不到適用於 Windows 的發布資產。",
        ["DownloadFailedHttp"] = "HTTP 下載失敗。",
        ["HelpTitle"] = "使用說明",
        ["UsageText"] = "1. 點擊「下載 Extractor」以下載最新的 Extractor 可執行檔案。\r\n2. 選擇輸入的 .scs 檔案或資料夾。\r\n3. 選擇輸出資料夾。\r\n4. 根據需要選擇選項：--all、--deep、--separate、--skip-existing、-q。\r\n5. 點擊「執行 Extractor」來提取檔案。\r\n6. 監控日誌輸出以查看進度和錯誤。\r\n7. 使用語言選擇器在英文和中文之間切換。",
    };

    private readonly Dictionary<string, string> _simplifiedChinese = new()
    {
        ["Title"] = "Extractor GUI",
        ["DownloadExtractor"] = "下载 Extractor",
        ["RunExtractor"] = "运行 Extractor",
        ["Help"] = "使用说明",
        ["InputPath"] = "输入文件 / 文件夹：",
        ["OutputPath"] = "输出文件夹：",
        ["BrowseFile"] = "选择文件...",
        ["BrowseFolder"] = "选择文件夹...",
        ["Options"] = "提取选项",
        ["All"] = "--all（提取文件夹内所有 .scs）",
        ["Deep"] = "--deep（HashFS 深度扫描）",
        ["Separate"] = "--separate（分别输出）",
        ["SkipExisting"] = "--skip-existing（不覆盖现有文件）",
        ["Quiet"] = "-q（不等待按键）",
        ["Language"] = "语言",
        ["StatusReady"] = "准备就绪。",
        ["StatusDownloading"] = "正在下载最新 Extractor...",
        ["StatusDownloaded"] = "已安装 Extractor：{0}。",
        ["StatusDownloadFailed"] = "下载失败。",
        ["StatusExtractorMissing"] = "找不到 Extractor 可执行文件。请先下载。",
        ["StatusRunning"] = "正在运行 Extractor...",
        ["StatusCompleted"] = "Extractor 已完成，退出代码 {0}。",
        ["StatusSelectInput"] = "请选择输入文件或文件夹。",
        ["StatusSelectOutput"] = "请选择输出文件夹。",
        ["Error"] = "错误：{0}",
        ["LogHeader"] = "日志输出",
        ["StatusExtractorReady"] = "Extractor 已准备就绪。",
        ["DownloadFailedNoAsset"] = "找不到适用于 Windows 的发布资产。",
        ["DownloadFailedHttp"] = "HTTP 下载失败。",
        ["HelpTitle"] = "使用说明",
        ["UsageText"] = "1. 点击"下载 Extractor"以下载最新的 Extractor 可执行文件。\r\n2. 选择输入的 .scs 文件或文件夹。\r\n3. 选择输出文件夹。\r\n4. 根据需要选择选项：--all、--deep、--separate、--skip-existing、-q。\r\n5. 点击"运行 Extractor"来提取文件。\r\n6. 监控日志输出以查看进度和错误。\r\n7. 使用语言选择器在英文和中文之间切换。",
    };

    private Dictionary<string, string> _text = null!;
    private string? _tempExtractorExe;

    public Form1()
    {
        InitializeComponent();

        _tempExtractorExe = null;

        cbLanguage.Items.Add("中文（繁體）");
        cbLanguage.Items.Add("中文（简体）");
        cbLanguage.Items.Add("English");
        cbLanguage.SelectedIndex = 0;

        SetLanguage("zh-tw");
        UpdateStatus(_text["StatusReady"]);
    }

    private void SetLanguage(string language)
    {
        _text = language switch
        {
            "en" => _english,
            "zh-cn" => _simplifiedChinese,
            _ => _traditionalChinese,
        };

        Text = _text["Title"];
        btnDownload.Text = _text["DownloadExtractor"];
        btnRun.Text = _text["RunExtractor"];
        btnHelp.Text = _text["Help"];
        lblInput.Text = _text["InputPath"];
        lblOutput.Text = _text["OutputPath"];
        btnBrowseInput.Text = _text["BrowseFile"];
        btnBrowseOutput.Text = _text["BrowseFolder"];
        grpOptions.Text = _text["Options"];
        cbAll.Text = _text["All"];
        cbDeep.Text = _text["Deep"];
        cbSeparate.Text = _text["Separate"];
        cbSkipExisting.Text = _text["SkipExisting"];
        cbQuiet.Text = _text["Quiet"];
        lblLanguage.Text = _text["Language"];
        lblLog.Text = _text["LogHeader"];
    }

    private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cbLanguage.SelectedIndex)
        {
            case 0:
                SetLanguage("zh-tw");
                break;
            case 1:
                SetLanguage("zh-cn");
                break;
            default:
                SetLanguage("en");
                break;
        }
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        using var form = new HelpForm(_text);
        form.ShowDialog(this);
    }

    private async void btnDownload_Click(object sender, EventArgs e)
    {
        await DownloadLatestExtractorAsync();
    }

    private async Task DownloadLatestExtractorAsync()
    {
        SetUiEnabled(false);
        UpdateStatus(_text["StatusDownloading"]);

        try
        {
            if (!string.IsNullOrEmpty(_tempExtractorExe) && File.Exists(_tempExtractorExe))
            {
                UpdateStatus(_text["StatusExtractorReady"]);
                return;
            }

            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("ExtractorGui/1.0");

            using var response = await client.GetAsync("https://api.github.com/repos/sk-zk/Extractor/releases/latest");
            response.EnsureSuccessStatusCode();

            using var contentStream = await response.Content.ReadAsStreamAsync();
            using var document = await JsonDocument.ParseAsync(contentStream);
            var root = document.RootElement;
            var tagName = root.GetProperty("tag_name").GetString() ?? string.Empty;
            var assets = root.GetProperty("assets").EnumerateArray();
            string? downloadUrl = null;

            foreach (var asset in assets)
            {
                var name = asset.GetProperty("name").GetString();
                if (name != null && name.Contains("-win-x64.zip", StringComparison.OrdinalIgnoreCase))
                {
                    downloadUrl = asset.GetProperty("browser_download_url").GetString();
                    break;
                }
            }

            if (string.IsNullOrEmpty(downloadUrl))
            {
                throw new InvalidOperationException(_text["DownloadFailedNoAsset"]);
            }

            var tempPath = Path.Combine(Path.GetTempPath(), $"ExtractorGui_{Guid.NewGuid():N}.exe");
            using var zipResponse = await client.GetAsync(downloadUrl);
            zipResponse.EnsureSuccessStatusCode();

            await using (var fileStream = File.Create(tempPath))
            {
                await zipResponse.Content.CopyToAsync(fileStream);
            }

            _tempExtractorExe = tempPath;
            UpdateStatus(string.Format(_text["StatusDownloaded"], tagName));
            LogMessage(_text["StatusExtractorReady"]);
        }
        catch (Exception ex)
        {
            UpdateStatus(_text["StatusDownloadFailed"]);
            LogMessage(string.Format(_text["Error"], ex.Message));
        }
        finally
        {
            SetUiEnabled(true);
        }
    }

    private void btnBrowseInput_Click(object sender, EventArgs e)
    {
        using var openDialog = new OpenFileDialog();
        openDialog.Filter = "SCS files (*.scs)|*.scs|All files (*.*)|*.*";
        openDialog.Title = _text["BrowseFile"];

        if (openDialog.ShowDialog() == DialogResult.OK)
        {
            tbInputPath.Text = openDialog.FileName;
        }
    }

    private void btnBrowseOutput_Click(object sender, EventArgs e)
    {
        using var folderDialog = new FolderBrowserDialog();
        folderDialog.Description = _text["OutputPath"];

        if (folderDialog.ShowDialog() == DialogResult.OK)
        {
            tbOutputPath.Text = folderDialog.SelectedPath;
        }
    }

    private async void btnRun_Click(object sender, EventArgs e)
    {
        await RunExtractorAsync();
    }

    private async Task RunExtractorAsync()
    {
        if (_tempExtractorExe == null || !File.Exists(_tempExtractorExe))
        {
            await DownloadLatestExtractorAsync();
        }

        if (_tempExtractorExe == null || !File.Exists(_tempExtractorExe))
        {
            UpdateStatus(_text["StatusExtractorMissing"]);
            return;
        }

        if (string.IsNullOrWhiteSpace(tbInputPath.Text))
        {
            UpdateStatus(_text["StatusSelectInput"]);
            return;
        }

        if (string.IsNullOrWhiteSpace(tbOutputPath.Text))
        {
            UpdateStatus(_text["StatusSelectOutput"]);
            return;
        }

        SetUiEnabled(false);
        UpdateStatus(_text["StatusRunning"]);

        try
        {
            var args = new List<string>();

            if (cbAll.Checked)
            {
                args.Add("--all");
            }

            if (cbDeep.Checked)
            {
                args.Add("--deep");
            }

            if (cbSeparate.Checked)
            {
                args.Add("--separate");
            }

            if (cbSkipExisting.Checked)
            {
                args.Add("--skip-existing");
            }

            if (cbQuiet.Checked)
            {
                args.Add("-q");
            }

            args.Add("-d");
            args.Add(tbOutputPath.Text);
            args.Add(tbInputPath.Text);

            var startInfo = new ProcessStartInfo
            {
                FileName = _tempExtractorExe,
                Arguments = string.Join(' ', args.Select(QuoteArgument)),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using var process = new Process { StartInfo = startInfo, EnableRaisingEvents = true };

            process.OutputDataReceived += (_, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    Invoke(() => LogMessage(e.Data));
                }
            };

            process.ErrorDataReceived += (_, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    Invoke(() => LogMessage(e.Data));
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await process.WaitForExitAsync();
            UpdateStatus(string.Format(_text["StatusCompleted"], process.ExitCode));
        }
        catch (Exception ex)
        {
            UpdateStatus(_text["Error"], ex.Message);
            LogMessage(string.Format(_text["Error"], ex.Message));
        }
        finally
        {
            if (!string.IsNullOrEmpty(_tempExtractorExe) && File.Exists(_tempExtractorExe))
            {
                try
                {
                    File.Delete(_tempExtractorExe);
                }
                catch
                {
                    // ignore temp cleanup failures
                }

                _tempExtractorExe = null;
            }

            SetUiEnabled(true);
            CheckExtractorExists();
        }
    }

    private static string QuoteArgument(string value)
    {
        return value.Contains(' ') ? '"' + value + '"' : value;
    }

    private void SetUiEnabled(bool enabled)
    {
        btnDownload.Enabled = enabled;
        btnRun.Enabled = enabled;
        btnBrowseInput.Enabled = enabled;
        btnBrowseOutput.Enabled = enabled;
        cbAll.Enabled = enabled;
        cbDeep.Enabled = enabled;
        cbSeparate.Enabled = enabled;
        cbSkipExisting.Enabled = enabled;
        cbQuiet.Enabled = enabled;
        cbLanguage.Enabled = enabled;
    }

    private void UpdateStatus(string status, params object[] args)
    {
        if (args.Length > 0)
        {
            status = string.Format(status, args);
        }

        lblStatus.Text = status;
    }

    private void LogMessage(string message)
    {
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        tbLog.AppendText($"[{timestamp}] {message}{Environment.NewLine}");
    }

    private void CheckExtractorExists()
    {
        if (!string.IsNullOrEmpty(_tempExtractorExe) && File.Exists(_tempExtractorExe))
        {
            UpdateStatus(_text["StatusExtractorReady"]);
        }
        else
        {
            UpdateStatus(_text["StatusExtractorMissing"]);
        }
    }
}
