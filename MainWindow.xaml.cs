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

namespace WPF_MessageBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFire_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Couldn't load the archive.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);

            MessageBoxResult result = MessageBox.Show("Want to continue?", "Are you sure?", 
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else tbInfo.Text = "Disagreed";
        }
    }
}