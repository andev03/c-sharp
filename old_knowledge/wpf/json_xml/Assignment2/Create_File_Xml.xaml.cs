using Exchange.Business;
using Model.Models;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;
    
namespace Assignment2 {
    /// <summary>
    /// Interaction logic for Create_File_Xml.xaml
    /// </summary>
    public partial class Create_File_Xml : Window {

        private string? selectedPath;

        private string? selectedItem;
        public Create_File_Xml() {
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

        private void Click_To_Create(object sender, RoutedEventArgs e) {
            if (selectedPath == null) {
                System.Windows.MessageBox.Show("Vui lòng chọn đường dẫn!");
                return;
            }
            switch(selectedItem) {
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
                List<Customer> result = (List<Customer>) getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

                string xmlFilePath = Path.Combine(selectedPath, "customers.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void orderCreate() {
            var business = new OrderBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<Order> result = (List<Order>)getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));

                string xmlFilePath = Path.Combine(selectedPath, "orders.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void orderDetailCreate() {
            var business = new OrderDetailBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<OrderDetail> result = (List<OrderDetail>)getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<OrderDetail>));

                string xmlFilePath = Path.Combine(selectedPath, "orders_detail.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void productCreate() {
            var business = new ProductsBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<Product> result = (List<Product>)getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

                string xmlFilePath = Path.Combine(selectedPath, "products.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void userHaveCreate() {
            var business = new UserHaveBusiness();

            var getAll = await business.GetAll();

            if (getAll != null) {
                List<UserHave> result = (List<UserHave>)getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<UserHave>));

                string xmlFilePath = Path.Combine(selectedPath, "user_have.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private async void userWantCreate() {
            var business = new UserWantBusiness();

            var getAll = await business.GetAll();
            if (getAll != null) {
                List<UserWant> result = (List<UserWant>)getAll.Data;

                XmlSerializer serializer = new XmlSerializer(typeof(List<UserWant>));

                string xmlFilePath = Path.Combine(selectedPath, "user_want.xml");

                xmlSerialization(result, serializer, xmlFilePath);
            } else {
                System.Windows.MessageBox.Show($"Không thể truy xuất dữ liệu: {getAll.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void xmlSerialization<T>(
            List<T> result,
            XmlSerializer serializer,
            string xmlFilePath
            ) {

            try {
                using (var writer = new StreamWriter(xmlFilePath)) {
                    serializer.Serialize(writer, result);
                }
                System.Windows.MessageBox.Show("Tuần tự hóa thành XML thành công.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception ex) {
                System.Windows.MessageBox.Show($"Lỗi trong quá trình tuần tự hóa: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }
        private void Object_Want_Create_Xml(object sender, SelectionChangedEventArgs e) {

            selectedItem = Object_Selected.SelectedItem as string;

        }

        private void Path_To_Create_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
