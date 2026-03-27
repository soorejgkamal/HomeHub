using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeHub.Models;
using HomeHub.Services;
using System.Collections.ObjectModel;

namespace HomeHub.ViewModels;

public partial class ShoppingViewModel : ObservableObject
{
    private readonly IMockDataService _mockDataService;

    [ObservableProperty]
    private ObservableCollection<ShoppingItem> _shoppingItems = new();

    public ShoppingViewModel(IMockDataService mockDataService)
    {
        _mockDataService = mockDataService;
        LoadShoppingItems();
    }

    [RelayCommand]
    private void LoadShoppingItems()
    {
        ShoppingItems = new ObservableCollection<ShoppingItem>(_mockDataService.GetShoppingItems());
    }

    [RelayCommand]
    private void ToggleItem(ShoppingItem item)
    {
        item.IsChecked = !item.IsChecked;
    }
}
