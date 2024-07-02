using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Assignment2 {
    /// <summary>
    /// Interaction logic for Show_Xml.xaml
    /// </summary>
    public partial class Show_Xml : Window {

        private string? xmlFilePath;

        public Show_Xml() {
            InitializeComponent();
        }

        private void GoBackHome(object sender, RoutedEventArgs e) {
            MainWindow mainWindow = new MainWindow();

            this.Close();

            mainWindow.Show();
        }

        private void Click_Choose_Path(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xml files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == true) {
                // Lấy đường dẫn đến file đã chọn và đặt vào TextBox
                xmlFilePath = openFileDialog.FileName;
                FileXml.Text = xmlFilePath;
            }
        }

        private void PathFileXml(object sender, TextChangedEventArgs e) {

        }


        private void CreateXmlFile(object sender, RoutedEventArgs e) {
            Create_File_Xml create = new Create_File_Xml();
            
            create.ShowDialog();
        }

        private void txtXmlData_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void DeleteXmlFile(object sender, RoutedEventArgs e) {
            if (xmlFilePath == null) {
                MessageBox.Show("Vui lòng chọn file XML để xóa.");
                return;
            }
            File.Delete(xmlFilePath);
            MessageBox.Show("Tệp XML đã được xóa.");
            txtXmlData.Clear();
        }

        private void ReadXmlFile(object sender, RoutedEventArgs e) {
            try {

                XDocument xdoc = XDocument.Load(xmlFilePath);

                txtXmlData.Text = xdoc.ToString();

            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi đọc tệp XML: " + ex.Message);
            }
        }

        private void SaveXmlData(object sender, RoutedEventArgs e) {
            try {
                string xmlContent = txtXmlData.Text;

                XDocument xdoc = XDocument.Parse(xmlContent);

                xdoc.Save(xmlFilePath);

                MessageBox.Show("Tệp XML đã được lưu.");

            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi lưu tệp XML: " + ex.Message);
            }
        }

    }
}
