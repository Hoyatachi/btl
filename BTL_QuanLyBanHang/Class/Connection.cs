using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL_QuanLyBanHang.Class
{
    class Connection
    {
        private static string stringConnection = @"data source=DESKTOP;initial catalog=BTLQuanLyBanHang;trusted_connection=true";
        public static SqlConnection GetSqlConnection()
        {
            {
                return new SqlConnection(stringConnection);
            }
        }
    }
}
