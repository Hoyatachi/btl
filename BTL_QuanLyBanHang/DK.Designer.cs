
namespace BTL_QuanLyBanHang
{
    partial class DK
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
            this.components = new System.ComponentModel.Container();
            this.lbDangKy = new System.Windows.Forms.Label();
            this.lbTenDK = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbXNMatKhau = new System.Windows.Forms.Label();
            this.txtDangKy = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDangKy
            // 
            this.lbDangKy.AutoSize = true;
            this.lbDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangKy.Location = new System.Drawing.Point(157, 22);
            this.lbDangKy.Name = "lbDangKy";
            this.lbDangKy.Size = new System.Drawing.Size(81, 24);
            this.lbDangKy.TabIndex = 0;
            this.lbDangKy.Text = "Đăng Ký";
            // 
            // lbTenDK
            // 
            this.lbTenDK.AutoSize = true;
            this.lbTenDK.Location = new System.Drawing.Point(37, 68);
            this.lbTenDK.Name = "lbTenDK";
            this.lbTenDK.Size = new System.Drawing.Size(84, 13);
            this.lbTenDK.TabIndex = 1;
            this.lbTenDK.Text = "Tên Đăng Nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(40, 107);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbXNMatKhau
            // 
            this.lbXNMatKhau.AutoSize = true;
            this.lbXNMatKhau.Location = new System.Drawing.Point(40, 142);
            this.lbXNMatKhau.Name = "lbXNMatKhau";
            this.lbXNMatKhau.Size = new System.Drawing.Size(100, 13);
            this.lbXNMatKhau.TabIndex = 3;
            this.lbXNMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtDangKy
            // 
            this.txtDangKy.Location = new System.Drawing.Point(175, 68);
            this.txtDangKy.Name = "txtDangKy";
            this.txtDangKy.Size = new System.Drawing.Size(185, 20);
            this.txtDangKy.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(175, 104);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(185, 20);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Location = new System.Drawing.Point(175, 139);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(185, 20);
            this.txtXacNhanMK.TabIndex = 6;
            this.txtXacNhanMK.TextChanged += new System.EventHandler(this.txtXacNhanMK_TextChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(109, 193);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(248, 193);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(74, 23);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 247);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangKy);
            this.Controls.Add(this.lbXNMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDK);
            this.Controls.Add(this.lbDangKy);
            this.Name = "DK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.Label lbTenDK;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbXNMatKhau;
        private System.Windows.Forms.TextBox txtDangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}