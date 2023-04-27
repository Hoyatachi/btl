using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang
{
    public partial class CPS : Form
    {
        public CPS()
        {
            InitializeComponent();
        }
        Class.Modify modify = new Class.Modify();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string oldpass = txtOldPass.Text;
            string newpass = txtNewPass.Text;
            string newpass2 = txtNewPass2.Text;
            if (oldpass.Trim() == "")
            {
                MessageBox.Show("Vui Lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                string query = "SELECT * FROM TaiKhoan where matKhau='" + oldpass + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    if(newpass.Trim() == "")
                    {
                        MessageBox.Show("Hãy điền mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }else if(newpass2.Trim() == ""){
                        MessageBox.Show("Hãy xác nhận mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    else if (txtNewPass.Text == txtNewPass2.Text) {
                        string query2 = "Update TaiKhoan Set matKhau= '" + newpass2 + "'where matKhau='" + oldpass + "'";
                        modify.Command(query2);
                        MessageBox.Show("đổi mật khẩu thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không khớp với nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
