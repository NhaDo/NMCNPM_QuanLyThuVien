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
    public partial class ThongKeSachTraTre_view : UserControl
    {
        public ThongKeSachTraTre_view()
        {
            InitializeComponent();
            InitializeComponent();
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void tracuusach_label_Click(object sender, EventArgs e)
        {

        }
    }
}
