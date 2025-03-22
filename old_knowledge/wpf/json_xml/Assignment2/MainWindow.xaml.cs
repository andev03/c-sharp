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

namespace Assignment2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Navigation_Xml(object sender, RoutedEventArgs e) {
            Show_Xml newShowXml = new Show_Xml();

            this.Close();

            newShowXml.ShowDialog();
        }

        private void Navigation_Json(object sender, RoutedEventArgs e) {
            Show_Json newShowJson = new Show_Json();

            this.Close();

            newShowJson.ShowDialog();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }


    }
}