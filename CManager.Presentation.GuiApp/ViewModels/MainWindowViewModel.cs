namespace CManager.Presentation.GuiApp.ViewModels;

public class MainWindowViewModel
{
    public object CurrentViewModel { get; }

    public MainWindowViewModel() 
    {
        CurrentViewModel = new GetStartedViewModel(); 
    }
}
