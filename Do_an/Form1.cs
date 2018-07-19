using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UserControl uc = new ucDangNhap();
            //uc.Show();

            if(Program.kiemTraDangNhap())
            {
                gbQuanLy.Visible = true;
                gbNguoiDung.Visible = true;
            }
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            Form frm = new frmQLSanPham();
            frm.ShowDialog();
        }
 
    }
}
