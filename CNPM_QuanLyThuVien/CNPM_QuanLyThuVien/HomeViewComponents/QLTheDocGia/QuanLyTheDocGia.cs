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
    public partial class QuanLyTheDocGia_view : UserControl
    {
        public QuanLyTheDocGia_view()
        {
            InitializeComponent();
        }


        private void clear_view_components()
        {
            lapTheDocGia_view1.Visible = false;
            suaTheDocGia_view1.Visible = false;
        }
        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapTheDocGia_view1.Visible = true;
            lapTheDocGia_view1.Location = new Point(0, 0);
            lapTheDocGia_view1.BringToFront();
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            suaTheDocGia_view1.Visible = true;
            suaTheDocGia_view1.Location = new Point(0, 0);
            suaTheDocGia_view1.BringToFront();
        }
    }
}
