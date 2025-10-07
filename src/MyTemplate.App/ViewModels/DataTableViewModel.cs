using CommunityToolkit.Mvvm.Input;
using MyTemplate.App.ViewModels.Examples.DataTable;

namespace MyTemplate.App.ViewModels;

[Page("data-table")]
public sealed partial class DataTableViewModel(
    PageManager pageManager,
    BasicDataTableViewModel basic,
    GroupedDataTableViewModel grouped)
    : ViewModelBase, INavigable
{
    [RelayCommand]
    private void BackPage()
    {
        pageManager.Navigate<ComboBoxViewModel>();
    }

    [RelayCommand]
    private void NextPage()
    {
        pageManager.Navigate<DateViewModel>();
    }

    public BasicDataTableViewModel BasicDataTable { get; } = basic;
    public GroupedDataTableViewModel GroupedDataTable { get; } = grouped;
}