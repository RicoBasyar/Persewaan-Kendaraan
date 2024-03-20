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

namespace Persewaan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridDrag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizedWindow_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
            
        }
     

        private void Pilihan(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuPilih.SelectedIndex;
         

            switch (index)

            {

                case 0:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new View.Dashboard());
                    break;
                case 1:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new View.Customer());
                    break;
                case 2:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new View.Kendaraan());
                    break;
                case 3:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new View.Transaksi());           
                    break;
                case 4:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    GridBackground.Children.Add(new View.Nota());
                    break;
                case 5:
                    awal.Children.Clear();
                    GridBackground.Children.Clear();
                    this.Close();
                    View.Login asd = new View.Login();
                    asd.Show();
                    break;
                default:
                    break;
            }
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Gerakgerak(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
