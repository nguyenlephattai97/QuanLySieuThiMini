namespace Do_an
{
    partial class ucDangNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblDX = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(37, 100);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 10;
            // 
            // lblDX
            // 
            this.lblDX.AutoSize = true;
            this.lblDX.Location = new System.Drawing.Point(31, 66);
            this.lblDX.Name = "lblDX";
            this.lblDX.Size = new System.Drawing.Size(52, 13);
            this.lblDX.TabIndex = 11;
            this.lblDX.Text = "Mật khẩu";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.Location = new System.Drawing.Point(31, 26);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(55, 13);
            this.lblDN.TabIndex = 12;
            this.lblDN.Text = "Tài khoản";
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(40, 120);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(105, 39);
            this.btnDN.TabIndex = 9;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(133, 59);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(182, 23);
            this.txtMK.TabIndex = 5;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyUp);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDN.Location = new System.Drawing.Point(133, 21);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(182, 23);
            this.txtTenDN.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nhập lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblDX);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(350, 176);
            this.Load += new System.EventHandler(this.ucDangNhap_Load);
            this.VisibleChanged += new System.EventHandler(this.ucDangNhap_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblDX;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button button1;
    }
}
