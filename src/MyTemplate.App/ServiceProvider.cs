using System;
using System.IO;
using Avalonia;
using CommunityToolkit.Mvvm.Messaging;
using Jab;
using Serilog;
using MyTemplate.App.ViewModels;
using MyTemplate.App.ViewModels.Examples.ComboBox;
using MyTemplate.App.ViewModels.Examples.DataTable;
using MyTemplate.App.ViewModels.Examples.Date;
using MyTemplate.App.ViewModels.Examples.Input;
using MyTemplate.App.ViewModels.Examples.ListBox;
using MyTemplate.App.ViewModels.Examples.Numeric;
using MyTemplate.App.ViewModels.Examples.Time;
using MyTemplate.App.ViewModels.Examples.Typography;
using MyTemplate.UI;

namespace MyTemplate.App;

[ServiceProvider]
[Singleton(typeof(MyTemplate.UI.DialogManager))]
[Singleton(typeof(MyTemplate.UI.ToastManager))]
[Singleton(typeof(MyTemplate.UI.ThemeWatcher), Factory = nameof(ThemeWatcherFactory))]
[Singleton<IMessenger, WeakReferenceMessenger>]
[Singleton(typeof(ILogger), Factory = nameof(LoggerFactory))]
[Singleton(typeof(PageManager), Factory = nameof(PageManagerFactory))]
[Transient<AboutViewModel>]
[Transient<AvatarViewModel>]
[Transient<BadgeViewModel>]
[Transient<ButtonViewModel>]
[Transient<CardViewModel>]
[Transient<DataTableViewModel>]
[Transient<BasicDataTableViewModel>]
[Transient<GroupedDataTableViewModel>]
[Transient<DateViewModel>]
[Transient<FormDateInputViewModel>]
[Transient<FormDatePickerViewModel>]
[Transient<CheckBoxViewModel>]
[Transient<ComboBoxViewModel>]
[Transient<FormComboBoxViewModel>]
[Transient<ColorViewModel>]
[Transient<DashboardViewModel>]
[Transient<DialogViewModel>]
[Transient<InputViewModel>]
[Transient<FormInputViewModel>]
[Transient<NumericViewModel>]
[Transient<FormNumericViewModel>]
[Transient<LoginViewModel>]
[Transient<MenuViewModel>]
[Transient<MiscellaneousViewModel>]
[Transient<ListBoxViewModel>]
[Transient<SidebarViewModel>]
[Transient<SliderViewModel>]
[Transient<SwitchViewModel>]
[Transient<TabControlViewModel>]
[Transient<TimeViewModel>]
[Transient<FormTimeInputViewModel>]
[Transient<FormTimePickerViewModel>]
[Transient<ThemeViewModel>]
[Transient<ToastViewModel>]
[Transient<ToggleViewModel>]
[Transient<ToolTipViewModel>]
[Transient<TypographyViewModel>]
[Transient<TextBlockViewModel>]
[Transient<SelectableTextBlockViewModel>]
[Transient<LabelViewModel>]
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