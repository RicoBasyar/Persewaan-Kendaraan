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
    class ModelKendaraan
    {
        private SqlConnection koneksi;
        private SqlCommand command;
        private string query;
        private bool hasil;

        public ModelKendaraan()
        {
            koneksi = Model.KoneksiDB.GetConnection();
        }

        private string no_pol, jenis_kendaraan, merk_kendaraan, no_rangka;
        private double harga_perhari;
        private int no_mesin;
       
        //Fungsi Set
        public void SetNo_mesin(int no_mesin)
        {
            this.no_mesin = no_mesin;
        }

        public void Setno_rangka(string no_rangka)
        {
            this.no_rangka = no_rangka;
        }

        public void SetNo_Pol(string no_pol)
        {
            this.no_pol = no_pol;
        }
        public void Setjenis_kendaraan(string jenis_kendaraan)
        {
            this.jenis_kendaraan = jenis_kendaraan;
        }
        public void Setmerk_kendaraan(string merk_kendaraan)
        {
            this.merk_kendaraan = merk_kendaraan;
        }
        public void SetHarga_perhari(double harga_perhari)
        {
            this.harga_perhari = harga_perhari;
        }

        //Fungsi Get

        public int GetNo_mesin()
        {
            return no_mesin;
        }

        public string GetNo_rangka()
        {
            return no_rangka;
        }

        public string GetNo_Pol()
        {
            return no_pol;
        }
        public string Getjenis_kendaraan()
        {
            return jenis_kendaraan;
        }
        public string Getmerk_kendaraan()
        {
            return merk_kendaraan;
        }
        public double Getharga_perhari()
        {
            return harga_perhari;
        }

        //Fungsi proses

        public Boolean InsertKendaraan()
        {
            hasil = false;
            try
            {
                query = "insert into kendaraan values ('" + no_pol + "'," +
                    "                               " + no_mesin + "," +
                                                    " '" + no_rangka + "'," +
                                                    " '" + jenis_kendaraan + "'," +
                                                    " '" + merk_kendaraan + "'," +
                                                    " '" + harga_perhari + "'," +
                                                    " '" + Controller.AdminController.id.ToString() + "')";

                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                koneksi.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error : " + e);
                hasil = false;
                koneksi.Close();
            }
            return hasil;
        }
        public Boolean UpdateKendaraan()
        {
            hasil = false;
            try
            {
                query = "update kendaraan set jenis_kendaraan = '" + jenis_kendaraan + "'," +
                                             "merk_kendaraan='" + merk_kendaraan + "', " +
                                             "no_mesin =" + no_mesin + ", " +
                                             "no_rangka='" + no_rangka + "', " +
                                             "harga_perhari='" + harga_perhari + "' " +
                                             "where no_pol ='"+no_pol+"'";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                koneksi.Close();
            }
            catch (SqlException e)
            {
                hasil = false;
                koneksi.Close();
            }
            return hasil;
        }

        public Boolean DeleteKendaraan()
        {
            hasil = false;
            try
            {
                query = "delete from kendaraan where no_pol = '"+no_pol+"'";
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                hasil = true;
                koneksi.Close();
            }
            catch (SqlException e)
            {
                hasil = false;
                koneksi.Close();
            }
            return false;
        }

        public DataSet TabelKendaraan()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM kendaraan";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "kendaraan");
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
