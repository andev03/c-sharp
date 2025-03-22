using Exchange.Business;
using Model.Models;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Assignment2 {
    /// <summary>
    /// Interaction logic for Create_File_Json.xaml
    /// </summary>
    public partial class Create_File_Json : Window {

        private string? selectedPath;

        private string? selectedItem;
        public Create_File_Json() {
            InitializeComponent();

            string[] listObjectComboBox = {
                "Customer", "Order", "OrderDetail", "Product", "UserHave", "UserWant"
            };

            Object_Selected.ItemsSource = listObjectComboBox;
        }

        private void Click_Choose_Path(object sender, RoutedEventArgs e) {
            using var dialog = new FolderBrowserDialog();

            DialogResult result = dialog.ShowDialog();

            if (!string.IsNullOrWhiteSpace(dialog.SelectedPath)) {
                // Lấy đường dẫn đến file đã chọn và đặt vào TextBox
                selectedPath = dialog.SelectedPath;

                Path_To_Create.Text = dialog.SelectedPath;
            }
        }

        private void Path_To_Create_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void Object_Want_Create_Json(object sender, SelectionChangedEventArgs e) {

            selectedItem = Object_Selected.SelectedItem as string;

        }

        private void Click_To_Create(object sender, RoutedEventArgs e) {
            if (selectedPath == null) {
                System.Windows.MessageBox.Show("Vui lòng chọn đường dẫn!");
                return;
            }
            switch (selectedItem) {
                case "Customer":
                    customerCreate();
                    break;
                case "Order":
                    orderCreate();
                    break;
                case "OrderDetail":
                    orderDetailCreate();
                    break;
                case "Product":
                    productCreate();
                    break;
                case "UserHave":
                    userHaveCreate();
                    break;
                case "UserWant":
                    userWantCreate();
                    break;
                default:
                    System.Windows.MessageBox.Show("Vui lòng chọn object!");
                    break;
            }
        }

        private async void customerCreate() {
            var business = new CustomerBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<Customer> result = (List<Customer>)getAll.Data;
                
                string jsonFilePath = Path.Combine(selectedPath, "customers.json");

                jsonSerialization(result, jsonFilePath);

            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void orderCreate() {
            var business = new OrderBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<Order> result = (List<Order>)getAll.Data;

                string jsonFilePath = Path.Combine(selectedPath, "orders.json");

                jsonSerialization(result, jsonFilePath);

            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void orderDetailCreate() {
            var business = new OrderDetailBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<OrderDetail> result = (List<OrderDetail>)getAll.Data;

                string jsonFilePath = Path.Combine(selectedPath, "orders_detail.json");

                jsonSerialization(result, jsonFilePath);

            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void productCreate() {
            var business = new ProductsBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<Product> result = (List<Product>)getAll.Data;

                string jsonFilePath = Path.Combine(selectedPath, "products.json");

                jsonSerialization(result, jsonFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void userHaveCreate() {
            var business = new UserHaveBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<UserHave> result = (List<UserHave>)getAll.Data;

                string jsonFilePath = Path.Combine(selectedPath, "user_have.json");
                
                jsonSerialization(result, jsonFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void userWantCreate() {
            var business = new UserWantBusiness();

            var getAll = await business.GetAll();
            if (getAll != null) {
                List<UserWant> result = (List<UserWant>)getAll.Data;

                string jsonFilePath = Path.Combine(selectedPath, "user_want.json");

                jsonSerialization(result, jsonFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void jsonSerialization<T>(
            List<T> result,
            string jsonFilePath
            ) {
            try {
                string jsonData = JsonSerializer.Serialize(result, new JsonSerializerOptions {
                    WriteIndented = true // Để format JSON có thụt lề
                });

                File.WriteAllText(jsonFilePath, jsonData);
                System.Windows.MessageBox.Show("Tuần tự hóa thành JSON thành công.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            } catch (Exception ex) {
                System.Windows.MessageBox.Show($"Lỗi trong quá trình tuần tự hóa: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}