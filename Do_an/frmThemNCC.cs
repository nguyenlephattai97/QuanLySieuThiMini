using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Do_an
{
    public partial class frmThemNCC : Form
    {
        public frmThemNCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO ncc = new NhaCungCapDTO();
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.DienThoai = txtSDT.Text;
            ncc.TThai = 1;
            if (radAn.Checked)
            {
                ncc.TThai = 0;
            }
            if (NhaCungCapBUS.themNCC(ncc))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void frmThemNCC_Load(object sender, EventArgs e)
        {
            btnSua.Visible = false;
        }
    }
}
