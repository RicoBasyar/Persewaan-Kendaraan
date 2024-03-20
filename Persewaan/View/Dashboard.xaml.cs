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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        private Controller.TransaksiController cTrans;
        public Dashboard()
        {
            InitializeComponent();
            cTrans = new Controller.TransaksiController(this);
            cTrans.showData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cTrans.showData();
        }
    }
}
