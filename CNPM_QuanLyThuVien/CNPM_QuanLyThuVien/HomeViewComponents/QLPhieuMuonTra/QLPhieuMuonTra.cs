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
            connectsql.OpenConnection();
            dgv_borrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_borrow.DataSource = connectsql.GetDataTable("select MaMuonTra as 'Mã phiếu', MaCuonSach as 'Mã cuốn sách', MaDocGia as 'Mã độc giả', NgayMuon as 'Ngày mượn', NgayTra as 'Ngày trả', TienPhat as 'Tiền phạt', SoTienTra as 'Số tiền trả' from PHIEUMUONTRA;");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
