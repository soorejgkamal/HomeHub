using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeHub.Models;
using HomeHub.Services;
using System.Collections.ObjectModel;

namespace HomeHub.ViewModels;

public partial class TasksViewModel : ObservableObject
{
    private readonly IMockDataService _mockDataService;

    [ObservableProperty]
    private ObservableCollection<HouseholdTask> _tasks = new();

    public TasksViewModel(IMockDataService mockDataService)
    {
        _mockDataService = mockDataService;
        LoadTasks();
    }

    [RelayCommand]
    private void LoadTasks()
    {
        Tasks = new ObservableCollection<HouseholdTask>(_mockDataService.GetTasks());
    }

    [RelayCommand]
    private void ToggleTask(HouseholdTask task)
    {
        task.IsDone = !task.IsDone;
    }
}
