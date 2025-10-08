using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace MyTemplate.UI;

/// <summary>
///     A read-only text area control optimized for console-like output with color support.
/// </summary>
public class RichTextArea : ItemsControl
{
    public static readonly StyledProperty<ObservableCollection<LogEntry>> LogsProperty =
        AvaloniaProperty.Register<RichTextArea, ObservableCollection<LogEntry>>(
            nameof(Logs),
            defaultValue: new ObservableCollection<LogEntry>());

    public ObservableCollection<LogEntry> Logs
    {
        get => GetValue(LogsProperty);
        set => SetValue(LogsProperty, value);
    }

    public RichTextArea()
    {
        Logs = new ObservableCollection<LogEntry>();
    }

    /// <summary>
    ///     Appends a line of text with specified log level.
    /// </summary>
    public void AppendLine(string text, LogLevel level = LogLevel.Default)
    {
        Logs.Add(new LogEntry { Text = text, Level = level });
    }

    /// <summary>
    ///     Appends a line of text with custom foreground color.
    /// </summary>
    public void AppendLine(string text, IBrush foreground)
    {
        Logs.Add(new LogEntry { Text = text, Foreground = foreground });
    }

    /// <summary>
    ///     Clears all log entries.
    /// </summary>
    public new void Clear()
    {
        Logs.Clear();
    }
}
