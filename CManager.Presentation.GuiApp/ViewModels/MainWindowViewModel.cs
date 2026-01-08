using CommunityToolkit.Mvvm.ComponentModel;

namespace CManager.Presentation.GuiApp.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{

    private ObservableObject? _currentViewModel;

    public ObservableObject CurrentViewModel 
    {
        get => _currentViewModel!; 
        set => SetProperty(ref _currentViewModel, value); 
    }

    public MainWindowViewModel()
    {
        CurrentViewModel = new GetStartedViewModel(); 
    }

    public void ShowCreateCustomer()
    {
        CurrentViewModel = new CreateCustomerViewModel();
    }
    public void ShowGetStarted()
    {
        CurrentViewModel = new GetStartedViewModel();
    }
}
