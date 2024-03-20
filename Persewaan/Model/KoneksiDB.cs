using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Persewaan.Model
{
    class KoneksiDB
    {
        private static SqlConnection koneksi;

        public static SqlConnection GetConnection()
        {
            koneksi = new SqlConnection();
            koneksi.ConnectionString = ("Data Source=DESKTOP-9LD9R8M\\SQLEXPRESS; Initial Catalog=persewaanREF; Integrated Security=true");
            return koneksi;
        }
    }
}
