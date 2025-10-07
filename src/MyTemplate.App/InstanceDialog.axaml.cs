using Avalonia.Interactivity;

namespace MyTemplate.App;

public partial class InstanceDialog : Window
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