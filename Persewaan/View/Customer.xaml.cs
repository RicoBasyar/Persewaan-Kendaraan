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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Persewaan.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : UserControl
    {
        private Controller.CustomerController cCustomer;
        public Customer()
        {
            cCustomer = new Controller.CustomerController(this);   
            InitializeComponent();
            cCustomer.TableCustomer();
        }

        private void btn_save_click(object sender, RoutedEventArgs e)
        {
            cCustomer.insertcustomer();
            cCustomer.TableCustomer();
        }

        private void NIKFocus(object sender, RoutedEventArgs e)
        {

        }

        private void NamaFocus(object sender, RoutedEventArgs e)
        {

        }

        private void no_telpFocus(object sender, RoutedEventArgs e)
        {

        }

        private void alamatFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            cCustomer.updatecustomer();
            cCustomer.TableCustomer();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            cCustomer.deletecustomer();
            cCustomer.TableCustomer();
        }

    }
}
