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
    /// Interaction logic for Transaksi.xaml
    /// </summary>
    public partial class Transaksi : UserControl
    {
        private Controller.TransaksiController cTrans;
        public Transaksi()
        {
            InitializeComponent();
            cTrans = new Controller.TransaksiController(this);
            cTrans.TableTransaksi();
            cTrans.GenerateCode();
        }

        private void btn_save_click(object sender, RoutedEventArgs e)
        {
            cTrans.InsertTransaksi();
            cTrans.TableTransaksi();
            cTrans.GenerateCode();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            cTrans.UpdateTransaksi();
            cTrans.TableTransaksi();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            cTrans.DeleteTransaksi();
            cTrans.TableTransaksi();
        }


        private void txtnopol_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
