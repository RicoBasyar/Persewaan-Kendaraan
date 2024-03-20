using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Persewaan.Model
{
    class ModelTransaksi
    {
        private SqlConnection koneksi;
        private SqlCommand command;
        private string query;
        private bool hasil;

        public ModelTransaksi()
        {
            koneksi = Model.KoneksiDB.GetConnection();
        }

        private string id_transaksi, tanggal_ambil, tanggal_kembali, nik, no_pol;
        private string search;

        public void SetNo_pol(string no_pol)
        {
            this.no_pol = no_pol;
        }

        public void SetSearch(string search)
        {
            this.search = search;
        }

        public void SetNIK(string nik)
        {
            this.nik = nik;
        }

        public void SetID_transaksi(string id_transaksi)
        {
            this.id_transaksi = id_transaksi;
        }
        public void SetTanggal_ambil(string tanggal_ambil)
        {
            this.tanggal_ambil = tanggal_ambil;
        }

        public void SetTanggal_pinjam(string tanggal_pinjam)
        {
            this.tanggal_kembali = tanggal_pinjam;
        }
        public string GetNo_pol()
        {
            return no_pol;
        }

        public string getSearch()
        {
            return search;
        }

        public string GetNIK()
        {
            return nik;
        }

        public string GetID_transaksi()
        {
            return id_transaksi;
        }

        public string Gettanggalambil()
        {
            return tanggal_ambil;
        }

        public string Gettanggalpinjam()
        {
            return tanggal_kembali;
        }


        public Boolean InsertTransaksi()
        {
            hasil = false;
            try
            {
                query = "insert into transaksi values ('" + id_transaksi + "'," +
                                                    " '" + Controller.AdminController.id.ToString() + "'," +
                                                    " '" + no_pol + "'," +
                                                    " '" + tanggal_ambil + "'," +
                                                    " '" + tanggal_kembali + "' ," +
                                                    " '" + nik + "')";

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

        public Boolean UpdateTransaksi()
        {
            hasil = false;
            try
            {
                query = "update transaksi set nik = '" + nik + "'," +
                                            "no_pol ='" + no_pol + "', " +
                                            "tgl_ambil ='" + tanggal_ambil + "', " +
                                            "tgl_kembali ='" + tanggal_kembali + "' " +
                                            "where id_transaksi = '" + id_transaksi + "'";

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

        public Boolean DeleteTransaksi()
        {
            hasil = false;
            try
            {
                query = "delete from transaksi where id_transaksi = '" + id_transaksi + "'";
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

        public DataSet SelectDataDashboard()
        {
            DataSet DataDashboard = new DataSet();

            try
            {
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandType = CommandType.Text;
                command.CommandText = " select transaksi.id_transaksi, customer.nama_customer, kendaraan.jenis_kendaraan, kendaraan.merk_kendaraan, kendaraan.harga_perhari "
                                       + " from transaksi join customer on transaksi.nik = customer.nik"
                                       + " join kendaraan on transaksi.no_pol = kendaraan.no_pol"
                                       + " Where customer.nama_customer LIKE '%"+search+"%' OR transaksi.id_transaksi LIKE '%"+search+"%'"
                                       + " OR kendaraan.merk_kendaraan LIKE '%"+search+"%' ";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(DataDashboard, "customer");
                koneksi.Close();
            }
            catch(SqlException e)
            {
                koneksi.Close();
            }
            return DataDashboard;
        }

        public DataSet SelectDataNota()
        {
            DataSet DataDashboard = new DataSet();

            try
            {
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT transaksi.id_transaksi, kendaraan.jenis_kendaraan , " 
                                      + "FORMAT(transaksi.tgl_ambil, 'dd/MM/yyyy') as tgl_ambil, FORMAT(transaksi.tgl_kembali, 'dd/MM/yyyy') as tgl_kembali, " 
                                      + " DATEDIFF(DAY, transaksi.tgl_ambil, transaksi.tgl_kembali) AS [Selisih], kendaraan.harga_perhari, "
                                      + " DATEDIFF(DAY, transaksi.tgl_ambil, transaksi.tgl_kembali) * kendaraan.harga_perhari AS Total"
                                      + " from transaksi JOIN kendaraan on transaksi.no_pol = kendaraan.no_pol"
                                      + " JOIN customer on transaksi.nik = customer.nik"
                                      + " where transaksi.id_transaksi = '"+id_transaksi+"'";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(DataDashboard, "nota");
                koneksi.Close();
            }
            catch (SqlException e)
            {
                koneksi.Close();
            }
            return DataDashboard;
        }


        public string GenerateCode()
        {
            byte kode = 0;
            string id = "", format = "";
            query = "Select MAX (RIGHT(id_transaksi, 2)) FROM transaksi";
            koneksi.Open();
            command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kode = reader.GetByte(0);
                    }
                }
            }
            catch
            {
                kode = 0;
            }
            format = "TR";
            if (kode == 0)
            {
                id = format + "-001";
            }
            else if (kode < 10)
            {
                id = format + "-00" + (kode + 1);
            }
            else if (kode < 100)
            {
                id = format + "-0" + (kode + 1);
            }
            else
            {
                id = format + "-" + (kode + 1);
            }
            koneksi.Close();
            return id;
        }

        public DataSet TabelTransaksi()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                command = new SqlCommand();
                command.Connection = koneksi;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM transaksi";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "transaksi");
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
