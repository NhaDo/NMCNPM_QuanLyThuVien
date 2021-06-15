using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLyThuVien.HomeViewComponents
{
    public partial class QuanLyQuyDinh_view : UserControl
    {
        public QuanLyQuyDinh_view()
        {
            InitializeComponent();
            clear_view_components();
        }
        private void clear_view_components()
        {
            quyDinh1_view1.Visible = false;
            quyDinh2_view1.Visible = false;
            quyDinh3_view1.Visible = false;

        }
        private void quydinh1_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            quyDinh1_view1.Visible = true;
            quyDinh1_view1.BringToFront();
        }

        private void quydinh2_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            quyDinh2_view1.Visible = true;
            quyDinh2_view1.BringToFront();
        }

        private void quydinh3_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            quyDinh3_view1.Visible = true;
            quyDinh3_view1.BringToFront();
        }
    }
}
