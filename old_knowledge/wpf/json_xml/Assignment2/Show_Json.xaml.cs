using Microsoft.Win32;
using Model.Models;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Linq;

namespace Assignment2 {
    /// <summary>
    /// Interaction logic for Show_Json.xaml
    /// </summary>
    public partial class Show_Json : Window {
        private string? jsonFilePath;
        public Show_Json() {
            InitializeComponent();
        }
        private void GoBackHome(object sender, RoutedEventArgs e) {
            MainWindow mainWindow = new MainWindow();

            this.Close();

            mainWindow.Show();
        }

        private void Click_Choose_Path(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json";

            if (openFileDialog.ShowDialog() == true) {
                // Lấy đường dẫn đến file đã chọn và đặt vào TextBox
                jsonFilePath = openFileDialog.FileName;
                FileJson.Text = jsonFilePath;
            }
        }

        private void CreateJsonFile(object sender, RoutedEventArgs e) {
            Create_File_Json create = new Create_File_Json();

            create.ShowDialog();
        }

        private void txtXmlData_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void DeleteJsonFile(object sender, RoutedEventArgs e) {
            if (jsonFilePath == null) {
                MessageBox.Show("Vui lòng chọn file JSON để xóa.");
                return;
            }
            File.Delete(jsonFilePath);
            MessageBox.Show("Tệp JSON đã được xóa.");
            txtJsonData.Clear();
            dataGridJson.ItemsSource = null;
        }

        private void ReadJsonFile(object sender, RoutedEventArgs e) {
            try {

                string jsonData = File.ReadAllText(jsonFilePath);

                txtJsonData.Text = jsonData;

                deserialize(jsonData);

            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi đọc tệp JSON: " + ex.Message);
            }
        }

        private void deserialize(string jsonData) {

            if (jsonFilePath.EndsWith("orders.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<Order>>(jsonData);
            } else if (jsonFilePath.EndsWith("customers.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<Customer>>(jsonData);
            } else if (jsonFilePath.EndsWith("order_detail.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<OrderDetail>>(jsonData);
            } else if (jsonFilePath.EndsWith("products.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<Product>>(jsonData);
            } else if (jsonFilePath.EndsWith("user_have.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<UserHave>>(jsonData);
            } else if (jsonFilePath.EndsWith("user_want.json", StringComparison.OrdinalIgnoreCase)) {
                dataGridJson.ItemsSource = JsonSerializer.Deserialize<List<UserWant>>(jsonData);
            } else {
                Console.WriteLine("No matching case for the given JSON file.");
            }
        }
        private void SaveJsonData(object sender, RoutedEventArgs e) {
            try {
                string jsonContent = txtJsonData.Text;

                using (StreamWriter sw = new StreamWriter(jsonFilePath)) {
                    sw.Write(jsonContent);
                }

                deserialize(jsonContent);

                MessageBox.Show("Tệp JSON đã được lưu.");
            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi lưu tệp JSON: " + ex.Message);
            }
        }

        private void PathFileJson(object sender, TextChangedEventArgs e) {

        }

        private void txtJsonData_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}
