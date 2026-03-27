using HomeHub.ViewModels;

namespace HomeHub.Views;

public partial class BillsPage : ContentPage
{
    // Parameterless constructor used by Shell ContentTemplate — resolves ViewModel via DI
    public BillsPage() : this(
        IPlatformApplication.Current!.Services.GetRequiredService<BillsViewModel>()) { }

    public BillsPage(BillsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
