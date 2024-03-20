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
    /// Interaction logic for Kendaraan.xaml
    /// </summary>
    public partial class Kendaraan : UserControl
    {
        private Controller.KendaraanController cKendaraan;
        public Kendaraan()
        {
            InitializeComponent();
            cKendaraan = new Controller.KendaraanController(this);
            cKendaraan.TableKendaraan();
        }

        private void txtnopol_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void rdbmotor_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            cKendaraan.insertkendaraan();
            cKendaraan.TableKendaraan();
        }

        private void rdbmobil_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void merk_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void harga_perhari_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            cKendaraan.updatekendaraan();
            cKendaraan.TableKendaraan();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            cKendaraan.Deletekendaraan();
            cKendaraan.TableKendaraan();
        }
    }
}
