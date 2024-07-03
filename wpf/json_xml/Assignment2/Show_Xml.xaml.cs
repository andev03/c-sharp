using Microsoft.Win32;
using Model.Models;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Xml.Serialization;

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
            dataGridXml.ItemsSource = null;
        }

        private void ReadXmlFile(object sender, RoutedEventArgs e) {
            try {

                string xmlData = File.ReadAllText(xmlFilePath);

                txtXmlData.Text = xmlData;

                deserialize(xmlData);
            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi đọc tệp XML: " + ex.Message);
            }
        }

        private void deserialize(string xmlData) {

            using FileStream xmlLoad = File.Open(xmlFilePath, FileMode.Open);

            if (xmlFilePath.EndsWith("orders.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<Order>));
                dataGridXml.ItemsSource = (List<Order>)xs.Deserialize(xmlLoad);
            } else if (xmlFilePath.EndsWith("customers.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<Customer>));
                dataGridXml.ItemsSource = (List<Customer>)xs.Deserialize(xmlLoad);
            } else if (xmlFilePath.EndsWith("order_detail.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<OrderDetail>));
                dataGridXml.ItemsSource = (List<OrderDetail>)xs.Deserialize(xmlLoad);
            } else if (xmlFilePath.EndsWith("products.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<Product>));
                dataGridXml.ItemsSource = (List<Product>)xs.Deserialize(xmlLoad);
            } else if (xmlFilePath.EndsWith("user_have.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<UserHave>));
                dataGridXml.ItemsSource = (List<UserHave>)xs.Deserialize(xmlLoad);
            } else if (xmlFilePath.EndsWith("user_want.xml", StringComparison.OrdinalIgnoreCase)) {
                var xs = new XmlSerializer(typeof(List<UserWant>));
                dataGridXml.ItemsSource = (List<UserWant>)xs.Deserialize(xmlLoad);
            } else {
                Console.WriteLine("No matching case for the given JSON file.");
            }
            xmlLoad.Close();
        }
        private void SaveXmlData(object sender, RoutedEventArgs e) {
            try {
                string xmlContent = txtXmlData.Text;

                XDocument xdoc = XDocument.Parse(xmlContent);

                xdoc.Save(xmlFilePath);

                deserialize(xmlContent);
                MessageBox.Show("Tệp XML đã được lưu.");

            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi lưu tệp XML: " + ex.Message);
            }
        }

        private void dataGridXml_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}
