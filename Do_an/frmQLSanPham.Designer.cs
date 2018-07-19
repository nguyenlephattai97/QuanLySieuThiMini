namespace Do_an
{
    partial class frmQLSanPham
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBiAn = new System.Windows.Forms.Label();
            this.lblHoatDong = new System.Windows.Forms.Label();
            this.cbbTKLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTGLoai = new System.Windows.Forms.ComboBox();
            this.txtTGLonHon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTGNhoHon = new System.Windows.Forms.TextBox();
            this.btnTimTheoGia = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1156, 481);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(156, 48);
            this.btnDong.TabIndex = 67;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1128, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 48);
            this.btnThem.TabIndex = 64;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLoaiSP);
            this.groupBox2.Controls.Add(this.lvSanPham);
            this.groupBox2.Controls.Add(this.lblBiAn);
            this.groupBox2.Controls.Add(this.lblHoatDong);
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1085, 378);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(857, 24);
            this.cbLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(195, 24);
            this.cbLoaiSP.TabIndex = 78;
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.Location = new System.Drawing.Point(23, 60);
            this.lvSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(1029, 298);
            this.lvSanPham.SmallImageList = this.imageList1;
            this.lvSanPham.StateImageList = this.imageList2;
            this.lvSanPham.TabIndex = 73;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            this.lvSanPham.SelectedIndexChanged += new System.EventHandler(this.lvSanPham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hình";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 237;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HSD";
            this.columnHeader3.Width = 252;
            // 
            // lblBiAn
            // 
            this.lblBiAn.AutoSize = true;
            this.lblBiAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiAn.ForeColor = System.Drawing.Color.Red;
            this.lblBiAn.Location = new System.Drawing.Point(141, 36);
            this.lblBiAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBiAn.Name = "lblBiAn";
            this.lblBiAn.Size = new System.Drawing.Size(40, 17);
            this.lblBiAn.TabIndex = 76;
            this.lblBiAn.Text = "Bị ẩn";
            this.lblBiAn.Click += new System.EventHandler(this.lblBiAn_Click);
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.AutoSize = true;
            this.lblHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoatDong.ForeColor = System.Drawing.Color.Green;
            this.lblHoatDong.Location = new System.Drawing.Point(19, 36);
            this.lblHoatDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(74, 17);
            this.lblHoatDong.TabIndex = 77;
            this.lblHoatDong.Text = "Hoạt động";
            this.lblHoatDong.Click += new System.EventHandler(this.lblHoatDong_Click);
            // 
            // cbbTKLoaiSP
            // 
            this.cbbTKLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTKLoaiSP.FormattingEnabled = true;
            this.cbbTKLoaiSP.Location = new System.Drawing.Point(547, 44);
            this.cbbTKLoaiSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTKLoaiSP.Name = "cbbTKLoaiSP";
            this.cbbTKLoaiSP.Size = new System.Drawing.Size(173, 28);
            this.cbbTKLoaiSP.TabIndex = 79;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(758, 44);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 30);
            this.btnTim.TabIndex = 78;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.Location = new System.Drawing.Point(171, 46);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(336, 26);
            this.txtTuKhoa.TabIndex = 77;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimTheoGia);
            this.groupBox1.Controls.Add(this.txtTGNhoHon);
            this.groupBox1.Controls.Add(this.txtTGLonHon);
            this.groupBox1.Controls.Add(this.cbbTGLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1106, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(206, 378);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớn hơn";
            // 
            // cbbTGLoai
            // 
            this.cbbTGLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTGLoai.FormattingEnabled = true;
            this.cbbTGLoai.Location = new System.Drawing.Point(21, 60);
            this.cbbTGLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTGLoai.Name = "cbbTGLoai";
            this.cbbTGLoai.Size = new System.Drawing.Size(165, 28);
            this.cbbTGLoai.TabIndex = 80;
            // 
            // txtTGLonHon
            // 
            this.txtTGLonHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGLonHon.Location = new System.Drawing.Point(20, 154);
            this.txtTGLonHon.Name = "txtTGLonHon";
            this.txtTGLonHon.Size = new System.Drawing.Size(165, 26);
            this.txtTGLonHon.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhỏ hơn";
            // 
            // txtTGNhoHon
            // 
            this.txtTGNhoHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGNhoHon.Location = new System.Drawing.Point(21, 242);
            this.txtTGNhoHon.Name = "txtTGNhoHon";
            this.txtTGNhoHon.Size = new System.Drawing.Size(165, 26);
            this.txtTGNhoHon.TabIndex = 81;
            // 
            // btnTimTheoGia
            // 
            this.btnTimTheoGia.Location = new System.Drawing.Point(39, 308);
            this.btnTimTheoGia.Name = "btnTimTheoGia";
            this.btnTimTheoGia.Size = new System.Drawing.Size(111, 31);
            this.btnTimTheoGia.TabIndex = 82;
            this.btnTimTheoGia.Text = "Tìm kiếm";
            this.btnTimTheoGia.UseVisualStyleBackColor = true;
            this.btnTimTheoGia.Click += new System.EventHandler(this.btnTimTheoGia_Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTKLoaiSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLSanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblBiAn;
        private System.Windows.Forms.Label lblHoatDong;
        private System.Windows.Forms.ComboBox cbbTKLoaiSP;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimTheoGia;
        private System.Windows.Forms.TextBox txtTGNhoHon;
        private System.Windows.Forms.TextBox txtTGLonHon;
        private System.Windows.Forms.ComboBox cbbTGLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}