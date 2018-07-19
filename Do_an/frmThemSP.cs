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
using System.IO;

namespace Do_an
{
    public partial class frmThemSP : Form
    {
        private SanPhamDTO _sp = null;
        public frmThemSP()
        {
            InitializeComponent();
        }

        public frmThemSP(SanPhamDTO sp)
        {
            _sp = sp;
            InitializeComponent();
        }

        Bitmap LoadImage(string path)
        {
            Bitmap result;
            using (Image img = Image.FromFile(path))
            {
                result = new Bitmap(img);
            }
            return result;
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }



        private void frmThemSP_Load(object sender, EventArgs e)
        {
            List<LoaiSPDTO> lstloaisp = LoaiSPBUS.layDanhSachLoaiSP(1);
            cbLoaiSP.DisplayMember = "Ten";
            cbLoaiSP.ValueMember = "Ma";
            cbLoaiSP.DataSource = lstloaisp;

            List<NhaCungCapDTO> lstNCC = NhaCungCapBUS.layDanhSachNCC(1);
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "Ma";
            cbNCC.DataSource = lstNCC;


            if(_sp != null)
            {
                txtTen.Text = _sp.Ten;
                txtMota.Text = _sp.MoTa;
                txtGia.Text =  _sp.Gia.ToString();
                cbLoaiSP.SelectedValue = _sp.LoaiSP;
                cbNCC.SelectedValue = _sp.NCC;
               
                txtHSD.Text = String.Format("{0:dd/MM/yyyy}", _sp.HSD.ToString());
              
                if (_sp.TThai==1)
                {
                    radHien.Checked = true;
                }
                if (_sp.TThai==0)
                {
                    radAn.Checked = true;
                }

                pictureBox1.Image = LoadImage("images\\"+_sp.Hinh);

                btnThem.Visible = false;
                btnSua.Visible = true;
                this.Text = "Chỉnh sửa sản phẩm";
            }
            else
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }


           
            

            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.Tag = openFileDialog1.FileName;
            pictureBox1.Image = LoadImage(openFileDialog1.FileName);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.Ten = txtTen.Text;
            sp.MoTa = txtMota.Text;
            sp.Gia = Convert.ToInt32(txtGia.Text);
            sp.HSD = txtHSD.Text;
            sp.LoaiSP = Convert.ToInt32(cbLoaiSP.SelectedValue);
            sp.NCC = Convert.ToInt32( cbNCC.SelectedValue);
            sp.Hinh = "";
            sp.TThai = 1;            
            if (radAn.Checked)
            {
                sp.TThai = 0;
            }
            int id = SanPhamBUS.themSanPham(sp);
            if (openFileDialog1.Tag != null)
            {
                string filePath = (string)openFileDialog1.Tag;
                string img = id + Path.GetExtension(filePath);
                File.Copy(filePath, "images\\" + img, true);
                SanPhamBUS.capNhatAnhSP(id, img);
            } 
            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_sp!= null)
            {
                _sp.Ten = txtTen.Text;
                _sp.Gia = Convert.ToInt32(txtGia.Text);
                _sp.MoTa = txtMota.Text;

                _sp.LoaiSP = Convert.ToInt32(cbLoaiSP.SelectedValue);
                _sp.NCC = Convert.ToInt32(cbNCC.SelectedValue);
                _sp.HSD = txtHSD.Text;
                _sp.TThai = 1;

                if (radAn.Checked)
                {
                    _sp.TThai = 0;
                }
                if (openFileDialog1.Tag != null)
                {
                    string filePath = (string)openFileDialog1.Tag;
                    File.Copy(filePath, "images\\" + _sp.Ma.ToString() + Path.GetExtension(filePath), true);
                    _sp.Hinh = _sp.Ma.ToString() + Path.GetExtension(filePath);
                }
                if (SanPhamBUS.suaSanPham(_sp))
                MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
           

         
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtTen.Text = "";
            txtGia.Text = "";
            txtHSD.Text = "";
            txtMota.Text = "";
            cbLoaiSP.SelectedValue = "";
            cbNCC.SelectedValue = "";
            radHien.Checked = false;
            radAn.Checked = false;
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemLoaiSP();
            frm.ShowDialog();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemNCC();
            frm.ShowDialog();
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
