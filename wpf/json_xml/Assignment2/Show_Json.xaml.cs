using Microsoft.Win32;
using System.IO;
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
        }

        private void ReadJsonFile(object sender, RoutedEventArgs e) {
            try {

                string jsonData = File.ReadAllText(jsonFilePath);

                txtJsonData.Text = jsonData;

            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi đọc tệp JSON: " + ex.Message);
            }
        }

        private void SaveJsonData(object sender, RoutedEventArgs e) {
            try {
                string jsonContent = txtJsonData.Text; 

                using (StreamWriter sw = new StreamWriter(jsonFilePath))
                {
                    sw.Write(jsonContent);
                }

                MessageBox.Show("Tệp JSON đã được lưu.");
            } catch (Exception ex) {
                MessageBox.Show("Lỗi khi lưu tệp JSON: " + ex.Message);
            }
        }

        private void PathFileJson(object sender, TextChangedEventArgs e) {

        }

        private void txtJsonData_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
