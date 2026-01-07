using CManager.Presentation.GuiApp.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace CManager.Presentation.GuiApp.Views
{
    /// <summary>
    /// Interaction logic for GetStartedView.xaml
    /// </summary>
    public partial class GetStartedView : UserControl
    {
        public GetStartedView()
        {
            InitializeComponent();
        }
    

        private void GetStarted_Click(object sender, RoutedEventArgs e) 
        {
            if (System.Windows.Application.Current.MainWindow?.DataContext is MainWindowViewModel mainWindowViewModel) 
            {
                mainWindowViewModel.ShowCreateCustomer();
            }
        }
    }
}
