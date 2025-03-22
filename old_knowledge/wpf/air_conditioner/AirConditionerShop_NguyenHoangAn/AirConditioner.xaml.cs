using Repository.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AirConditionerShop_NguyenHoangAn {
    /// <summary>
    /// Interaction logic for AirConditioner.xaml
    /// </summary>
    public partial class AirConditioner : Window {
        private readonly StaffMember? staffMember;

        private readonly AirConditionerService? airConditionerService;
        public AirConditioner() {
            InitializeComponent();
        }

        public AirConditioner(StaffMember staffMember) {
            InitializeComponent();
            this.staffMember = staffMember;
            airConditionerService = new AirConditionerService();
            dataAir.ItemsSource = airConditionerService.getAll();
            if (!staffMember.FullName.Equals("Administrator")) {
                columnDelete.Visibility = Visibility.Collapsed;
            }
        }

        private void dataAir_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) {
            try {
                string featureFunction = txtFeatureFunction.Text;
                int quantity;
                bool isValid = int.TryParse(txtQuantity.Text, out quantity);

                dataAir.ItemsSource = airConditionerService.searchAir(featureFunction, quantity, isValid);

            } catch (Exception ex) {
                MessageBox.Show("Please input number integer!");
            }
        }

        private void btn_Delete(object sender, RoutedEventArgs e) {
            var btn = sender as Button;
            int airConditionerId;
            bool isValid = int.TryParse(btn.CommandParameter.ToString(), out airConditionerId);
            MessageBoxResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (isValid && result == MessageBoxResult.OK) {
                airConditionerService.deleteAirConditionder(airConditionerId);
            }

            dataAir.ItemsSource = airConditionerService.getAll();
        }
    }
}
