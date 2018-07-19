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
    public partial class frmQLDanhMuc : Form
    {
        public frmQLDanhMuc()
        {
            InitializeComponent();
        }

        private void frmQLDanhMuc_Load(object sender, EventArgs e)
        {
            List<LoaiSPDTO> lstLSP = LoaiSPBUS.layDanhSachLoaiSP(1);
            for (int i = 0; i < lstLSP.Count; i++)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = lstLSP[i].Ten.ToString();
                lst.SubItems.Add(lstLSP[i].TThai.ToString());
                lst.Tag = lstLSP[i];
                lvLoaiSP.Items.Add(lst);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemLoaiSP();
            frm.ShowDialog();
        }

        private void lvLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLoaiSP.SelectedItems.Count > 0)
            {
                ListViewItem lt = lvLoaiSP.SelectedItems[0];
                LoaiSPDTO lsp = (LoaiSPDTO)lt.Tag;
                Form frm = new frmThemLoaiSP(lsp);
                frm.ShowDialog();

            }      
        }
    }
}
