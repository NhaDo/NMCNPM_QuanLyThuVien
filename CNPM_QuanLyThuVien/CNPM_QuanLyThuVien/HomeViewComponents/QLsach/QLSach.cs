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
    public partial class QLSach_view : UserControl
    {
        public QLSach_view()
        {
            InitializeComponent();
            connectsql.OpenConnection();
            dgv_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_book.DataSource = connectsql.GetDataTable("select CS.MaCuonSach as 'Mã cuốn sách', S.TenSach as 'Tên sách', TL.TenTheLoai as 'Thể loại', S.NgayNhap as 'Ngày nhập', S.NhaXuatBan as 'Nhà xuất bản', S.NamXuatBan as 'Năm xuất bản',  S.TriGia as 'Giá trị', CS.TinhTrang as 'Tình Trạng' From CUONSACH CS join Sach S On CS.MaSach = S.MaSach join THELOAI TL on S.MaTheLoai = TL.MaTheLoai;");
        }

        private void clear_view_components()
        {
            suaSach_view1.Visible = false;
            themSach_view1.Visible = false;
        }
        private void sua_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            suaSach_view1.Location = new Point(0, 0);
            suaSach_view1.Visible = true;
            suaSach_view1.BringToFront();
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            clear_view_components();
            themSach_view1.Location = new Point(0, 0);
            themSach_view1.Visible = true;
            themSach_view1.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
