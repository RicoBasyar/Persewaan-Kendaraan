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
    /// Interaction logic for Coba.xaml
    /// </summary>
    public partial class Coba : UserControl
    {
        public Coba(string id_transaksi, string nama, string jenis_kendaraan, string merk, double total_harga)
        {
            InitializeComponent();

            idt.Content = id_transaksi;
            NamaCustomer.Content = "Nama \t\t: " + nama;
            JenisKendaraan.Content = "Jenis Kendaraan \t: " + jenis_kendaraan;
            MerkKendaraan.Content = "Merk \t\t: " + merk;
            Totalharga.Content = "Rp. "+ total_harga;

        }
    }
}
