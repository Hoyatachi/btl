using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BTL_QuanLyBanHang
{
    public partial class DK : Form
    {
        public DK()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac)//Check mật khẩu và tên tài khoản
        {
            return Regex.IsMatch(ac, @"^[a-z0-9]$");
        }
        /*public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }*/
        Class.Modify modify = new Class.Modify();


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tendk = txtDangKy.Text;
            string matkhaudk = txtMatKhau.Text;
            string xnmatkhaudk = txtXacNhanMK.Text;
            //string pattern = @"^[a-zA-Z0-9]{6-20}$";
            if (tendk.Trim() == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (matkhaudk.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMatKhau.Text.Trim().Length < 6)
            {
                
                MessageBox.Show("Mật khẩu phải dài tối thiểu 6 ký tự ");
                return;
            }
            
            else if (xnmatkhaudk.Trim() == "")
            {
                MessageBox.Show("Hãy xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            else if (txtXacNhanMK.Text.Trim().Length < 6)
            {
                MessageBox.Show("Mật khẩu phải dài 6 ký tự ");
                return;
            }
            
            else if (matkhaudk != xnmatkhaudk)
            {
                MessageBox.Show("Vui lòng nhập chính xác mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    string query = "INSERT INTO TaiKhoan VALUES ('" + tendk + "','" + matkhaudk + "')";
                    modify.Command(query);
                    if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();
                    }

                }
                catch
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại, hãy nhập tên khác!");
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
