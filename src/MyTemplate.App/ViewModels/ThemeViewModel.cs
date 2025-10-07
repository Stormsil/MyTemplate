using CommunityToolkit.Mvvm.Input;

namespace MyTemplate.Demo.ViewModels;

[Page("theme")]
public sealed partial class ThemeViewModel(PageManager pageManager) : ViewModelBase, INavigable
{
    [RelayCommand]
    private void BackPage()
    {
        pageManager.Navigate<DashboardViewModel>();
    }

    [RelayCommand]
    private void NextPage()
    {
        pageManager.Navigate<TypographyViewModel>();
    }
}