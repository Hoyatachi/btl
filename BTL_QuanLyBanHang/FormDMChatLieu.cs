using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang
{
    public partial class FormDMChatLieu : Form
    {
        DataTable tblCL;
        public FormDMChatLieu()
        {
            InitializeComponent();
        }

        private void FormDMChatLieu_Load(object sender, EventArgs e)
        {
            txtMaChatLieu.Enabled = false;
            BtnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT sMaChatLieu, sTenChatLieu FROM tblChatLieu";
            tblCL = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            GridViewChatLieu.DataSource = tblCL; //Nguồn dữ liệu            
            GridViewChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            GridViewChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            GridViewChatLieu.Columns[0].Width = 100;
            GridViewChatLieu.Columns[1].Width = 300;
            GridViewChatLieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            GridViewChatLieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GridViewChatLieu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)//nút thêm không ở trạng thái kích hoạt
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaChatLieu.Text = GridViewChatLieu.CurrentRow.Cells["sMaChatLieu"].Value.ToString();
            txtTenChatLieu.Text = GridViewChatLieu.CurrentRow.Cells["sTenChatLieu"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            BtnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();//Xóa trắng dữ liệu
            txtMaChatLieu.Enabled = true;//Cho phép nhập
            txtMaChatLieu.Focus();

        }

        private void ResetValue()
        {
            txtMaChatLieu.Text = "";
            txtTenChatLieu.Text = "";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            BtnLuu.Enabled = false;
            txtMaChatLieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;// Lưu câu lệnh Sql
            if(tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không có Dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if(txtMaChatLieu.Text == "" && txtTenChatLieu.Text == "")//Nếu chưa chọn dữ liệu nào
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtTenChatLieu.Text.Trim().Length == 0)//Nếu chưa nhập dữ liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblChatLieu set sTenChatLieu=N'" + txtTenChatLieu.Text.ToString() + "'Where sMaChatLieu=N'" + txtMaChatLieu.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            string sql;//Lưu lệnh Sql
            if (txtMaChatLieu.Text.Trim().Length == 0)//Để trống
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Focus();
                return;
            }
            if (txtTenChatLieu.Text.Trim().Length == 0)//Để trống
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChatLieu.Focus();
                return;
            }
            sql = "Select sMaChatLieu From tblChatLieu where sMaChatLieu = N'" + txtMaChatLieu.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChatLieu.Focus();
                return;
            }
            sql = "INSERT INTO tblChatLieu VALUES(N'" +
                txtMaChatLieu.Text + "',N'" + txtTenChatLieu.Text + "')";
            Class.Functions.RunSql(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            BtnLuu.Enabled = false;
            txtMaChatLieu.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String sql;//Lưu câu lệnh Sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChatLieu.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblChatLieu WHERE sMaChatLieu=N'" + txtMaChatLieu.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void txtMaChatLieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
