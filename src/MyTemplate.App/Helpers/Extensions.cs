using MyTemplate.UI;

namespace MyTemplate.App.Helpers;

public static class Extensions
{
    public static ServiceProvider RegisterDialogs(this ServiceProvider service)
    {
        // Register your custom dialogs here
        // Example: dialogService.Register<YourDialogContent, YourDialogViewModel>();

        return service;
    }
}