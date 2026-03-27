using HomeHub.ViewModels;

namespace HomeHub.Views;

public partial class TasksPage : ContentPage
{
    // Parameterless constructor used by Shell ContentTemplate — resolves ViewModel via DI
    public TasksPage() : this(
        IPlatformApplication.Current!.Services.GetRequiredService<TasksViewModel>()) { }

    public TasksPage(TasksViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
