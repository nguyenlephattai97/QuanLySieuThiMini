namespace Do_an
{
    partial class frmLoaiSP
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
            this.radAn = new System.Windows.Forms.RadioButton();
            this.radHien = new System.Windows.Forms.RadioButton();
            this.lblTThai = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radAn
            // 
            this.radAn.AutoSize = true;
            this.radAn.Location = new System.Drawing.Point(239, 173);
            this.radAn.Name = "radAn";
            this.radAn.Size = new System.Drawing.Size(38, 17);
            this.radAn.TabIndex = 34;
            this.radAn.TabStop = true;
            this.radAn.Text = "Ẩn";
            this.radAn.UseVisualStyleBackColor = true;
            // 
            // radHien
            // 
            this.radHien.AutoSize = true;
            this.radHien.Location = new System.Drawing.Point(153, 173);
            this.radHien.Name = "radHien";
            this.radHien.Size = new System.Drawing.Size(47, 17);
            this.radHien.TabIndex = 35;
            this.radHien.TabStop = true;
            this.radHien.Text = "Hiện";
            this.radHien.UseVisualStyleBackColor = true;
            // 
            // lblTThai
            // 
            this.lblTThai.AutoSize = true;
            this.lblTThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTThai.Location = new System.Drawing.Point(50, 173);
            this.lblTThai.Name = "lblTThai";
            this.lblTThai.Size = new System.Drawing.Size(73, 17);
            this.lblTThai.TabIndex = 33;
            this.lblTThai.Text = "Trạng thái";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(-185, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(99, 17);
            this.lblTen.TabIndex = 32;
            this.lblTen.Text = "Tên sản phẩm";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(153, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(238, 26);
            this.txtTen.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 246);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 41);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(160, 246);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 41);
            this.btnLamMoi.TabIndex = 37;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(295, 246);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 41);
            this.btnDong.TabIndex = 37;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 345);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radAn);
            this.Controls.Add(this.radHien);
            this.Controls.Add(this.lblTThai);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Name = "frmLoaiSP";
            this.Text = "frmLoaiSP";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radAn;
        private System.Windows.Forms.RadioButton radHien;
        private System.Windows.Forms.Label lblTThai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;

    }
}