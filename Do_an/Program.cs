using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Do_an
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static NhanVienDTO nv { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          
            Application.Run(new frmQLSanPham());
        }

        public static bool kiemTraDangNhap()
        {
            return (nv != null);
        }
    }
}
