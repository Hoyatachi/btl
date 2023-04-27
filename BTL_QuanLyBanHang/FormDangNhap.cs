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
    public partial class FormDangNhap : Form
    {
        //int attempts = 1;
        public FormDangNhap()
        {
            InitializeComponent();
            
        }
        public bool checkAccount(string ac)//Check mật khẩu và tên tài khoản
        {
            return Regex.IsMatch(ac, "^([a-zA-Z0-9])$");
        }
        Class.Modify modify = new Class.Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMatKhau.Text.Trim().Length < 6)
            {

                MessageBox.Show("Mật khẩu phải dài tối thiểu 6 ký tự");
                return;
            }
            /*else if (!checkAccount(matkhau))
            {
                MessageBox.Show("Mật khẩu phải viết hoa");
            }*/
            else 
            {
                string query ="Select * from TaiKhoan where TenTaiKhoan= '"+tentk+"' and MatKhau= '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain FormMain = new frmMain();
                    FormMain.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            








            /*else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan= '" + tentk + "' and MatKhau= '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain FormMain = new frmMain();
                    FormMain.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    attempts++;
                }
            }

            if(attempts == 4)
            {
                MessageBox.Show("Đăng nhập sai 4 lần, chương trình sẽ tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }*/


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DK formdangky = new DK();
            formdangky.ShowDialog();
        }
    }
}
