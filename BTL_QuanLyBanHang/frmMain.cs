using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang
{
    public partial class frmMain : Form
    {
        bool isThoat = true;
        /*System.Timers.Timer t;
        int h, m, s;*/
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); // Mở kết nối
            /*t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();*/
            
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            
            /*Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));*/
            
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void MenuChatLieu_Click(object sender, EventArgs e)
        {
            FormDMChatLieu FormChatLieu = new FormDMChatLieu();
            FormChatLieu.ShowDialog();
        }

        private void MenuNhanVien_Click(object sender, EventArgs e)
        {
            FormDMNhanVien FormNhanVien = new FormDMNhanVien();
            FormNhanVien.ShowDialog();
        }

        private void MenuKhachHang_Click(object sender, EventArgs e)
        {
            FormDMKhachHang FormKhachHang = new FormDMKhachHang();
            FormKhachHang.ShowDialog();
        }

        private void MenuHangHoa_Click(object sender, EventArgs e)
        {
            FormDMHangHoa FormHangHoa = new FormDMHangHoa();
            FormHangHoa.ShowDialog();
        }

        

        private void MenuBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            FormBaoCao newForm6 = new FormBaoCao();
            newForm6.ShowDialog();
        }

        private void MenuHoaDonBan_Click(object sender, EventArgs e)
        {
            FormHoaDonBanHang FormHDBH = new FormHoaDonBanHang();
            FormHDBH.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*t.Stop();
            Application.DoEvents();*/
        }

        

        /*private void MenuFindHoaDon_Click(object sender, EventArgs e)
        {
            FormTimKiem FormTK = new FormTimKiem();
            FormTK.ShowDialog();
        }*/

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
            
        }

        
    }
}


































