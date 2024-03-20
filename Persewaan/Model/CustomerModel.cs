using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Persewaan.Model
{
    class CustomerModel
    {
        private SqlConnection koneksi;
        private SqlCommand command;
        private string query;
        private bool hasil;

        public CustomerModel()
        {
            koneksi = Model.KoneksiDB.GetConnection();
        }

        private string nik, namacus, no_telp, alamat;

        //FUNGSI SETNYA u/ mengambil data dari user yang barusan diketik
        public void SetNIK(String nik)
        {
            this.nik = nik;
        }

        public void SetNamaCus(String namacus)
        {
            this.namacus = namacus;
        }

        public void SetNoTelp(String no_telp)
        {
            this.no_telp = no_telp;
        }

        public void SetAlamat(String alamat)
        {
            this.alamat = alamat;
        }

        //FUNGSI GETNYA menampilkan,kebalikan set
        public string GetNIK()
        {
            return nik;
        }
        public string GetNamaCus()
        {
            return namacus;
        }
        public string GetNoTelp()
        {
            return no_telp;
        }
        public string GetAlamat()
        {
            return alamat;
        }
        
        //FUNGSI Proses
         public Boolean InsertCustomer()
        {
            hasil = false;
            AdminModel admin = new AdminModel();
            try
            {
                query = "insert into customer values ('" + nik + "'," +
                                                    " '" + namacus + "'," +
                                                    " '" + no_telp + "'," +
                                                    " '" + alamat + "'," +
                                                    " '" +Controller.AdminController.id.ToString()+"')";

                koneksi.Open(); //buka koneksi database
                command = new SqlCommand(); //deklaris command
                command.Connection = koneksi; //manggil koneksi
                command.CommandText = query; //manggil query yang ada didalam try
                command.ExecuteNonQuery(); //eksekusi query yang didalam try
                hasil = true; 
                koneksi.Close();
            }catch(SqlException e) //menampilkan kalo query try error dengan cara menggunakan show message box dialog atau console write
            {
                hasil = false;
                koneksi.Close();
            }
            return hasil;
        }

        public Boolean UpdateCustomer()
        {
            hasil = false;
            try
            {
                query = "update customer set nama_customer = '"+namacus+"'," +
                                            "no_telp='"+no_telp+"', " +
                                            "alamat='"+alamat+"' " +
                                            "where nik = '"+nik+"'";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                koneksi.Close();
            }catch(SqlException e)
            {
                hasil = false;
                koneksi.Close();
            }
            return hasil;
        }

        public Boolean DeleteCustomer()
        {
            hasil = false;
            try
            {
                query = "delete from customer where nik = '"+nik+"'";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                koneksi.Close();
            }catch(SqlException e)
            {
                hasil = false;
                koneksi.Close();
            }
            return false;
        }

        public DataSet TabelCustomer() //menampilkan data yang ada di tabel tapi ga ada bentuknya di visualnya
        {
            DataSet ds = new DataSet(); 
            try
            {
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandType = CommandType.Text; //convert tabel jadi text
                command.CommandText = "SELECT * FROM customer"; //query yang diconvert
                SqlDataAdapter sda = new SqlDataAdapter(command); //baca dan eksekusi perintah select
                sda.Fill(ds, "customer");//nama tabel customer
                koneksi.Close();
            }
            catch (SqlException e)
            {
                koneksi.Close();
            }
            return ds;
        }
    }
}
