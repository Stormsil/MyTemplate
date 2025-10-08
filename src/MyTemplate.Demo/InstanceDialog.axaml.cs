using Avalonia.Controls;
using Avalonia.Interactivity;
using MyTemplate.UI;

namespace MyTemplate.Demo;

public partial class InstanceDialog : MyTemplate.UI.Window
{
    public InstanceDialog()
    {
        InitializeComponent();
    }

    private void OnClose(object sender, RoutedEventArgs e)
    {
        Close();
    }
}