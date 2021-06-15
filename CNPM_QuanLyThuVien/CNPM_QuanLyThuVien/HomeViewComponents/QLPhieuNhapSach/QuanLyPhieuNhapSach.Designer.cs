
namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuNhapSach
{
    partial class QuanLyPhieuNhapSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.them_btn = new System.Windows.Forms.Button();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.QLthedocgia_label = new System.Windows.Forms.Label();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lapPhieuNhapSach_view1 = new CNPM_QuanLyThuVien.LapPhieuNhapSach_view();
            this.suaPhieuNhapSach_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuNhapSach.SuaPhieuNhapSach_view();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.theloai,
            this.nhaxuatban,
            this.trigia,
            this.ngayxuatban,
            this.tensach,
            this.ngaynhap});
            this.dataGridView1.Location = new System.Drawing.Point(93, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 349);
            this.dataGridView1.TabIndex = 67;
            // 
            // maphieu
            // 
            this.maphieu.HeaderText = "Mã Phiếu";
            this.maphieu.MinimumWidth = 8;
            this.maphieu.Name = "maphieu";
            this.maphieu.ReadOnly = true;
            this.maphieu.Width = 150;
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.MinimumWidth = 8;
            this.theloai.Name = "theloai";
            this.theloai.Width = 150;
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.HeaderText = "Nhà Xuất Bản";
            this.nhaxuatban.MinimumWidth = 8;
            this.nhaxuatban.Name = "nhaxuatban";
            this.nhaxuatban.Width = 150;
            // 
            // trigia
            // 
            this.trigia.HeaderText = "Trị Giá";
            this.trigia.MinimumWidth = 8;
            this.trigia.Name = "trigia";
            this.trigia.Width = 150;
            // 
            // ngayxuatban
            // 
            this.ngayxuatban.HeaderText = "Ngày Xuất Bản";
            this.ngayxuatban.MinimumWidth = 8;
            this.ngayxuatban.Name = "ngayxuatban";
            this.ngayxuatban.Width = 150;
            // 
            // tensach
            // 
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.MinimumWidth = 8;
            this.tensach.Name = "tensach";
            this.tensach.Width = 150;
            // 
            // ngaynhap
            // 
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.MinimumWidth = 8;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 150;
            // 
            // tracuu_combobox
            // 
            this.tracuu_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuu_combobox.FormattingEnabled = true;
            this.tracuu_combobox.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Thể Loại",
            "NXB",
            "Ngày XB",
            "Trị Giá",
            "Tên Sách",
            "Ngày Nhập"});
            this.tracuu_combobox.Location = new System.Drawing.Point(790, 182);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(174, 33);
            this.tracuu_combobox.TabIndex = 65;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(93, 638);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(110, 48);
            this.them_btn.TabIndex = 64;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(186, 182);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(562, 30);
            this.hoten_txt.TabIndex = 63;
            // 
            // QLthedocgia_label
            // 
            this.QLthedocgia_label.AutoSize = true;
            this.QLthedocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLthedocgia_label.Location = new System.Drawing.Point(230, 55);
            this.QLthedocgia_label.Name = "QLthedocgia_label";
            this.QLthedocgia_label.Size = new System.Drawing.Size(574, 46);
            this.QLthedocgia_label.TabIndex = 62;
            this.QLthedocgia_label.Text = "QUẢN LÝ PHIẾU NHẬP SÁCH";
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(344, 638);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 48);
            this.sua_btn.TabIndex = 69;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(219, 638);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 48);
            this.xoa_btn.TabIndex = 68;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(146, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // lapPhieuNhapSach_view1
            // 
            this.lapPhieuNhapSach_view1.BackColor = System.Drawing.Color.LightBlue;
            this.lapPhieuNhapSach_view1.Location = new System.Drawing.Point(38, 708);
            this.lapPhieuNhapSach_view1.Name = "lapPhieuNhapSach_view1";
            this.lapPhieuNhapSach_view1.Size = new System.Drawing.Size(1100, 745);
            this.lapPhieuNhapSach_view1.TabIndex = 70;
            this.lapPhieuNhapSach_view1.Visible = false;
            // 
            // suaPhieuNhapSach_view1
            // 
            this.suaPhieuNhapSach_view1.Location = new System.Drawing.Point(65, 708);
            this.suaPhieuNhapSach_view1.Name = "suaPhieuNhapSach_view1";
            this.suaPhieuNhapSach_view1.Size = new System.Drawing.Size(1100, 745);
            this.suaPhieuNhapSach_view1.TabIndex = 71;
            this.suaPhieuNhapSach_view1.Visible = false;
            // 
            // QuanLyPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaPhieuNhapSach_view1);
            this.Controls.Add(this.lapPhieuNhapSach_view1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.QLthedocgia_label);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Name = "QuanLyPhieuNhapSach";
            this.Size = new System.Drawing.Size(1100, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label QLthedocgia_label;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private LapPhieuNhapSach_view lapPhieuNhapSach_view1;
        private SuaPhieuNhapSach_view suaPhieuNhapSach_view1;
    }
}
