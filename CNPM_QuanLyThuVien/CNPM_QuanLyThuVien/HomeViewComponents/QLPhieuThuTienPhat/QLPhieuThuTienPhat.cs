using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuThuTienPhat
{
    public partial class QLPhieuThuTienPhat_view : UserControl
    {
        public QLPhieuThuTienPhat_view()
        {
            InitializeComponent();
            connectsql.OpenConnection();
            dgv_phieuphat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phieuphat.DataSource = connectsql.GetDataTable("select MaPhieuThu as 'Mã phiếu', MaDocGia as 'Mã độc giả', SoTienThu as 'Số tiền thu', ConLai as 'Còn nợ' from PHIEUTHU;");
        }

        private void clear_view_components()
        {
            lapPhieuThuTienPhat_view1.Visible = false;
            suaPhieuThuTienPhat_view1.Visible = false;
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            lapPhieuThuTienPhat_view1.Visible = true;
            lapPhieuThuTienPhat_view1.Location = new Point(0, 0);
            lapPhieuThuTienPhat_view1.BringToFront();
        }

        private void sua_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            suaPhieuThuTienPhat_view1.Visible = true;
            suaPhieuThuTienPhat_view1.Location = new Point(0, 0);
            suaPhieuThuTienPhat_view1.BringToFront();
        }

        private void tracuusach_label_Click(object sender, EventArgs e)
        {

        }

        private void QLPhieuThuTienPhat_view_Load(object sender, EventArgs e)
        {

        }

        private void dgv_phieuphat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
