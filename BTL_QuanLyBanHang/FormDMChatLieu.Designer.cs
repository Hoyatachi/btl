
namespace BTL_QuanLyBanHang
{
    partial class FormDMChatLieu
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
            this.PanelButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbTitleChatLieu = new System.Windows.Forms.Label();
            this.lbMaChatLieu = new System.Windows.Forms.Label();
            this.lbTenChatLieu = new System.Windows.Forms.Label();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.GridViewChatLieu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelButton.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChatLieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelButton
            // 
            this.PanelButton.Controls.Add(this.btnClose);
            this.PanelButton.Controls.Add(this.btnBoQua);
            this.PanelButton.Controls.Add(this.BtnLuu);
            this.PanelButton.Controls.Add(this.btnSua);
            this.PanelButton.Controls.Add(this.btnXoa);
            this.PanelButton.Controls.Add(this.btnThem);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButton.Location = new System.Drawing.Point(0, 396);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(800, 54);
            this.PanelButton.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(681, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(528, 15);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Location = new System.Drawing.Point(400, 15);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(75, 23);
            this.BtnLuu.TabIndex = 3;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(275, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(147, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTitleChatLieu
            // 
            this.lbTitleChatLieu.AutoSize = true;
            this.lbTitleChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChatLieu.Location = new System.Drawing.Point(288, 9);
            this.lbTitleChatLieu.Name = "lbTitleChatLieu";
            this.lbTitleChatLieu.Size = new System.Drawing.Size(213, 24);
            this.lbTitleChatLieu.TabIndex = 6;
            this.lbTitleChatLieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // lbMaChatLieu
            // 
            this.lbMaChatLieu.AutoSize = true;
            this.lbMaChatLieu.Location = new System.Drawing.Point(21, 77);
            this.lbMaChatLieu.Name = "lbMaChatLieu";
            this.lbMaChatLieu.Size = new System.Drawing.Size(70, 13);
            this.lbMaChatLieu.TabIndex = 7;
            this.lbMaChatLieu.Text = "Mã Chất Liệu";
            // 
            // lbTenChatLieu
            // 
            this.lbTenChatLieu.AutoSize = true;
            this.lbTenChatLieu.Location = new System.Drawing.Point(17, 120);
            this.lbTenChatLieu.Name = "lbTenChatLieu";
            this.lbTenChatLieu.Size = new System.Drawing.Size(74, 13);
            this.lbTenChatLieu.TabIndex = 8;
            this.lbTenChatLieu.Text = "Tên Chất Liệu";
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(97, 120);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(205, 20);
            this.txtTenChatLieu.TabIndex = 9;
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(97, 74);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(205, 20);
            this.txtMaChatLieu.TabIndex = 10;
            this.txtMaChatLieu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaChatLieu_KeyUp);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbTitleChatLieu);
            this.panelTop.Controls.Add(this.txtTenChatLieu);
            this.panelTop.Controls.Add(this.txtMaChatLieu);
            this.panelTop.Controls.Add(this.lbTenChatLieu);
            this.panelTop.Controls.Add(this.lbMaChatLieu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 157);
            this.panelTop.TabIndex = 11;
            // 
            // GridViewChatLieu
            // 
            this.GridViewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewChatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewChatLieu.Location = new System.Drawing.Point(0, 0);
            this.GridViewChatLieu.Name = "GridViewChatLieu";
            this.GridViewChatLieu.Size = new System.Drawing.Size(800, 239);
            this.GridViewChatLieu.TabIndex = 12;
            this.GridViewChatLieu.Click += new System.EventHandler(this.GridViewChatLieu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridViewChatLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 239);
            this.panel1.TabIndex = 12;
            // 
            // FormDMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.PanelButton);
            this.Name = "FormDMChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.FormDMChatLieu_Load);
            this.PanelButton.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewChatLieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTitleChatLieu;
        private System.Windows.Forms.Label lbMaChatLieu;
        private System.Windows.Forms.Label lbTenChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView GridViewChatLieu;
        private System.Windows.Forms.Panel panel1;
    }
}