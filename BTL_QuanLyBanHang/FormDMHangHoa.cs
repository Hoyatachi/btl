using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_QuanLyBanHang
{
    public partial class FormDMHangHoa : Form
    {
        DataTable tblH;
        public FormDMHangHoa()
        {
            InitializeComponent();
        }

        private void FormDMHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblChatLieu";
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Class.Functions.FillCombo(sql, cbMaChatLieu, "sMaChatLieu", "sTenChatLieu");
            cbMaChatLieu.SelectedIndex = -1;
            ResetValues();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblHang";
            tblH = Class.Functions.GetDataToTable(sql);
            GridViewHang.DataSource = tblH;
            GridViewHang.Columns[0].HeaderText = "Mã Hàng";
            GridViewHang.Columns[1].HeaderText = "Tên Hàng";
            GridViewHang.Columns[1].HeaderText = "Chất Liệu";
            GridViewHang.Columns[1].HeaderText = "Số lượng";
            GridViewHang.Columns[1].HeaderText = "Đơn giá nhập";
            GridViewHang.Columns[1].HeaderText = "Đơn giá bán";
            GridViewHang.Columns[1].HeaderText = "Ghi chú";
            GridViewHang.Columns[0].Width = 80;
            GridViewHang.Columns[1].Width = 140;
            GridViewHang.Columns[2].Width = 80;
            GridViewHang.Columns[3].Width = 80;
            GridViewHang.Columns[4].Width = 100;
            GridViewHang.Columns[5].Width = 100;
            GridViewHang.Columns[6].Width = 300;
            GridViewHang.AllowUserToAddRows = false;
            GridViewHang.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cbMaChatLieu.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtGhiChu.Text = "";
        }
        private void GridViewHang_Click(object sender, EventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaHang.Text = GridViewHang.CurrentRow.Cells["sMaHang"].Value.ToString();
            txtTenHang.Text = GridViewHang.CurrentRow.Cells["sTenHang"].Value.ToString();
            MaChatLieu = GridViewHang.CurrentRow.Cells["sMaChatLieu"].Value.ToString();
            sql = "SELECT sTenChatLieu FROM tblChatLieu WHERE sMaChatLieu=N'" + MaChatLieu + "'";

            cbMaChatLieu.Text = Class.Functions.GetFieldValues(sql);

            txtSoLuong.Text = GridViewHang.CurrentRow.Cells["fSoLuong"].Value.ToString();
            txtDonGiaNhap.Text = GridViewHang.CurrentRow.Cells["fDonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = GridViewHang.CurrentRow.Cells["fDonGiaBan"].Value.ToString();

            sql = "SELECT sGhichu FROM tblHang WHERE sMaHang = N'" + txtMaHang.Text + "'";
            txtGhiChu.Text = Class.Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHang.Enabled = true;
            txtMaHang.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cbMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaChatLieu.Focus();
                return;
            }
            
            sql = "SELECT sMaHang FROM tblHang WHERE sMaHang=N'" + txtMaHang.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            sql = "INSERT INTO tblHang(sMaHang,sTenHang,sMaChatLieu,fSoLuong,fDonGiaNhap, fDonGiaBan,sGhichu) VALUES(N'"
                + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() +
                "',N'" + cbMaChatLieu.SelectedValue.ToString() +
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text  + ",N'" + txtGhiChu.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cbMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaChatLieu.Focus();
                return;
            }
            
            sql = "UPDATE tblHang SET sTenHang=N'" + txtTenHang.Text.Trim().ToString() +
                "',sMaChatLieu=N'" + cbMaChatLieu.SelectedValue.ToString() +
                "',fSoLuong=" + txtSoLuong.Text + ",sGhichu=N'" + txtGhiChu.Text + "' WHERE sMaHang=N'" + txtMaHang.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE sMaHang=N'" + txtMaHang.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}























//private void btnTimKiem_Click(object sender, EventArgs e)
//{
//    string sql;
//    if ((txtMaHang.Text == "") && (txtTenHang.Text == "") && (cbMaChatLieu.Text == ""))
//    {
//        MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        return;
//    }
//    sql = "SELECT * from tblHang WHERE 1=1";
//    if (txtMaHang.Text != "")
//        sql += " AND sMaHang LIKE N'%" + txtMaHang.Text + "%'";
//    if (txtTenHang.Text != "")
//        sql += " AND sTenHang LIKE N'%" + txtTenHang.Text + "%'";
//    if (cbMaChatLieu.Text != "")
//        sql += " AND sMaChatLieu LIKE N'%" + cbMaChatLieu.SelectedValue + "%'";
//    tblH = Class.Functions.GetDataToTable(sql);
//    if (tblH.Rows.Count == 0)
//        MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    GridViewHang.DataSource = tblH;
//    ResetValues();
//}

//private void btnHienThiDS_Click(object sender, EventArgs e)
//{
//    string sql;
//    sql = "SELECT sMaHang,sTenHang,sMaChatLieu,fSoLuong,fDonGiaNhap,fDonGiaBan,sGhichu FROM tblHang";
//    tblH = Class.Functions.GetDataToTable(sql);
//    GridViewHang.DataSource = tblH;
//}