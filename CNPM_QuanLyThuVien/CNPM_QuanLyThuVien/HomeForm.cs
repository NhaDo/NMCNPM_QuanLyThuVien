using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void clear_view_components()
        {
            quanLyTheDocGia_view1.Visible = false;
            quanLyPhieuNhapSach1.Visible = false;
            qlPhieuMuonTra_view1.Visible = false;
            qlSach_view1.Visible = false;
            qlPhieuThuTienPhat_view1.Visible = false;


        }
        private void QLthedocgia_btn_Click(object sender, EventArgs e)

        {
            clear_view_components();
            quanLyTheDocGia_view1.Visible = true;
            quanLyTheDocGia_view1.BringToFront();

        }

        private void QLphieunhapsach_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            quanLyPhieuNhapSach1.Visible = true;
            quanLyPhieuNhapSach1.BringToFront();
        }

        private void QLsach_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            qlSach_view1.Visible = true;
            qlSach_view1.BringToFront();
        }

        private void QLphieumuontra_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            qlPhieuMuonTra_view1.Visible = true;
            qlPhieuMuonTra_view1.BringToFront();
        }

        private void QLphieuthutienphat_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            qlPhieuThuTienPhat_view1.Visible = true;
            qlPhieuThuTienPhat_view1.BringToFront();
        }
    }
}
