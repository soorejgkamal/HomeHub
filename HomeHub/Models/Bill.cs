using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeHub.Models;

public partial class Bill : ObservableObject
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }

    [ObservableProperty]
    private bool _isPaid;
}
