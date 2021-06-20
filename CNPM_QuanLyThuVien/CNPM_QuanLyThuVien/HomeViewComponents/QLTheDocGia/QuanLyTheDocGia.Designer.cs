
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
            this.dgv_docgia = new System.Windows.Forms.DataGridView();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.lapTheDocGia_view1 = new CNPM_QuanLyThuVien.LapTheDocGia_view();
            this.suaTheDocGia_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLTheDocGia.SuaTheDocGia_view();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(124, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
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
            this.tracuu_combobox.Location = new System.Drawing.Point(697, 140);
            this.tracuu_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(155, 28);
            this.tracuu_combobox.TabIndex = 57;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(77, 505);
            this.them_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(98, 38);
            this.them_btn.TabIndex = 56;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(160, 140);
            this.hoten_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(500, 26);
            this.hoten_txt.TabIndex = 54;
            // 
            // QLthedocgia_label
            // 
            this.QLthedocgia_label.AutoSize = true;
            this.QLthedocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLthedocgia_label.Location = new System.Drawing.Point(327, 42);
            this.QLthedocgia_label.Name = "QLthedocgia_label";
            this.QLthedocgia_label.Size = new System.Drawing.Size(397, 39);
            this.QLthedocgia_label.TabIndex = 53;
            this.QLthedocgia_label.Text = "QUẢN LÝ THẺ ĐỘC GIẢ";
            // 
            // dgv_docgia
            // 
            this.dgv_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_docgia.Location = new System.Drawing.Point(67, 183);
            this.dgv_docgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_docgia.Name = "dgv_docgia";
            this.dgv_docgia.RowHeadersWidth = 62;
            this.dgv_docgia.RowTemplate.Height = 28;
            this.dgv_docgia.Size = new System.Drawing.Size(879, 279);
            this.dgv_docgia.TabIndex = 59;
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(189, 505);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(98, 38);
            this.xoa_btn.TabIndex = 60;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(300, 505);
            this.sua_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(98, 38);
            this.sua_btn.TabIndex = 61;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // lapTheDocGia_view1
            // 
            this.lapTheDocGia_view1.BackColor = System.Drawing.Color.LightBlue;
            this.lapTheDocGia_view1.Location = new System.Drawing.Point(11, 548);
            this.lapTheDocGia_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lapTheDocGia_view1.Name = "lapTheDocGia_view1";
            this.lapTheDocGia_view1.Size = new System.Drawing.Size(978, 596);
            this.lapTheDocGia_view1.TabIndex = 62;
            this.lapTheDocGia_view1.Visible = false;
            // 
            // suaTheDocGia_view1
            // 
            this.suaTheDocGia_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaTheDocGia_view1.Location = new System.Drawing.Point(20, 560);
            this.suaTheDocGia_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suaTheDocGia_view1.Name = "suaTheDocGia_view1";
            this.suaTheDocGia_view1.Size = new System.Drawing.Size(978, 596);
            this.suaTheDocGia_view1.TabIndex = 63;
            // 
            // QuanLyTheDocGia_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaTheDocGia_view1);
            this.Controls.Add(this.lapTheDocGia_view1);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.dgv_docgia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.QLthedocgia_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyTheDocGia_view";
            this.Size = new System.Drawing.Size(978, 596);
            this.Load += new System.EventHandler(this.QuanLyTheDocGia_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_docgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label QLthedocgia_label;
        private System.Windows.Forms.DataGridView dgv_docgia;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button sua_btn;
        private LapTheDocGia_view lapTheDocGia_view1;
        private QLTheDocGia.SuaTheDocGia_view suaTheDocGia_view1;
    }
}
