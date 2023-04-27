using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTL_QuanLyBanHang.Class
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand;//Dùng để truy vấn các câu lệnh Insert, delete, update...
        SqlDataReader dataReader;//Dùng để đọc dữ liệu trong bảng

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }



                sqlConnection.Close();
            } 
                return taiKhoans;
        }

        public void Command(string query)//Dùng để đăng ký tài khoản
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        
    }

    
}
