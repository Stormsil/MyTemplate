using System;
using System.IO;

// ReSharper disable once CheckNamespace
namespace MyTemplate.UI;

/// <summary>
///     Manages theme settings persistence.
/// </summary>
public class ThemeSettings
{
    private static readonly string SettingsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "MyTemplate",
        "theme-settings.txt"
    );

    /// <summary>
    ///     Saves the theme mode to disk.
    /// </summary>
    /// <param name="mode">The theme mode to save.</param>
    public void SaveTheme(ThemeMode mode)
    {
        try
        {
            var directory = Path.GetDirectoryName(SettingsPath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(SettingsPath, mode.ToString());
        }
        catch
        {
            // Ignore errors when saving settings
        }
    }

    /// <summary>
    ///     Loads the theme mode from disk.
    /// </summary>
    /// <returns>The saved theme mode, or System if not found.</returns>
    public ThemeMode LoadTheme()
    {
        try
        {
            if (!File.Exists(SettingsPath))
            {
                return ThemeMode.System;
            }

            var themeText = File.ReadAllText(SettingsPath).Trim();

            if (Enum.TryParse<ThemeMode>(themeText, out var mode))
            {
                return mode;
            }
        }
        catch
        {
            // Ignore errors when loading settings
        }

        return ThemeMode.System;
    }
}
