using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace Persewaan.Controller
{
    class CustomerController
    {
        private View.Customer vCustomer;//manggil view yang mau dihubungin
        private Model.CustomerModel mCustomer;//manggil model yang mau dihubungin

        
        public CustomerController(View.Customer vCustomer) //constructor membaca view dan model customer yang akan dilempar ke view customer
        {
            this.vCustomer = vCustomer;
            mCustomer = new Model.CustomerModel();
        }

        public bool insertcustomer()
        {
            mCustomer.SetNIK(vCustomer.txtNIK.Text);
            mCustomer.SetNamaCus(vCustomer.txtNamaCus.Text);
            mCustomer.SetNoTelp(vCustomer.txtno_telp.Text);
            mCustomer.SetAlamat(vCustomer.txtAlamat.Text);
            bool hasil = mCustomer.InsertCustomer();//manggil fungsi insertcustomer ynag ada di model customer
            return hasil;
        }

        public bool updatecustomer()
        {
            mCustomer.SetNIK(vCustomer.txtNIK.Text);
            mCustomer.SetNamaCus(vCustomer.txtNamaCus.Text);
            mCustomer.SetNoTelp(vCustomer.txtno_telp.Text);
            mCustomer.SetAlamat(vCustomer.txtAlamat.Text);
            bool hasil = mCustomer.UpdateCustomer();
            return hasil;
        }

        public bool deletecustomer()
        {
            mCustomer.SetNIK(vCustomer.txtNIK.Text);
            bool hasil = mCustomer.DeleteCustomer();
            return hasil;
        }

        public void TableCustomer()//masukin data ke tabel yang namanya datagridcustomer di viewcustomer xaml
        {
            DataSet data = mCustomer.TabelCustomer();
            vCustomer.DataGridCustomer.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
