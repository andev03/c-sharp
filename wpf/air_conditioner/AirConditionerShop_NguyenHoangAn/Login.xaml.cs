using Repository.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window {
        private readonly StaffMemberService staffMemberService;

        public static StaffMember account;
        public Login() {
            InitializeComponent();
            staffMemberService = new StaffMemberService();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            account = staffMemberService.login(email, password);
            if (account != null) {
                if (account.FullName.Equals("Administrator") || account.FullName.Equals("Staff")) {
                    AirConditioner airConditioner = new AirConditioner(account);
                    airConditioner.Show();
                    this.Close();
                }
            } else {
                MessageBox.Show("You have no permission to access this function!");
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
