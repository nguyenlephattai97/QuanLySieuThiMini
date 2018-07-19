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
    public partial class frmQLSanPham : Form
    {
        public frmQLSanPham()
        {
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
        private void frmQLSanPham_Load(object sender, EventArgs e)
        {   
            LoadSanPham(SanPhamBUS.layDanhSachSP(1));
                       
            List<LoaiSPDTO> lstloai = LoaiSPBUS.layDanhSachLoaiSP(1);
            cbLoaiSP.Items.Insert(0, "Tất cả");
            cbbTKLoaiSP.Items.Insert(0, "Tất cả");
            cbbTGLoai.Items.Insert(0, "Tất cả");

            cbLoaiSP.SelectedIndex = 0;
            cbbTKLoaiSP.SelectedIndex = 0;
            cbbTGLoai.SelectedIndex = 0;

            for(int i=0;i<lstloai.Count;i++)
            {
                cbLoaiSP.Items.Insert(lstloai[i].Ma, lstloai[i].Ten);
                cbbTKLoaiSP.Items.Insert(lstloai[i].Ma, lstloai[i].Ten);
                cbbTGLoai.Items.Insert(lstloai[i].Ma, lstloai[i].Ten);
            }
                            
        }

        private void LoadSanPham(List<SanPhamDTO> lstSP)
        {
            lvSanPham.Items.Clear();
            for (int i = 0; i < lstSP.Count; i++)
            {
                imageList1.Images.Add(lstSP[i].Hinh, LoadImage("images\\" + lstSP[i].Hinh));

                ListViewItem lst = new ListViewItem();
                lst.Text = "";
                lst.ImageKey = lstSP[i].Hinh;
                lst.SubItems.Add(lstSP[i].Ten.ToString());
                lst.SubItems.Add(lstSP[i].Gia.ToString());
                lst.SubItems.Add(lstSP[i].HSD.ToString());
                lst.Tag = lstSP[i];
                lvSanPham.Items.Add(lst);
            }
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lt = lvSanPham.SelectedItems[0];
                SanPhamDTO sp = (SanPhamDTO)lt.Tag;
                Form frm = new frmThemSP(sp);
                frm.ShowDialog();

            }           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemSP();
            frm.ShowDialog();
            
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            //if(txtTuKhoa.Text !=  "")
            //{
            //    LoadSanPham(SanPhamBUS.timTheoTenVaLoaiSP(txtTuKhoa.Text));
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHoatDong_Click(object sender, EventArgs e)
        {
            LoadSanPham(SanPhamBUS.layDanhSachSP(1));
        }

        private void lblBiAn_Click(object sender, EventArgs e)
        {
            LoadSanPham(SanPhamBUS.layDanhSachSP(0));
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbLoaiSP.SelectedIndex == 0)
           {
               LoadSanPham(SanPhamBUS.layDanhSachSP(1));
           }
           else
           {
               LoadSanPham(SanPhamBUS.laySPTheoLoaiSP(cbLoaiSP.SelectedIndex));
           }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimTheoGia_Click(object sender, EventArgs e)
        {


            int giaTu = txtTGLonHon.Text != "" ? Convert.ToInt32(txtTGLonHon.Text) : 0;
            int giaDen = txtTGNhoHon.Text != "" ? Convert.ToInt32(txtTGNhoHon.Text) : 0;

            LoadSanPham(SanPhamBUS.timTheoGiaSP(giaTu, giaDen, Convert.ToInt32(cbbTGLoai.SelectedIndex)));
        }

 
    }
}
