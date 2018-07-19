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
    public partial class frmThemLoaiSP : Form
    {
        private LoaiSPDTO _lsp = null;
        public frmThemLoaiSP()
        {
            
            InitializeComponent();
        }
        public frmThemLoaiSP(LoaiSPDTO lsp)
        {
            
            _lsp = lsp;
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
            MessageBox.Show("Thêm danh mục sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmThemLoaiSP_Load(object sender, EventArgs e)
        {
            if (_lsp != null)
            {
                txtTen.Text = _lsp.Ten;
              
                if (_lsp.TThai == 1)
                {
                    radHien.Checked = true;
                }
                if (_lsp.TThai == 0)
                {
                    radAn.Checked = true;
                }

                btnThem.Visible = false;
                btnSua.Visible = true;
                this.Text = "Sửa loại sản phẩm";
            }
            btnThem.Visible = true;
            btnSua.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTen.Text=="")
            {
                MessageBox.Show("Chưa nhập tên loại sản phẩm");
                return;
            }

            //kiem tra trang thai

            _lsp.Ten = txtTen.Text;
            _lsp.TThai = 1;
            if (radAn.Checked)
            {
                _lsp.TThai = 0;
            }

            if(LoaiSPBUS.suaLoaiSP(_lsp))
            {
                MessageBox.Show("Sửa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";

        }
    }
}
