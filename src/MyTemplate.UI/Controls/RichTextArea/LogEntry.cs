using Avalonia.Media;

namespace MyTemplate.UI;

/// <summary>
///     Represents a log entry with optional color styling.
/// </summary>
public class LogEntry
{
    public string Text { get; set; } = string.Empty;
    public IBrush? Foreground { get; set; }
    public LogLevel Level { get; set; } = LogLevel.Default;
}

/// <summary>
///     Log level for styling.
/// </summary>
public enum LogLevel
{
    Default,
    Primary,
    Secondary,
    Success,
    Warning,
    Error,
    Info,
    Muted
}
