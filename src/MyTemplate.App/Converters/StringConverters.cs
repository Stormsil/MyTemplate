using Avalonia.Controls;
using Avalonia.Data.Converters;

namespace MyTemplate.App.Converters;

public static class StringConverters
{
    public static readonly IValueConverter ToSelectionMode =
        new FuncValueConverter<string, SelectionMode>(mode => mode switch
        {
            "Single" => SelectionMode.Single,
            "Multiple" => SelectionMode.Multiple,
            "Toggle" => SelectionMode.Toggle,
            "Always Selected" => SelectionMode.AlwaysSelected,
            _ => SelectionMode.Single
        });
}