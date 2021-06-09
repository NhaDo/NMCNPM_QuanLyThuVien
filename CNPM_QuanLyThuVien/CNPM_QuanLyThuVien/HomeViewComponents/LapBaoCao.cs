using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao
{
    public partial class LapBaoCao_view : UserControl
    {
        public LapBaoCao_view()
        {
            InitializeComponent();
            clear_view_components();
        }
        private void clear_view_components()
        {
            baoCaoTheoTheLoai_view1.Visible = false;
            thongKeSachTraTre_view1.Visible = false;
        }

        private void tktratre_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            thongKeSachTraTre_view1.Visible = true;
            thongKeSachTraTre_view1.BringToFront();
        }

        private void bctheloai_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            baoCaoTheoTheLoai_view1.Visible = true;
            baoCaoTheoTheLoai_view1.BringToFront();
        }
    }
}
