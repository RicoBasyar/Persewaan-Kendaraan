using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Persewaan.Controller
{
    class KendaraanController
    {
        private View.Kendaraan vKendaraan;
        Model.ModelKendaraan mKendaraan;

        public KendaraanController(View.Kendaraan vKendaraan)
        {
            this.vKendaraan = vKendaraan;
            mKendaraan = new Model.ModelKendaraan();
        }

        public bool insertkendaraan()
        {
            mKendaraan.SetNo_mesin(Int32.Parse(vKendaraan.txtnomesin.Text));
            mKendaraan.Setno_rangka(vKendaraan.txtnorangka.Text);
            mKendaraan.SetNo_Pol(vKendaraan.txtnopol.Text);
            if(vKendaraan.rdbmobil.IsChecked == true)
            {
                mKendaraan.Setjenis_kendaraan("Mobil");
            }
            else if(vKendaraan.rdbmotor.IsChecked == true)
            {
                mKendaraan.Setjenis_kendaraan("Motor");
            }
            mKendaraan.Setmerk_kendaraan(vKendaraan.merk.Text);
            mKendaraan.SetHarga_perhari(double.Parse(vKendaraan.harga_perhari.Text));
            bool hasil = mKendaraan.InsertKendaraan();
            return hasil;
        }

        public bool Deletekendaraan()
        {
            mKendaraan.SetNo_mesin(Int32.Parse(vKendaraan.txtnomesin.Text));
            bool hasil = mKendaraan.DeleteKendaraan();
            return hasil;
        }

        public bool updatekendaraan()
        {
            mKendaraan.SetNo_mesin(Int32.Parse(vKendaraan.txtnomesin.Text));
            mKendaraan.Setno_rangka(vKendaraan.txtnorangka.Text);
            mKendaraan.SetNo_Pol(vKendaraan.txtnopol.Text);
            if (vKendaraan.rdbmobil.IsChecked == true)
            {
                mKendaraan.Setjenis_kendaraan("Mobil");
            }
            else if (vKendaraan.rdbmotor.IsChecked == true)
            {
                mKendaraan.Setjenis_kendaraan("Motor");
            }
            mKendaraan.Setmerk_kendaraan(vKendaraan.merk.Text);
            mKendaraan.SetHarga_perhari(double.Parse(vKendaraan.harga_perhari.Text));
            bool hasil = mKendaraan.UpdateKendaraan();
            return hasil;
        }

        public void TableKendaraan()
        {
            DataSet data = mKendaraan.TabelKendaraan();
            vKendaraan.DataGridKendaraan.ItemsSource = data.Tables[0].DefaultView;
        }

    }
}
