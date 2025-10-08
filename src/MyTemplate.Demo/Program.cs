using System;
using Avalonia;
using Serilog;

namespace MyTemplate.Demo;

internal sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before DemoMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaDemo()
                .StartWithClassicDesktopLifetime(args);
        }
        catch (Exception e)
        {
            var serviceProvider = new ServiceProvider();

            var logger = serviceProvider.GetService<ILogger>();
            logger.Fatal(e, "An unhandled exception occurred during bootstrapping the application.");
        }
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaDemo()
    {
        return AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
    }
}