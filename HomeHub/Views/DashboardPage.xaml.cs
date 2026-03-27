using HomeHub.ViewModels;

namespace HomeHub.Views;

public partial class DashboardPage : ContentPage
{
    // Parameterless constructor used by Shell ContentTemplate — resolves ViewModel via DI
    public DashboardPage() : this(
        IPlatformApplication.Current!.Services.GetRequiredService<DashboardViewModel>()) { }

    public DashboardPage(DashboardViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
