using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Do_an
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }

        private void ucDangNhap_Load(object sender, EventArgs e)
        {

        }
       
        private void btnDN_Click(object sender, EventArgs e)
        {
            kiemTraDangNhap();
        }

        private void kiemTraDangNhap()
        {
            if (txtTenDN.Text == "")
            {
                lblThongBao.Text = "Bạn chưa nhập tài khoản";
                txtTenDN.Focus();
                return;
            }

            if (txtMK.Text == "")
            {
                lblThongBao.Text = "Bạn chưa nhập mật khẩu";
                txtMK.Focus();
                return;
            }

            if (NhanVienBUS.kiemTraDangNhap(txtTenDN.Text, txtMK.Text))
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv = NhanVienBUS.layThongTinNV(txtTenDN.Text);

                this.Visible = false;

            }
            else
            {
                lblThongBao.Text = "Lỗi nhập tài khoản hoặc mật khẩu";
                txtMK.Focus();
                return;
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucDangNhap_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                kiemTraDangNhap();
                e.SuppressKeyPress = true;
            }
        }
    }
}
