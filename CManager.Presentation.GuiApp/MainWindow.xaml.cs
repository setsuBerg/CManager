using System.Text;
using System.Windows;
using System.Windows.Input;
using CManager.Presentation.GuiApp.ViewModels;

namespace CManager.Presentation.GuiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // måste finnas
            DataContext = new MainWindowViewModel();

        }

        private void TopBar_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) 
            {
                DragMove();
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}