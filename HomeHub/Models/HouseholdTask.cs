using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeHub.Models;

public partial class HouseholdTask : ObservableObject
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }

    [ObservableProperty]
    private bool _isDone;
}
