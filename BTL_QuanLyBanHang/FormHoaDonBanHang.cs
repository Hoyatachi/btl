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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace BTL_QuanLyBanHang
{
    public partial class FormHoaDonBanHang : Form
    {
        DataTable tblCTHDB;
        public FormHoaDonBanHang()
        {
            InitializeComponent();
        }
        private void FormHoaDonBanHang_Load(object sender, EventArgs e)
        {
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            //btnInHoaDon.Enabled = false;
            txtMaHDBan.Enabled = false;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhach.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            //txtGiamGia.Text = "";
            txtTongTien.Text = "0";
            //txtTongTien.Text = "";
            Class.Functions.FillCombo("SELECT sMaKhachHang, sTenKhachHang FROM tblKhachHang", cbMaKhach, "sMaKhachHang", "sMaKhachHang");
            cbMaKhach.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT sMaNhanVien, sTenNhanVien FROM tblNhanVien", cbMaNhanVien, "sMaNhanVien", "sTenKhachHang");
            cbMaNhanVien.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT sMaHang, sTenHang FROM tblHang", cbMaHang, "sMaHang", "sMaHang");
            cbMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHDBan.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            LoadDataGridView();
        }


        //Nạp chi tiết hóa đơn
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT dNgayBan FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
            txtNgayBan.Text = Class.Functions.ConvertDateTime(Class.Functions.GetFieldValues(str));
            str = "SELECT sMaNhanVien FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
            cbMaNhanVien.Text = Class.Functions.GetFieldValues(str);
            str = "SELECT sMaKhachHang FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
            cbMaKhach.Text = Class.Functions.GetFieldValues(str);
            str = "SELECT fTongTien FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
            txtTongTien.Text = Class.Functions.GetFieldValues(str);
           
        }



        //Thêm dữ liệu vào GridView
        private void LoadDataGridView()
        {
            string sql;
            
            sql = "SELECT a.sMaHang, b.sTenHang, a.fSoLuong, b.fDonGiaBan, a.fGiamGia,a.fThanhTien " +
                "FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.sMaHDBan = N'" 
                + txtMaHDBan.Text + "' AND a.sMaHang=b.sMaHang";
            
            /*sql = "SELECT a.sMaHang, b.sTenHang, a.fSoLuong, a.fDonGia, a.fGiamGia,a.fThanhTien " +
                "FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.sMaHDBan = N'" 
                + txtMaHDBan.Text + "' AND a.sMaHang=b.sMaHang";*/
            tblCTHDB = Class.Functions.GetDataToTable(sql);
            GridViewHoaDon.DataSource = tblCTHDB;
            GridViewHoaDon.Columns[0].HeaderText = "Mã hàng";
            GridViewHoaDon.Columns[1].HeaderText = "Tên hàng";
            GridViewHoaDon.Columns[2].HeaderText = "Số lượng";
            GridViewHoaDon.Columns[3].HeaderText = "Đơn giá";
            GridViewHoaDon.Columns[4].HeaderText = "Giảm giá %";
            GridViewHoaDon.Columns[5].HeaderText = "Thành tiền";
            GridViewHoaDon.Columns[0].Width = 80;
            GridViewHoaDon.Columns[1].Width = 130;
            GridViewHoaDon.Columns[2].Width = 80;
            GridViewHoaDon.Columns[3].Width = 90;
            GridViewHoaDon.Columns[4].Width = 90;
            GridViewHoaDon.Columns[5].Width = 90;
            GridViewHoaDon.AllowUserToAddRows = false;
            GridViewHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Đặt giá trị của các nút

            btnBoQua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaHDBan.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            ResetValuesKhach();
            
            LoadDataGridView();
        }

        private void ResetValues()//Biến các giá trị hiện tại về ban đầu
        {
            txtMaHDBan.Text = "";
            txtNgayBan.Text = DateTime.Now.ToShortDateString();
            cbMaNhanVien.Text = "";
            cbMaKhach.Text = "";
            txtTongTien.Text = "0";
            
            cbMaHang.Text = "";
            txtSoLuong.Text = "";
            //txtGiamGia.Text = "0";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;// Số lượng, số lượng còn, tổng, tổng mới
            

            sql = "SELECT sMaHDBan FROM tblHDBan WHERE sMaHDBan=N'" + txtMaHDBan.Text.Trim() + "'";
            if (!Class.Functions.CheckKey(sql))
            {
                /*MessageBox.Show("Mã hóa đơn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHDBan.Focus();
                txtMaHDBan.Text = "";
                return;*/

                if (txtMaHDBan.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã Hóa đơn bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHDBan.Focus();
                    return;
                }
                if (cbMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Mã nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaNhanVien.Focus();
                    return;
                }

                if (cbMaKhach.Text.Length == 0)
                {
                    MessageBox.Show("Mã Khách Hàng không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMaKhach.Focus();
                    return;
                }

                /*if(txtNgayBan.Value.CompareTo(DateTime.Now) > 0)
                {
                    MessageBox.Show("Ngày bán k được lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayBan.Focus();
                    return;
                }*/

                sql = "INSERT INTO tblHDBan(sMaHDBan, dNgayBan, sMaNhanVien, sMaKhachHang, fTongTien) VALUES (N'" + txtMaHDBan.Text.Trim() + "','" +
                           txtNgayBan.Value + "',N'" + cbMaNhanVien.SelectedValue + "',N'" +
                           cbMaKhach.SelectedValue + "'," + txtTongTien.Text + ")";
                Class.Functions.RunSql(sql);
            }
            

            // Lưu thông tin của các mặt hàng
            if (cbMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            if (txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return;
            }
            sql = "SELECT sMaHang FROM tblChiTietHDBan WHERE sMaHang=N'" + cbMaHang.SelectedValue + "' AND sMaHDBan = N'" + txtMaHDBan.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbMaHang.Focus();
                return;
            }

            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Class.Functions.GetFieldValues("SELECT fSoLuong FROM tblHang WHERE sMaHang = N'" + cbMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            string donGia = (Convert.ToDouble(txtDonGiaBan.Text) + Convert.ToDouble(txtDonGiaBan.Text) / 100 * 10).ToString();
            sql = "INSERT INTO tblChiTietHDBan(sMaHDBan,sMaHang,fSoLuong,fDonGia, fGiamGia,fThanhTien) VALUES(N'" + txtMaHDBan.Text.Trim() + "',N'" + cbMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGiaBan.Text + "," + txtGiamGia.Text + "," + txtThanhTien.Text + ")";
            //sql = "INSERT INTO tblChiTietHDBan(sMaHDBan,sMaHang,fSoLuong,fDonGia, fGiamGia,fThanhTien) VALUES(N'" + txtMaHDBan.Text.Trim() + "',N'" + cbMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + donGia + "," + txtGiamGia.Text + "," + txtThanhTien.Text + ")";

            Class.Functions.RunSql(sql);
            LoadDataGridView();

            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE tblHang SET fSoLuong =" + SLcon + " WHERE sMaHang= N'" + cbMaHang.SelectedValue + "'";
            Class.Functions.RunSql(sql);

            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Class.Functions.GetFieldValues("SELECT fTongTien FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblHDBan SET fTongTien =" + Tongmoi + " WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
            Class.Functions.RunSql(sql);
            txtTongTien.Text = Tongmoi.ToString();
            ResetValuesHang();
            //ResetValuesKhach();
            txtMaHDBan.Enabled = false;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnIn.Enabled = true;
        }

        private void ResetValuesKhach()
        {
            txtMaHDBan.Text = "";
            txtNgayBan.Text = DateTime.Now.ToShortDateString();
            cbMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cbMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        private void ResetValuesHang()
        {
            cbMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void cbMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMaNhanVien.Text == "")
                txtTenNhanVien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select sTenNhanVien from tblNhanVien where sMaNhanVien =N'" + cbMaNhanVien.SelectedValue + "'";
            txtTenNhanVien.Text = Class.Functions.GetFieldValues(str);
        }
        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string str;
            if (cbMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGiaBan.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT sTenHang FROM tblHang WHERE sMaHang =N'" + cbMaHang.SelectedValue + "'";
            txtTenHang.Text = Class.Functions.GetFieldValues(str);
            str = "SELECT fDonGiaBan FROM tblHang WHERE sMaHang =N'" + cbMaHang.SelectedValue + "'";
            
            txtDonGiaBan.Text = Class.Functions.GetFieldValues(str);
            
            

        }
        private void txtMaHDBan_TextChanged(object sender, EventArgs e)
        {
            
            string str;
            if (cbMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGiaBan.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT sTenHang FROM tblHang WHERE sMaHang =N'" + cbMaHang.SelectedValue + "'";
            txtTenHang.Text = Class.Functions.GetFieldValues(str);
            str = "SELECT fDonGiaBan FROM tblHang WHERE sMaHang =N'" + cbMaHang.SelectedValue + "'";
            txtDonGiaBan.Text = Class.Functions.GetFieldValues(str);
            
        }

        private void cbMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbMaKhach.Text == "")
            {
                txtTenKhach.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select sTenKhachHang from tblKhachHang where sMaKhachHang = N'" + cbMaKhach.SelectedValue + "'";
            txtTenKhach.Text = Class.Functions.GetFieldValues(str);
            str = "Select sDiaChi from tblKhachHang where sMaKhachHang = N'" + cbMaKhach.SelectedValue + "'";
            txtDiaChi.Text = Class.Functions.GetFieldValues(str);
            str = "Select sDienThoai from tblKhachHang where sMaKhachHang = N'" + cbMaKhach.SelectedValue + "'";
            txtDienThoai.Text = Class.Functions.GetFieldValues(str);
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //string donGia = (Convert.ToDouble(txtDonGiaBan.Text) + Convert.ToDouble(txtDonGiaBan.Text) / 100 * 10).ToString();
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;// Thành tiền, số lượng, đơn giá, giảm giá
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;//Số lượng * đơn giá - [(số lượng * đơn giá * giảm giá)/100]
            //tt = sl * double.Parse(donGia) - sl * double.Parse(donGia) * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //string donGia = (Convert.ToDouble(txtDonGiaBan.Text) + Convert.ToDouble(txtDonGiaBan.Text) / 100 * 10).ToString();
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;// Thành tiền, số lượng, đơn giá, giảm giá
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;//Số lượng * đơn giá - [(số lượng * đơn giá * giảm giá)/100]
            //tt = sl * double.Parse(donGia) - sl * double.Parse(donGia) * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT sMaHang, fSoLuong FROM tblChiTietHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
                DataTable tblHang = Class.Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Class.Functions.GetFieldValues("SELECT fSoLuong FROM tblHang WHERE sMaHang = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblHang SET fSoLuong =" + slcon + " WHERE sMaHang= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Class.Functions.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE tblChiTietHDBan WHERE sMaHDBan=N'" + txtMaHDBan.Text + "'";
                Class.Functions.RunSqlDel(sql);

                //Xóa hóa đơn
                sql = "DELETE tblHDBan WHERE sMaHDBan=N'" + txtMaHDBan.Text + "'";
                Class.Functions.RunSqlDel(sql);
                ResetValues();
                ResetValuesHang();
                ResetValuesKhach();
                LoadDataGridView();
                btnXoa.Enabled = false;
                
            }
        }
        private void GridViewHoaDon_DoubleClick(object sender, EventArgs e)
        {
            
                string MaHangxoa, sql;
                Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
                if (tblCTHDB.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    //Xóa hàng và cập nhật lại số lượng hàng 
                    MaHangxoa = GridViewHoaDon.CurrentRow.Cells["sMaHang"].Value.ToString();
                    SoLuongxoa = Convert.ToDouble(GridViewHoaDon.CurrentRow.Cells["fSoLuong"].Value.ToString());
                    ThanhTienxoa = Convert.ToDouble(GridViewHoaDon.CurrentRow.Cells["fThanhTien"].Value.ToString());
                    sql = "DELETE tblChiTietHDBan WHERE sMaHDBan=N'" + txtMaHDBan.Text + "' AND sMaHang = N'" + MaHangxoa + "'";
                    Class.Functions.RunSql(sql);
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Class.Functions.GetFieldValues("SELECT fSoLuong FROM tblHang WHERE sMaHang = N'" + MaHangxoa + "'"));
                    slcon = sl + SoLuongxoa;
                    sql = "UPDATE tblHang SET fSoLuong =" + slcon + " WHERE sMaHang= N'" + MaHangxoa + "'";
                    Class.Functions.RunSql(sql);
                    // Cập nhật lại tổng tiền cho hóa đơn bán
                    tong = Convert.ToDouble(Class.Functions.GetFieldValues("SELECT fTongTien FROM tblHDBan WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'"));
                    tongmoi = tong - ThanhTienxoa;
                    sql = "UPDATE tblHDBan SET fTongTien =" + tongmoi + " WHERE sMaHDBan = N'" + txtMaHDBan.Text + "'";
                    Class.Functions.RunSql(sql);
                    txtTongTien.Text = tongmoi.ToString();
                    LoadDataGridView();
                }
            
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMaHDBan.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaHDBan.Focus();
                return;
            }
            txtMaHDBan.Text = cbMaHDBan.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            cbMaHDBan.SelectedIndex = -1;
        }
        private void cbMaHDBan_DropDown(object sender, EventArgs e)
        {
            Class.Functions.FillCombo("SELECT sMaHDBan FROM tblHDBan", cbMaHDBan, "sMaHDBan", "sMaHDBan");
            cbMaHDBan.SelectedIndex = -1;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            // ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"D:\BaiTap C#\BTL_QuanLyBanHang\BTL_QuanLyBanHang\Crystal Report\CrystalReportHoaDon.rpt");
            //crystalReportViewer1.ReportSource = rpt;
            //crystalReportViewer1.Refresh();

            FormBaoCao test = new FormBaoCao();
            test.ShowReport();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDonBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }
        
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnIn.Enabled = true;
            txtMaHDBan.Enabled = false;
            ResetValues();
            ResetValuesHang();
        }
    }
}
