namespace Do_an
{
    partial class frmQLDanhMuc
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
            this.lvLoaiSP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLoaiSP
            // 
            this.lvLoaiSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvLoaiSP.Location = new System.Drawing.Point(39, 80);
            this.lvLoaiSP.Name = "lvLoaiSP";
            this.lvLoaiSP.Size = new System.Drawing.Size(437, 209);
            this.lvLoaiSP.TabIndex = 0;
            this.lvLoaiSP.UseCompatibleStateImageBehavior = false;
            this.lvLoaiSP.View = System.Windows.Forms.View.Details;
            this.lvLoaiSP.SelectedIndexChanged += new System.EventHandler(this.lvLoaiSP_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên danh mục";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trạng thái";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(377, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 39);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(377, 312);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(99, 39);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmQLDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvLoaiSP);
            this.Name = "frmQLDanhMuc";
            this.Text = "frmQLDanhMuc";
            this.Load += new System.EventHandler(this.frmQLDanhMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLoaiSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}