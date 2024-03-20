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
    class AdminModel
    {
        private SqlConnection koneksi;
        private SqlCommand command;
        private string query;
        private bool hasil;

        public AdminModel()
        {
            koneksi = Model.KoneksiDB.GetConnection();
        }

        private string id_admin, nama_admin, password;
        
        //FUNGSI Set
        public void SetIDadmin(string id_admin){
            this.id_admin = id_admin;    
        }
        public void Setnama_admin(string nama_admin)
        {
            this.nama_admin = nama_admin;
        }
        public void Setpassword(string password)
        {
            this.password = password;
        }

        //Fungsi Get
        public string GetIDAdmin()
        {
            return id_admin;
        }
        public string Getnama_Admin()
        {
            return nama_admin;
        }
        public string Getpassword()
        {
            return password;
        }

        //Fungsi proses

        public bool Login(string nama, string pass)
        {
            query = "Select * from admin where nama_admin = '" + nama + "' AND password = '" + pass + "'";
            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetString(1).ToString() == nama && reader.GetString(2).ToString() == pass)
                {
                    Controller.AdminController.id = reader.GetString(0).ToString();
                    Controller.AdminController.nama = reader.GetString(1).ToString();
                    Controller.AdminController.pass = reader.GetString(2).ToString();
                    hasil = true;
                }
                else
                {
                    hasil = false;
                }
            }
            koneksi.Close();
            return hasil;
        }
    }
}
