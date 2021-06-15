using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuNhapSach
{
    public partial class QuanLyPhieuNhapSach : UserControl
    {
        public QuanLyPhieuNhapSach()
        {
            InitializeComponent();
        }
        private void clear_view_components()
        {
            suaPhieuNhapSach_view1.Visible = false;
            lapPhieuNhapSach_view1.Visible = false;
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapPhieuNhapSach_view1.Visible = true;
            lapPhieuNhapSach_view1.Location = new Point(0, 0);
            lapPhieuNhapSach_view1.BringToFront();

        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            suaPhieuNhapSach_view1.Visible = true;
            suaPhieuNhapSach_view1.Location = new Point(0, 0);
            suaPhieuNhapSach_view1.BringToFront();

        }
    }
}
