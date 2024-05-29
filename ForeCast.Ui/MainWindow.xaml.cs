using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForeCast.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void search_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
            }
        }

        private void search_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
            }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(search.Text))
            {
                searchholder.Visibility = Visibility.Visible;
                
            }
            else
            {
                searchholder.Visibility = Visibility.Collapsed;
                
            }
        }
    }
}