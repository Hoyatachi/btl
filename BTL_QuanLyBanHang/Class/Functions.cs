using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang.Class
{
    
    class Functions
    {
        public static SqlConnection con;

        //Tạo phương thức Connect()
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=DESKTOP;initial catalog=BTLQuanLyBanHang;trusted_connection=true";
            if(con.State != ConnectionState.Open)
            {
                con.Open();
                //MessageBox.Show("Kết nối thành công");

            }
            else
            {
                MessageBox.Show("Kết nối không thành công");
            }
        }

        //Tạo Phương thức Disconnect
        public static void Disconnect()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();//Đóng kết nối
                con.Dispose();//Giải phóng tài nguyên
                con = null;
            }
        }




        //Phương thức thực thi câu lệnh Select Lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter mydata = new SqlDataAdapter(sql,con);
            mydata.Fill(table);
            return table;
        }



        public static void RunSql(string sql)//Chaỵ cơ sở dữ liệu
        {
            SqlCommand cmd;//Đối tượng thuộc lớp Sql
            cmd = new SqlCommand();
            cmd.Connection = con;//Gán kết nối
            cmd.CommandText = sql;//Gán lệnh Sql
            try
            {
                cmd.ExecuteNonQuery();//Thực hiện câu lệnh Sql
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }



        //Hàm kiểm tra khóa trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }


        //IsDate có tác dụng kiểm tra một biến có ở dạng ngày tháng không
        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 31) && (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 12) && (Convert.ToInt32(elements[2]) >= 1970))
                return true;
            else return false;
        }
        public static string ConvertDateTime(string date)//ConvertDateTime có tác dụng đổi một chuỗi
                                                         //ngày tháng do người dùng nhập có dạng dd/mm/yyyy
                                                         //thành chuỗi ngày tháng có dạng mm/dd/yyyy
                                                         //để lưu vào CSDL.
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public static string GetFieldValues(string sql)//Có tác dụng lấy dữ liệu từ một câu lệnh SQL.
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}
