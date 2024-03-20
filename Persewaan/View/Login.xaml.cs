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

namespace Persewaan.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private Controller.AdminController cAdmin;
        public Login()
        {
            cAdmin = new Controller.AdminController(this);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(cAdmin.LoginAdmin() == true)
            {
                MainWindow home = new MainWindow();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Gagal");
                txtNama.Text = "";
                pwdbox.Password = "";
            }
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
