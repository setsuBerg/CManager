using CManager.Presentation.GuiApp.ViewModels;
using System.Windows;
using System.Windows.Controls;


namespace CManager.Presentation.GuiApp.Views
{
    /// <summary>
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public CreateCustomerView()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Application.Current.MainWindow?.DataContext is MainWindowViewModel mainViewModel) 
            {
                mainViewModel.ShowGetStarted();
            }
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var firstName = FirstNameInput.Text;
            ResultTextMessage.Text = $"Customer \"{firstName}\" created!";
        }
    }
}
