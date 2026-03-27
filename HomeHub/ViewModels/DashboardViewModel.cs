using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeHub.Services;

namespace HomeHub.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    private readonly IMockDataService _mockDataService;

    [ObservableProperty]
    private int _totalPendingTasks;

    [ObservableProperty]
    private int _upcomingBills;

    [ObservableProperty]
    private int _shoppingItems;

    public DashboardViewModel(IMockDataService mockDataService)
    {
        _mockDataService = mockDataService;
        LoadDashboard();
    }

    [RelayCommand]
    private void LoadDashboard()
    {
        TotalPendingTasks = _mockDataService.GetTasks().Count(t => !t.IsDone);
        UpcomingBills     = _mockDataService.GetBills().Count(b => !b.IsPaid);
        ShoppingItems     = _mockDataService.GetShoppingItems().Count(s => !s.IsChecked);
    }
}
