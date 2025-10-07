using Jab;

namespace MyTemplate.Demo;

[ServiceProviderModule]
[Singleton<DialogManager>]
[Singleton<ToastManager>]
public interface IUtilitiesModule
{
}