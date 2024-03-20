using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace Persewaan.Controller
{
    class TransaksiController
    {
        bool hasil = false;
        private View.Transaksi vTrans;
        private View.Dashboard vDash;
        private Model.ModelTransaksi mTrans;
        private View.Nota vNota;

        public TransaksiController(View.Transaksi vTrans)
        {
            this.vTrans = vTrans;
            mTrans = new Model.ModelTransaksi();
        }

        public TransaksiController(View.Dashboard vDash)
        {
            this.vDash = vDash;
            mTrans = new Model.ModelTransaksi();
            showData();
        }

        public TransaksiController(View.Nota vNota)
        {
            this.vNota = vNota;
            mTrans = new Model.ModelTransaksi();
            showDataNota();
        }

        public void GenerateCode()
        {
            vTrans.txtidsewa.Text = mTrans.GenerateCode();
        }

        public bool InsertTransaksi()
        {
            try
            {
                mTrans.SetID_transaksi(vTrans.txtidsewa.Text);
                mTrans.SetNo_pol(vTrans.txtnomesin.Text);
                mTrans.SetTanggal_ambil(vTrans.dtpTanggalambil.SelectedDate.Value.ToString("yyyy-MM-dd"));
                mTrans.SetTanggal_pinjam(vTrans.dtpTanggalpinjam.SelectedDate.Value.ToString("yyyy-MM-dd"));
                mTrans.SetNIK(vTrans.txtnik.Text);
                hasil = mTrans.InsertTransaksi();
            }
            catch (Exception e)
            {
            }

            return hasil;
        }

        public bool DeleteTransaksi()
        {
            try
            {
                mTrans.SetID_transaksi(vTrans.txtidsewa.Text);
                hasil = mTrans.DeleteTransaksi();
            }
            catch (Exception e)
            {
            }

            return hasil;
        }

        public bool UpdateTransaksi()
        {
            try
            {
                mTrans.SetID_transaksi(vTrans.txtidsewa.Text);
                mTrans.SetNo_pol(vTrans.txtnomesin.Text);
                mTrans.SetTanggal_ambil(vTrans.dtpTanggalambil.SelectedDate.Value.ToString("yyyy-MM-dd"));
                mTrans.SetTanggal_pinjam(vTrans.dtpTanggalpinjam.SelectedDate.Value.ToString("yyyy-MM-dd"));
                mTrans.SetNIK(vTrans.txtnik.Text);
                hasil = mTrans.UpdateTransaksi();
            }
            catch (Exception e)
            {
            }

            return hasil;
        }

        public void TableTransaksi()
        {
            DataSet data = mTrans.TabelTransaksi();
            vTrans.DataGridTransaksi.ItemsSource = data.Tables[0].DefaultView;
        }

        public void showData()
        {
            DataSet ds = mTrans.SelectDataDashboard();
            mTrans.SetSearch(vDash.txtCari.Text);
            vDash.gridData.Children.Clear();


            foreach (DataTable table in ds.Tables)
            {
                int index = 0;
                MainWindow asd = new MainWindow();
                asd.GridBackground.Children.Clear();
                foreach (DataRow Row in table.Rows)
                {
                    string id_trans = Row["id_transaksi"].ToString();
                    string nama = Row["nama_customer"].ToString();
                    string jenis_kendaraan = Row["jenis_kendaraan"].ToString();
                    string merk = Row["merk_kendaraan"].ToString();
                    double total_harga = double.Parse(Row["harga_perhari"].ToString());

                    View.Coba menu = new View.Coba(id_trans,nama, jenis_kendaraan, merk, total_harga);

                    double posCol = index / 4;
                    int posRow = index % 4;

                    Grid.SetColumn(menu, (int)posCol);
                    Grid.SetRow(menu, posRow);

                    vDash.gridData.Children.Add(menu);

                    index++;
                    
                }
            }
            
        }

        public void showDataNota()
        {
            DataSet ds = mTrans.SelectDataNota();
            vNota.GridNota.Children.Clear();
            vNota.idt.Children.Clear();
            vNota.idto.Children.Clear();

            foreach (DataTable table in ds.Tables)
            {
                mTrans.SetID_transaksi(vNota.cari.Text);
                int index = 0;
                MainWindow asd = new MainWindow();
                asd.GridBackground.Children.Clear();
                foreach (DataRow Row in table.Rows)
                {
                    index.ToString();
                    string id_trans = Row["id_transaksi"].ToString();
                    string jk = Row["jenis_kendaraan"].ToString();
                    string tglpinjam = Row["tgl_ambil"].ToString();
                    string tglambil = Row["tgl_kembali"].ToString();
                    int hari = int.Parse(Row["Selisih"].ToString());
                    double harga = double.Parse(Row["harga_perhari"].ToString());
                    double total = double.Parse(Row["Total"].ToString());
                    View.NotaData menu = new View.NotaData(index+1, jk, tglpinjam, tglambil, hari, harga);
                    View.TransID menu1 = new View.TransID(id_trans);
                    View.HargaTotal menu2 = new View.HargaTotal(total);

                    int posRow = index;
                    int posRow1 = index;
                    int posRow2 = index;

                    Grid.SetRow(menu, posRow);
                    Grid.SetRow(menu1, posRow1);
                    Grid.SetRow(menu2, posRow2);

                    vNota.GridNota.Children.Add(menu);
                    vNota.idt.Children.Add(menu1);
                    vNota.idto.Children.Add(menu2);

                    index++;

                }
            }

        }
    }
}
