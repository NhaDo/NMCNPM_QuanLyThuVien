using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuMuonTra
{
    public partial class QLPhieuMuonTra_view : UserControl
    {
        public QLPhieuMuonTra_view()
        {
            InitializeComponent();
        }
        private void clear_view_components()
        {
            lapPhieuMuonTra_view1.Visible = false;
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapPhieuMuonTra_view1.Visible = true;
            lapPhieuMuonTra_view1.Location = new Point(0, 0);
            lapPhieuMuonTra_view1.BringToFront();
        }
    }
}
