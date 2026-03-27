using HomeHub.ViewModels;

namespace HomeHub.Views;

public partial class ShoppingPage : ContentPage
{
    // Parameterless constructor used by Shell ContentTemplate — resolves ViewModel via DI
    public ShoppingPage() : this(
        IPlatformApplication.Current!.Services.GetRequiredService<ShoppingViewModel>()) { }

    public ShoppingPage(ShoppingViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
