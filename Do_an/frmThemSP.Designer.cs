namespace Do_an
{
    partial class frmThemSP
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
            this.lblTThai = new System.Windows.Forms.Label();
            this.btnAnh = new System.Windows.Forms.Button();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHSD = new System.Windows.Forms.Label();
            this.labelmota = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radHien = new System.Windows.Forms.RadioButton();
            this.radAn = new System.Windows.Forms.RadioButton();
            this.btnSua = new System.Windows.Forms.Button();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemLSP = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTThai
            // 
            this.lblTThai.AutoSize = true;
            this.lblTThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTThai.Location = new System.Drawing.Point(533, 254);
            this.lblTThai.Name = "lblTThai";
            this.lblTThai.Size = new System.Drawing.Size(73, 17);
            this.lblTThai.TabIndex = 27;
            this.lblTThai.Text = "Trạng thái";
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(603, 208);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(100, 35);
            this.btnAnh.TabIndex = 6;
            this.btnAnh.Text = "Chọn ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(237, 180);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(238, 21);
            this.cbLoaiSP.TabIndex = 3;
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(37, 180);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(57, 17);
            this.lblLoai.TabIndex = 19;
            this.lblLoai.Text = "Loại SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhà CC";
            // 
            // lblHSD
            // 
            this.lblHSD.AutoSize = true;
            this.lblHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSD.Location = new System.Drawing.Point(37, 274);
            this.lblHSD.Name = "lblHSD";
            this.lblHSD.Size = new System.Drawing.Size(37, 17);
            this.lblHSD.TabIndex = 18;
            this.lblHSD.Text = "HSD";
            // 
            // labelmota
            // 
            this.labelmota.AutoSize = true;
            this.labelmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmota.Location = new System.Drawing.Point(37, 84);
            this.labelmota.Name = "labelmota";
            this.labelmota.Size = new System.Drawing.Size(43, 17);
            this.labelmota.TabIndex = 21;
            this.labelmota.Text = "Mô tả";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(37, 142);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(30, 17);
            this.lblGia.TabIndex = 22;
            this.lblGia.Text = "Giá";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(37, 38);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(99, 17);
            this.lblTen.TabIndex = 23;
            this.lblTen.Text = "Tên sản phẩm";
            // 
            // txtHSD
            // 
            this.txtHSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSD.Location = new System.Drawing.Point(237, 268);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(238, 26);
            this.txtHSD.TabIndex = 5;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(237, 78);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(238, 42);
            this.txtMota.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(237, 136);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(238, 26);
            this.txtGia.TabIndex = 2;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(237, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(238, 26);
            this.txtTen.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(570, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(84, 340);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 39);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(281, 340);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(127, 39);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(654, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // radHien
            // 
            this.radHien.AutoSize = true;
            this.radHien.Location = new System.Drawing.Point(536, 277);
            this.radHien.Name = "radHien";
            this.radHien.Size = new System.Drawing.Size(47, 17);
            this.radHien.TabIndex = 7;
            this.radHien.TabStop = true;
            this.radHien.Text = "Hiện";
            this.radHien.UseVisualStyleBackColor = true;
            // 
            // radAn
            // 
            this.radAn.AutoSize = true;
            this.radAn.Location = new System.Drawing.Point(654, 277);
            this.radAn.Name = "radAn";
            this.radAn.Size = new System.Drawing.Size(38, 17);
            this.radAn.TabIndex = 8;
            this.radAn.TabStop = true;
            this.radAn.Text = "Ẩn";
            this.radAn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(84, 340);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 39);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(237, 223);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(238, 21);
            this.cbNCC.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(473, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 39);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add__1_;
            this.btnThemLSP.Location = new System.Drawing.Point(481, 180);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.Size = new System.Drawing.Size(30, 27);
            this.btnThemLSP.TabIndex = 32;
            this.btnThemLSP.UseVisualStyleBackColor = true;
            this.btnThemLSP.Click += new System.EventHandler(this.btnThemLSP_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Image = global::Do_an.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Add__1_;
            this.btnThemNCC.Location = new System.Drawing.Point(481, 223);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(30, 27);
            this.btnThemNCC.TabIndex = 32;
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // frmThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 437);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnThemLSP);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.radAn);
            this.Controls.Add(this.radHien);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTThai);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHSD);
            this.Controls.Add(this.labelmota);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtHSD);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Name = "frmThemSP";
            this.Text = "frmThemSP";
            this.Load += new System.EventHandler(this.frmThemSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTThai;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHSD;
        private System.Windows.Forms.Label labelmota;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radHien;
        private System.Windows.Forms.RadioButton radAn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemLSP;
        private System.Windows.Forms.Button btnThemNCC;
    }
}