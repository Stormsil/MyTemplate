using MyTemplate.App.ViewModels;
using MyTemplate.App.Views;
using MyTemplate.UI;

namespace MyTemplate.App;

public static class Extensions
{
    public static ServiceProvider RegisterDialogs(this ServiceProvider service)
    {
        var dialogService = service.GetService<DialogManager>();
        dialogService.Register<LoginContent, LoginViewModel>();
        dialogService.Register<AboutContent, AboutViewModel>();

        return service;
    }
}