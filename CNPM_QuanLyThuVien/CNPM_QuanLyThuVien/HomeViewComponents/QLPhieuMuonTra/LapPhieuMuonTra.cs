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
    public partial class LapPhieuMuonTra_view : UserControl
    {
        public LapPhieuMuonTra_view()
        {
            InitializeComponent();
        }
        private void clear_view_components()
        {
            phieuMuon_view1.Visible = false;
            phieuTra_view1.Visible = false;
        }

            private void phieumuon_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            phieuMuon_view1.Visible = true;
            phieuMuon_view1.BringToFront();
        }

        private void phieutra_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            phieuTra_view1.Visible = true;
            phieuTra_view1.BringToFront();
        }
    }
}
