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
    public partial class LapTheDocGia_view : UserControl
    {
        public LapTheDocGia_view()
        {
            InitializeComponent();
        }

        private void madocgia_label_Click(object sender, EventArgs e)
        {

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
