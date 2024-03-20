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
    /// Interaction logic for NotaData.xaml
    /// </summary>
    public partial class NotaData : UserControl
    {
        public NotaData(int notr, string jk, string tglpinjam, string tglambil, int hari, double harga)
        {
            InitializeComponent();
            noTra.Content = notr;
            jenisKendaraan.Content = jk;
            tpinjam.Content = tglpinjam;
            tambil.Content = tglambil;
            jhari.Content = hari;
            jHarga.Content = harga;
            
        }
    }
}
