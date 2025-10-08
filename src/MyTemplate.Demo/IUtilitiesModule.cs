using Jab;
using MyTemplate.UI;

namespace MyTemplate.Demo;

[ServiceProviderModule]
[Singleton<DialogManager>]
[Singleton<ToastManager>]
[Singleton<ThemeWatcher>(Factory = nameof(CreateThemeWatcher))]
public interface IUtilitiesModule
{
    static ThemeWatcher CreateThemeWatcher() => new(Avalonia.Application.Current!);
}