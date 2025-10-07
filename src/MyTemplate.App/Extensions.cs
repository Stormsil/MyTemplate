using MyTemplate.Demo.ViewModels;
using MyTemplate.Demo.Views;

namespace MyTemplate.Demo;

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