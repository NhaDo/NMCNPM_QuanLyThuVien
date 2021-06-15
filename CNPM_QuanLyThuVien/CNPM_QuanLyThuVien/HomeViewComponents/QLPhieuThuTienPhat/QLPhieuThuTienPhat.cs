using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuThuTienPhat
{
    public partial class QLPhieuThuTienPhat_view : UserControl
    {
        public QLPhieuThuTienPhat_view()
        {
            InitializeComponent();
        }

        private void clear_view_components()
        {
            lapPhieuThuTienPhat_view1.Visible = false;
            suaPhieuThuTienPhat_view1.Visible = false;
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapPhieuThuTienPhat_view1.Visible = true;
            lapPhieuThuTienPhat_view1.Location = new Point(0, 0);
            lapPhieuThuTienPhat_view1.BringToFront();
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            suaPhieuThuTienPhat_view1.Visible = true;
            suaPhieuThuTienPhat_view1.Location = new Point(0, 0);
            suaPhieuThuTienPhat_view1.BringToFront();
        }
    }
}
