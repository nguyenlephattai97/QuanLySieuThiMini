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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiSPDTO lsp = new LoaiSPDTO();
            lsp.Ten = txtTen.Text;
            lsp.TThai = 1;
            if (radAn.Checked)
            {
                lsp.TThai = 0;
            }

         LoaiSPBUS.themLoaiSP(lsp);

        
            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {

        }
    }
}
