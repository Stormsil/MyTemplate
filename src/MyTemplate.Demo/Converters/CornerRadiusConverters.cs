using Avalonia;
using Avalonia.Data.Converters;

namespace MyTemplate.Demo.Converters;

public static class CornerRadiusConverters
{
    public static readonly IValueConverter ToPixel =
        new FuncValueConverter<CornerRadius, string>(cr =>
            $"{cr.TopLeft} px");
}