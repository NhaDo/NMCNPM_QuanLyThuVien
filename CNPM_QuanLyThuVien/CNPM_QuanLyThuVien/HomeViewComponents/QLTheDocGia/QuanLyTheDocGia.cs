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
            connectsql.OpenConnection();
            dgv_docgia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_docgia.DataSource = connectsql.GetDataTable("select DG.MaDocGia as 'Mã Độc Giả', DG.TenDocGia as 'Tên Độc Giả', LDG.TenLoaiDocGia as 'Tên Loại Độc Giả', DG.NgaySinh as 'Ngày Sinh', DG.DiaChi as 'Địa Chỉ', DG.Email, DG.NgayLapThe as 'Ngày Lập Thẻ' From DOCGIA DG inner join LOAIDOCGIA LDG On DG.MaLoaiDocGia = LDG.MaLoaiDocGia;");
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

        private void QuanLyTheDocGia_view_Load(object sender, EventArgs e)
        {

        }
    }
}
