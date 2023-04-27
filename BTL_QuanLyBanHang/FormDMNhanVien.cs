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
    public partial class FormDMNhanVien : Form
    {
        DataTable tblNV;
        public FormDMNhanVien()
        {
            InitializeComponent();
        }

        private void FormDMNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            /*YEAR(GETDATE()) - YEAR(dNgaySinh)*/
            sql = "SELECT sMaNhanVien,sTenNhanVien,sGioiTinh,sDiaChi,sDienThoai,dNgaySinh FROM tblNhanVien";
            tblNV = Class.Functions.GetDataToTable(sql);//Lấy dữ liệu
            GridViewNhanVien.DataSource = tblNV;
            GridViewNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            GridViewNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            GridViewNhanVien.Columns[2].HeaderText = "Giới tính";
            GridViewNhanVien.Columns[3].HeaderText = "Địa chỉ";
            GridViewNhanVien.Columns[4].HeaderText = "Điện thoại";
            GridViewNhanVien.Columns[5].HeaderText = "Ngày sinh";
           // GridViewNhanVien.Columns[5].HeaderText = "Ngày sinh";
            //GridViewNhanVien.Columns[6].HeaderText = "Tuổi";

            GridViewNhanVien.Columns[0].Width = 100;
            GridViewNhanVien.Columns[1].Width = 150;
            GridViewNhanVien.Columns[2].Width = 100;
            GridViewNhanVien.Columns[3].Width = 150;
            GridViewNhanVien.Columns[4].Width = 100;
            GridViewNhanVien.Columns[5].Width = 100;
            GridViewNhanVien.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            //GridViewNhanVien.Columns[6].Width = 100;

            GridViewNhanVien.AllowUserToAddRows = false;//Không cho sửa trực tiếp
            GridViewNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;// Không cho thêm dữ liệu trực tiếp
        }

        private void GridViewNhanVien_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhanVien.Text = GridViewNhanVien.CurrentRow.Cells["sMaNhanVien"].Value.ToString();
            txtTenNhanVien.Text = GridViewNhanVien.CurrentRow.Cells["sTenNhanVien"].Value.ToString();
            if (GridViewNhanVien.CurrentRow.Cells["sGioiTinh"].Value.ToString() == "Nam") rbNam.Checked = true;
            else rbNam.Checked = false;
            if (GridViewNhanVien.CurrentRow.Cells["sGioiTinh"].Value.ToString() == "Nữ") rbNu.Checked = true;
            else rbNu.Checked = false;
            //else ckNam.Checked = false;
            txtDiaChi.Text = GridViewNhanVien.CurrentRow.Cells["sDiaChi"].Value.ToString();
            txtDienThoai.Text = GridViewNhanVien.CurrentRow.Cells["sDienThoai"].Value.ToString();
            txtNgaySinh.Text = GridViewNhanVien.CurrentRow.Cells["dNgaySinh"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql,gt;// Lưu dữ liệu sql
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            //if (txtDienThoai.Text == "(   )     -")
            //{
            //    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtDienThoai.Focus();
            //    return;
            //}
            if (txtDienThoai.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDienThoai.Focus();
                    return;
                }
                if (txtNgaySinh.Text == "  /  /")
                {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
                }
            if (!Class.Functions.IsDate(txtNgaySinh.Text))
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Text = "";
                txtNgaySinh.Focus();
                return;
            }
            /*if(DateTime.Now.Year - DateTime.Parse(txtNgaySinh.Text).Year < 20)
            {
                MessageBox.Show("Chưa đủ 20 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }*/
            if (rbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (rbNu.Checked == true)
                gt = "Nữ";
            else
                gt = "Nam";

            sql = "SELECT sMaNhanVien FROM tblNhanVien WHERE sMaNhanVien=N'" + txtMaNhanVien.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                txtMaNhanVien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanVien(sMaNhanVien,sTenNhanVien,sGioiTinh, sDiaChi,sDienThoai, dNgaySinh) VALUES (N'" + txtMaNhanVien.Text.Trim() + "',N'" + txtTenNhanVien.Text.Trim() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" + txtDienThoai.Text + "','" + Class.Functions.ConvertDateTime(txtNgaySinh.Text) + "')";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            //if (mtbDienThoai.Text == "(   )     -")
            //{
            //    MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mtbDienThoai.Focus();
            //    return;
            //}

            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            if (txtNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }
            /*if (!Class.Functions.IsDate(txtNgaySinh.Text))
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Text = "";
                txtNgaySinh.Focus();
                return;
            }*/
            /*if(DateTime.Now.Year - DateTime.Parse(txtNgaySinh.Text).Year < 20)
            {
                MessageBox.Show("Chưa đủ 20 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgaySinh.Focus();
                return;
            }*/
            if (rbNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (rbNu.Checked == true)
                gt = "Nữ";
            else
                gt = "Nam";
            sql = "UPDATE tblNhanVien SET  sTenNhanVien=N'" + txtTenNhanVien.Text.Trim().ToString() +
                    "',sDiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',sDienThoai='" + txtDienThoai.Text.ToString() + "',sGioiTinh=N'" + gt +
                    "',dNgaySinh='" + Class.Functions.ConvertDateTime(txtNgaySinh.Text) +
                    "' WHERE sMaNhanVien=N'" + txtMaNhanVien.Text + "'";
            Class.Functions.RunSql(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }


        private void ResetValues()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtDiaChi.Text = "";
            txtNgaySinh.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanVien WHERE sMaNhanVien=N'" + txtMaNhanVien.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtMaNhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void btnIn_Click(object sender, EventArgs e)
        {
            FormBaoCaoNV test = new FormBaoCaoNV();
            test.ShowReport2();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            string recordSelectionFormula = $"{"{tblNhanVien.sMaNhanVien}"} LIKE '*{maNhanVien}*'";
            FormBaoCaoNV test = new FormBaoCaoNV();
            test.ShowReport2(recordSelectionFormula);
        }*/
    }
}
