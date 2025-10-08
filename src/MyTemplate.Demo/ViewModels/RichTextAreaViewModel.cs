using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyTemplate.UI;

namespace MyTemplate.Demo.ViewModels;

[Page("rich-text-area")]
public sealed partial class RichTextAreaViewModel : ViewModelBase, INavigable
{
    private readonly PageManager _pageManager;

    [ObservableProperty]
    private ObservableCollection<LogEntry> _consoleLogs = new();

    [ObservableProperty]
    private string _inputText = string.Empty;

    [ObservableProperty]
    private string _defaultCode = @"<shadui:RichTextArea Height=""200"" />";

    [ObservableProperty]
    private string _coloredLogsCode = @"// Demoend colored log entries
richTextArea.DemoendLine(""Starting application..."", LogLevel.Info);
richTextArea.DemoendLine(""Operation successful"", LogLevel.Success);
richTextArea.DemoendLine(""Warning: Resource low"", LogLevel.Warning);
richTextArea.DemoendLine(""Error occurred!"", LogLevel.Error);";

    public RichTextAreaViewModel(PageManager pageManager)
    {
        _pageManager = pageManager;
    }

    public void Initialize()
    {
        ConsoleLogs.Clear();
        ConsoleLogs.Add(new LogEntry { Text = "Welcome to RichTextArea Demo!", Level = LogLevel.Primary });
        ConsoleLogs.Add(new LogEntry { Text = "This control supports colored text output.", Level = LogLevel.Default });
        ConsoleLogs.Add(new LogEntry { Text = $"[{DateTime.Now:HH:mm:ss}] Demolication initialized", Level = LogLevel.Success });
        ConsoleLogs.Add(new LogEntry { Text = "-----------------------------------", Level = LogLevel.Muted });
    }

    [RelayCommand]
    private void DemoendText()
    {
        if (!string.IsNullOrWhiteSpace(InputText))
        {
            ConsoleLogs.Add(new LogEntry
            {
                Text = $"[{DateTime.Now:HH:mm:ss}] {InputText}",
                Level = LogLevel.Default
            });
            InputText = string.Empty;
        }
    }

    [RelayCommand]
    private void ClearConsole()
    {
        ConsoleLogs.Clear();
    }

    [RelayCommand]
    private void AddInfoLog()
    {
        ConsoleLogs.Add(new LogEntry
        {
            Text = $"[{DateTime.Now:HH:mm:ss}] INFO: Processing request...",
            Level = LogLevel.Info
        });
    }

    [RelayCommand]
    private void AddSuccessLog()
    {
        ConsoleLogs.Add(new LogEntry
        {
            Text = $"[{DateTime.Now:HH:mm:ss}] SUCCESS: Operation completed successfully",
            Level = LogLevel.Success
        });
    }

    [RelayCommand]
    private void AddWarningLog()
    {
        ConsoleLogs.Add(new LogEntry
        {
            Text = $"[{DateTime.Now:HH:mm:ss}] WARNING: Resource usage is high",
            Level = LogLevel.Warning
        });
    }

    [RelayCommand]
    private void AddErrorLog()
    {
        ConsoleLogs.Add(new LogEntry
        {
            Text = $"[{DateTime.Now:HH:mm:ss}] ERROR: An error occurred while processing",
            Level = LogLevel.Error
        });
    }

    [RelayCommand]
    private void AddColoredSequence()
    {
        ConsoleLogs.Add(new LogEntry { Text = "Starting multi-step process...", Level = LogLevel.Primary });
        ConsoleLogs.Add(new LogEntry { Text = "Step 1: Loading configuration", Level = LogLevel.Info });
        ConsoleLogs.Add(new LogEntry { Text = "Step 2: Connecting to database", Level = LogLevel.Info });
        ConsoleLogs.Add(new LogEntry { Text = "Step 3: Validating data", Level = LogLevel.Warning });
        ConsoleLogs.Add(new LogEntry { Text = "Process completed", Level = LogLevel.Success });
    }

    [RelayCommand]
    private void BackPage()
    {
        _pageManager.Navigate<NumericViewModel>();
    }

    [RelayCommand]
    private void NextPage()
    {
        _pageManager.Navigate<SidebarViewModel>();
    }
}
