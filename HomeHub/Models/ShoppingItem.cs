using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeHub.Models;

public partial class ShoppingItem : ObservableObject
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }

    [ObservableProperty]
    private bool _isChecked;
}
