namespace Do_an
{
    partial class frmThemLoaiSP
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radAn = new System.Windows.Forms.RadioButton();
            this.radHien = new System.Windows.Forms.RadioButton();
            this.lblTThai = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(281, 147);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 41);
            this.btnDong.TabIndex = 44;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(149, 147);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(117, 41);
            this.btnLamMoi.TabIndex = 45;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 147);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 41);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tên sản phẩm";
            // 
            // radAn
            // 
            this.radAn.AutoSize = true;
            this.radAn.Location = new System.Drawing.Point(228, 96);
            this.radAn.Name = "radAn";
            this.radAn.Size = new System.Drawing.Size(38, 17);
            this.radAn.TabIndex = 41;
            this.radAn.TabStop = true;
            this.radAn.Text = "Ẩn";
            this.radAn.UseVisualStyleBackColor = true;
            // 
            // radHien
            // 
            this.radHien.AutoSize = true;
            this.radHien.Checked = true;
            this.radHien.Location = new System.Drawing.Point(142, 96);
            this.radHien.Name = "radHien";
            this.radHien.Size = new System.Drawing.Size(47, 17);
            this.radHien.TabIndex = 42;
            this.radHien.TabStop = true;
            this.radHien.Text = "Hiện";
            this.radHien.UseVisualStyleBackColor = true;
            // 
            // lblTThai
            // 
            this.lblTThai.AutoSize = true;
            this.lblTThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTThai.Location = new System.Drawing.Point(39, 96);
            this.lblTThai.Name = "lblTThai";
            this.lblTThai.Size = new System.Drawing.Size(73, 17);
            this.lblTThai.TabIndex = 40;
            this.lblTThai.Text = "Trạng thái";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(142, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(238, 26);
            this.txtTen.TabIndex = 38;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(16, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 41);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmThemLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 211);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radAn);
            this.Controls.Add(this.radHien);
            this.Controls.Add(this.lblTThai);
            this.Controls.Add(this.txtTen);
            this.Name = "frmThemLoaiSP";
            this.Text = "Thêm loại sản phẩm";
            this.Load += new System.EventHandler(this.frmThemLoaiSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radAn;
        private System.Windows.Forms.RadioButton radHien;
        private System.Windows.Forms.Label lblTThai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnSua;
    }
}