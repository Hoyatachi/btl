
namespace BTL_QuanLyBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTapTin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBaoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTapTin,
            this.MenuDanhMuc,
            this.MenuHoaDon,
            this.MenuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTapTin
            // 
            this.MenuTapTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuThoat,
            this.đăngXuấtToolStripMenuItem});
            this.MenuTapTin.Name = "MenuTapTin";
            this.MenuTapTin.Size = new System.Drawing.Size(55, 20);
            this.MenuTapTin.Text = "Tập tin";
            // 
            // MenuThoat
            // 
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.Size = new System.Drawing.Size(129, 22);
            this.MenuThoat.Text = "Thoát";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // MenuDanhMuc
            // 
            this.MenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChatLieu,
            this.MenuNhanVien,
            this.MenuKhachHang,
            this.MenuHangHoa});
            this.MenuDanhMuc.Name = "MenuDanhMuc";
            this.MenuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.MenuDanhMuc.Text = "Danh mục";
            // 
            // MenuChatLieu
            // 
            this.MenuChatLieu.Name = "MenuChatLieu";
            this.MenuChatLieu.Size = new System.Drawing.Size(137, 22);
            this.MenuChatLieu.Text = "Chất liệu";
            this.MenuChatLieu.Click += new System.EventHandler(this.MenuChatLieu_Click);
            // 
            // MenuNhanVien
            // 
            this.MenuNhanVien.Name = "MenuNhanVien";
            this.MenuNhanVien.Size = new System.Drawing.Size(137, 22);
            this.MenuNhanVien.Text = "Nhân viên";
            this.MenuNhanVien.Click += new System.EventHandler(this.MenuNhanVien_Click);
            // 
            // MenuKhachHang
            // 
            this.MenuKhachHang.Name = "MenuKhachHang";
            this.MenuKhachHang.Size = new System.Drawing.Size(137, 22);
            this.MenuKhachHang.Text = "Khách hàng";
            this.MenuKhachHang.Click += new System.EventHandler(this.MenuKhachHang_Click);
            // 
            // MenuHangHoa
            // 
            this.MenuHangHoa.Name = "MenuHangHoa";
            this.MenuHangHoa.Size = new System.Drawing.Size(137, 22);
            this.MenuHangHoa.Text = "Hàng hóa";
            this.MenuHangHoa.Click += new System.EventHandler(this.MenuHangHoa_Click);
            // 
            // MenuHoaDon
            // 
            this.MenuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHoaDonBan});
            this.MenuHoaDon.Name = "MenuHoaDon";
            this.MenuHoaDon.Size = new System.Drawing.Size(65, 20);
            this.MenuHoaDon.Text = "Hóa đơn";
            // 
            // MenuHoaDonBan
            // 
            this.MenuHoaDonBan.Name = "MenuHoaDonBan";
            this.MenuHoaDonBan.Size = new System.Drawing.Size(143, 22);
            this.MenuHoaDonBan.Text = "Hóa đơn bán";
            this.MenuHoaDonBan.Click += new System.EventHandler(this.MenuHoaDonBan_Click);
            // 
            // MenuBaoCao
            // 
            this.MenuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBaoCaoDoanhThu});
            this.MenuBaoCao.Name = "MenuBaoCao";
            this.MenuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.MenuBaoCao.Text = "Báo cáo";
            // 
            // MenuBaoCaoDoanhThu
            // 
            this.MenuBaoCaoDoanhThu.Name = "MenuBaoCaoDoanhThu";
            this.MenuBaoCaoDoanhThu.Size = new System.Drawing.Size(165, 22);
            this.MenuBaoCaoDoanhThu.Text = "Báo cáo Hóa đơn";
            this.MenuBaoCaoDoanhThu.Click += new System.EventHandler(this.MenuBaoCaoDoanhThu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BTL_QuanLyBanHang.Properties.Resources.BackgroundShoes;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng bán giày";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTapTin;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.ToolStripMenuItem MenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem MenuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem MenuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem MenuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem MenuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem MenuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem MenuHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem MenuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem MenuBaoCaoDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

