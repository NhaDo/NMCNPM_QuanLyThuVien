
namespace CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao
{
    partial class QuanLyTheDocGia_view
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.them_btn = new System.Windows.Forms.Button();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.QLthedocgia_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaidocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapthe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.lapTheDocGia_view1 = new CNPM_QuanLyThuVien.LapTheDocGia_view();
            this.suaTheDocGia_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLTheDocGia.SuaTheDocGia_view();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(140, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // tracuu_combobox
            // 
            this.tracuu_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuu_combobox.FormattingEnabled = true;
            this.tracuu_combobox.Items.AddRange(new object[] {
            "Mã Độc Giả",
            "Họ Tên",
            "Loại Độc Giả",
            "Ngày Sinh",
            "Địa Chỉ",
            "Email",
            "Ngày Lập Thẻ"});
            this.tracuu_combobox.Location = new System.Drawing.Point(784, 175);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(174, 33);
            this.tracuu_combobox.TabIndex = 57;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(87, 631);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(110, 48);
            this.them_btn.TabIndex = 56;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(180, 175);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(562, 30);
            this.hoten_txt.TabIndex = 54;
            // 
            // QLthedocgia_label
            // 
            this.QLthedocgia_label.AutoSize = true;
            this.QLthedocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLthedocgia_label.Location = new System.Drawing.Point(368, 52);
            this.QLthedocgia_label.Name = "QLthedocgia_label";
            this.QLthedocgia_label.Size = new System.Drawing.Size(465, 46);
            this.QLthedocgia_label.TabIndex = 53;
            this.QLthedocgia_label.Text = "QUẢN LÝ THẺ ĐỘC GIẢ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madocgia,
            this.hoten,
            this.loaidocgia,
            this.ngaysinh,
            this.diachi,
            this.email,
            this.ngaylapthe});
            this.dataGridView1.Location = new System.Drawing.Point(87, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 349);
            this.dataGridView1.TabIndex = 59;
            // 
            // madocgia
            // 
            this.madocgia.HeaderText = "Mã Độc Giả";
            this.madocgia.MinimumWidth = 8;
            this.madocgia.Name = "madocgia";
            this.madocgia.Width = 150;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.Width = 150;
            // 
            // loaidocgia
            // 
            this.loaidocgia.HeaderText = "Loại độc giả";
            this.loaidocgia.MinimumWidth = 8;
            this.loaidocgia.Name = "loaidocgia";
            this.loaidocgia.Width = 150;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 150;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 8;
            this.diachi.Name = "diachi";
            this.diachi.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // ngaylapthe
            // 
            this.ngaylapthe.HeaderText = "Ngày lập thẻ";
            this.ngaylapthe.MinimumWidth = 8;
            this.ngaylapthe.Name = "ngaylapthe";
            this.ngaylapthe.Width = 150;
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(213, 631);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 48);
            this.xoa_btn.TabIndex = 60;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(338, 631);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 48);
            this.sua_btn.TabIndex = 61;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // lapTheDocGia_view1
            // 
            this.lapTheDocGia_view1.BackColor = System.Drawing.Color.LightBlue;
            this.lapTheDocGia_view1.Location = new System.Drawing.Point(12, 685);
            this.lapTheDocGia_view1.Name = "lapTheDocGia_view1";
            this.lapTheDocGia_view1.Size = new System.Drawing.Size(1100, 745);
            this.lapTheDocGia_view1.TabIndex = 62;
            this.lapTheDocGia_view1.Visible = false;
            // 
            // suaTheDocGia_view1
            // 
            this.suaTheDocGia_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaTheDocGia_view1.Location = new System.Drawing.Point(22, 700);
            this.suaTheDocGia_view1.Name = "suaTheDocGia_view1";
            this.suaTheDocGia_view1.Size = new System.Drawing.Size(1100, 745);
            this.suaTheDocGia_view1.TabIndex = 63;
            // 
            // QuanLyTheDocGia_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaTheDocGia_view1);
            this.Controls.Add(this.lapTheDocGia_view1);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.QLthedocgia_label);
            this.Name = "QuanLyTheDocGia_view";
            this.Size = new System.Drawing.Size(1100, 745);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label QLthedocgia_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaidocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapthe;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button sua_btn;
        private LapTheDocGia_view lapTheDocGia_view1;
        private QLTheDocGia.SuaTheDocGia_view suaTheDocGia_view1;
    }
}
