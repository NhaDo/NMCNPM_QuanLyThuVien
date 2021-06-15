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
    public partial class SuaPhieuThuTienPhat_view : UserControl
    {
        public SuaPhieuThuTienPhat_view()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }
    }
}
