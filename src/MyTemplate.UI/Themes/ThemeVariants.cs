using Avalonia.Styling;

// ReSharper disable once CheckNamespace
namespace MyTemplate.UI;

/// <summary>
///     Provides static theme variant definitions for custom themes.
/// </summary>
public static class ThemeVariants
{
    /// <summary>
    ///     Green light theme variant.
    /// </summary>
    public static readonly ThemeVariant GreenLight = new("GreenLight", ThemeVariant.Light);

    /// <summary>
    ///     Green dark theme variant.
    /// </summary>
    public static readonly ThemeVariant GreenDark = new("GreenDark", ThemeVariant.Dark);

    /// <summary>
    ///     Yellow light theme variant.
    /// </summary>
    public static readonly ThemeVariant YellowLight = new("YellowLight", ThemeVariant.Light);

    /// <summary>
    ///     Yellow dark theme variant.
    /// </summary>
    public static readonly ThemeVariant YellowDark = new("YellowDark", ThemeVariant.Dark);

    /// <summary>
    ///     Orange light theme variant.
    /// </summary>
    public static readonly ThemeVariant OrangeLight = new("OrangeLight", ThemeVariant.Light);

    /// <summary>
    ///     Orange dark theme variant.
    /// </summary>
    public static readonly ThemeVariant OrangeDark = new("OrangeDark", ThemeVariant.Dark);

    /// <summary>
    ///     Violet light theme variant.
    /// </summary>
    public static readonly ThemeVariant VioletLight = new("VioletLight", ThemeVariant.Light);

    /// <summary>
    ///     Violet dark theme variant.
    /// </summary>
    public static readonly ThemeVariant VioletDark = new("VioletDark", ThemeVariant.Dark);
}
