
namespace BTL_QuanLyBanHang
{
    partial class FormDMHangHoa
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbMaChatLieu = new System.Windows.Forms.ComboBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lbDonGiaban = new System.Windows.Forms.Label();
            this.lbDonGiaNhap = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.GridViewHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnBoQua);
            this.panelBottom.Controls.Add(this.btnLuu);
            this.panelBottom.Controls.Add(this.btnSua);
            this.panelBottom.Controls.Add(this.btnXoa);
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 396);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 54);
            this.panelBottom.TabIndex = 0;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(571, 19);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(430, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(271, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(140, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtGhiChu);
            this.panelTop.Controls.Add(this.lbGhiChu);
            this.panelTop.Controls.Add(this.txtDonGiaBan);
            this.panelTop.Controls.Add(this.txtDonGiaNhap);
            this.panelTop.Controls.Add(this.txtSoLuong);
            this.panelTop.Controls.Add(this.cbMaChatLieu);
            this.panelTop.Controls.Add(this.txtTenHang);
            this.panelTop.Controls.Add(this.txtMaHang);
            this.panelTop.Controls.Add(this.lbDonGiaban);
            this.panelTop.Controls.Add(this.lbDonGiaNhap);
            this.panelTop.Controls.Add(this.lbSoLuong);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.lbTenHang);
            this.panelTop.Controls.Add(this.lbMaHang);
            this.panelTop.Controls.Add(this.lbTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 189);
            this.panelTop.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(304, 97);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(191, 78);
            this.txtGhiChu.TabIndex = 14;
            this.txtGhiChu.Text = "";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(301, 81);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(45, 13);
            this.lbGhiChu.TabIndex = 13;
            this.lbGhiChu.Text = "Ghi Chú";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(635, 75);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(142, 20);
            this.txtDonGiaBan.TabIndex = 12;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(635, 44);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(142, 20);
            this.txtDonGiaNhap.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(346, 44);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(142, 20);
            this.txtSoLuong.TabIndex = 10;
            // 
            // cbMaChatLieu
            // 
            this.cbMaChatLieu.FormattingEnabled = true;
            this.cbMaChatLieu.Items.AddRange(new object[] {
            "Sắt",
            "Vải",
            "Nhựa",
            "Giấy",
            "Bông",
            "Vàng"});
            this.cbMaChatLieu.Location = new System.Drawing.Point(83, 102);
            this.cbMaChatLieu.Name = "cbMaChatLieu";
            this.cbMaChatLieu.Size = new System.Drawing.Size(121, 21);
            this.cbMaChatLieu.TabIndex = 9;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(83, 75);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(142, 20);
            this.txtTenHang.TabIndex = 8;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(83, 41);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(142, 20);
            this.txtMaHang.TabIndex = 7;
            // 
            // lbDonGiaban
            // 
            this.lbDonGiaban.AutoSize = true;
            this.lbDonGiaban.Location = new System.Drawing.Point(558, 78);
            this.lbDonGiaban.Name = "lbDonGiaban";
            this.lbDonGiaban.Size = new System.Drawing.Size(65, 13);
            this.lbDonGiaban.TabIndex = 6;
            this.lbDonGiaban.Text = "Đơn giá bán";
            // 
            // lbDonGiaNhap
            // 
            this.lbDonGiaNhap.AutoSize = true;
            this.lbDonGiaNhap.Location = new System.Drawing.Point(558, 47);
            this.lbDonGiaNhap.Name = "lbDonGiaNhap";
            this.lbDonGiaNhap.Size = new System.Drawing.Size(71, 13);
            this.lbDonGiaNhap.TabIndex = 5;
            this.lbDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(297, 47);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbSoLuong.TabIndex = 4;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã chất liệu";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(13, 75);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(55, 13);
            this.lbTenHang.TabIndex = 2;
            this.lbTenHang.Text = "Tên Hàng";
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Location = new System.Drawing.Point(17, 44);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(51, 13);
            this.lbMaHang.TabIndex = 1;
            this.lbMaHang.Text = "Mã Hàng";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(300, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(188, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Danh mục Hàng Hóa";
            // 
            // GridViewHang
            // 
            this.GridViewHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewHang.Location = new System.Drawing.Point(0, 0);
            this.GridViewHang.Name = "GridViewHang";
            this.GridViewHang.Size = new System.Drawing.Size(800, 207);
            this.GridViewHang.TabIndex = 2;
            this.GridViewHang.Click += new System.EventHandler(this.GridViewHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridViewHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 207);
            this.panel1.TabIndex = 2;
            // 
            // FormDMHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormDMHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.FormDMHangHoa_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbMaChatLieu;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lbDonGiaban;
        private System.Windows.Forms.Label lbDonGiaNhap;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView GridViewHang;
        private System.Windows.Forms.Panel panel1;
    }
}