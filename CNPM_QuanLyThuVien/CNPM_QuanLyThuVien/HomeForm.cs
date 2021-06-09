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
            lapPhieuMuonTra_view1.Visible = false;
            lapPhieuNhapSach_view1.Visible = false;
            lapPhieuMuonTra_view1.Visible = false;
            traCuuSach_view1.Visible = false;
            lapPhieuThuTienPhat_view1.Visible = false;
            quanLyQuyDinh_view1.Visible = false;

        }

        private void lapthedocgia_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapTheDocGia_view1.Visible = true;
            lapTheDocGia_view1.BringToFront();
        }

        private void lapphieunhapsach_btn_Click(object sender, EventArgs e)
        
        {
            clear_view_components();
            lapPhieuNhapSach_view1.Visible = true;
            lapPhieuNhapSach_view1.BringToFront();
        }

        private void lapphieumuontra_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();

            lapPhieuMuonTra_view1.Visible = true;
            lapPhieuMuonTra_view1.BringToFront();
        }

        private void tracuusach_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();

            traCuuSach_view1.Visible = true;
            traCuuSach_view1.BringToFront();
        }

        private void lapphieuthutienphat_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapPhieuThuTienPhat_view1.Visible = true;
            lapPhieuThuTienPhat_view1.BringToFront();
        }

        private void quanlyquydinh_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            quanLyQuyDinh_view1.Visible = true;
            quanLyQuyDinh_view1.BringToFront();
        }

        private void lapbaocao_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapBaoCao_view1.Visible = true;
            lapBaoCao_view1.BringToFront();

        }
    }
}
