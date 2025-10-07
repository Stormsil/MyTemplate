using Jab;

namespace MyTemplate.App;

[ServiceProviderModule]
[Singleton<DialogManager>]
[Singleton<ToastManager>]
public interface IUtilitiesModule
{
}