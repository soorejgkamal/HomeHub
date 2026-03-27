using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeHub.Models;
using HomeHub.Services;
using System.Collections.ObjectModel;

namespace HomeHub.ViewModels;

public partial class BillsViewModel : ObservableObject
{
    private readonly IMockDataService _mockDataService;

    [ObservableProperty]
    private ObservableCollection<Bill> _bills = new();

    public BillsViewModel(IMockDataService mockDataService)
    {
        _mockDataService = mockDataService;
        LoadBills();
    }

    [RelayCommand]
    private void LoadBills()
    {
        Bills = new ObservableCollection<Bill>(_mockDataService.GetBills());
    }

    [RelayCommand]
    private void TogglePaid(Bill bill)
    {
        bill.IsPaid = !bill.IsPaid;
    }
}
