using System;
using System.IO;
using Avalonia;
using CommunityToolkit.Mvvm.Messaging;
using Jab;
using Serilog;
using MyTemplate.App.ViewModels;
using MyTemplate.UI;

namespace MyTemplate.App.Helpers;

[ServiceProvider]
[Singleton(typeof(MyTemplate.UI.DialogManager))]
[Singleton(typeof(MyTemplate.UI.ToastManager))]
[Singleton(typeof(MyTemplate.UI.ThemeWatcher), Factory = nameof(ThemeWatcherFactory))]
[Singleton<MyTemplate.UI.ThemeSettings>]
[Singleton<IMessenger, WeakReferenceMessenger>]
[Singleton(typeof(ILogger), Factory = nameof(LoggerFactory))]
[Singleton(typeof(PageManager), Factory = nameof(PageManagerFactory))]
[Transient<HomeViewModel>]
[Transient<MainWindowViewModel>]
public partial class ServiceProvider
{
    public ILogger LoggerFactory()
    {
        var currentFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "MyTemplate.UI\\logs");

        Directory.CreateDirectory(currentFolder); //ensure the directory exists

        var file = Path.Combine(currentFolder, "log.txt");

        var config = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(file, rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Logger = config; //set the global logger

        return config;
    }

    public ThemeWatcher ThemeWatcherFactory()
    {
        return new ThemeWatcher(Application.Current!);
    }

    public PageManager PageManagerFactory()
    {
        return new PageManager(this);
    }
}