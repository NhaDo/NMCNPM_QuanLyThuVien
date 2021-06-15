
namespace CNPM_QuanLyThuVien.HomeViewComponents
{
    partial class QLSach_view
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
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.macuonsach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.themSach_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLsach.ThemSach_view();
            this.suaSach_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLsach.SuaSach_view();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(160, 155);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(562, 30);
            this.hoten_txt.TabIndex = 24;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(370, 46);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(318, 46);
            this.tracuusach_label.TabIndex = 17;
            this.tracuusach_label.Text = "QUẢN LÝ SÁCH";
            // 
            // tracuu_combobox
            // 
            this.tracuu_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuu_combobox.FormattingEnabled = true;
            this.tracuu_combobox.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tác giả"});
            this.tracuu_combobox.Location = new System.Drawing.Point(764, 155);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(174, 33);
            this.tracuu_combobox.TabIndex = 32;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(122, 625);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(110, 48);
            this.them_btn.TabIndex = 70;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(373, 625);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 48);
            this.sua_btn.TabIndex = 72;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(248, 625);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 48);
            this.xoa_btn.TabIndex = 71;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macuonsach,
            this.masach,
            this.tensach,
            this.theloai,
            this.tacgia,
            this.tinhtrang});
            this.dataGridView1.Location = new System.Drawing.Point(106, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 349);
            this.dataGridView1.TabIndex = 73;
            // 
            // macuonsach
            // 
            this.macuonsach.HeaderText = "Mã Cuốn Sách";
            this.macuonsach.MinimumWidth = 8;
            this.macuonsach.Name = "macuonsach";
            this.macuonsach.Width = 150;
            // 
            // masach
            // 
            this.masach.HeaderText = "Mã sách";
            this.masach.MinimumWidth = 8;
            this.masach.Name = "masach";
            this.masach.Width = 150;
            // 
            // tensach
            // 
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.MinimumWidth = 8;
            this.tensach.Name = "tensach";
            this.tensach.Width = 150;
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.MinimumWidth = 8;
            this.theloai.Name = "theloai";
            this.theloai.Width = 150;
            // 
            // tacgia
            // 
            this.tacgia.HeaderText = "Tác Giả";
            this.tacgia.MinimumWidth = 8;
            this.tacgia.Name = "tacgia";
            this.tacgia.Width = 150;
            // 
            // tinhtrang
            // 
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 8;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(122, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // themSach_view1
            // 
            this.themSach_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.themSach_view1.Location = new System.Drawing.Point(17, 679);
            this.themSach_view1.Name = "themSach_view1";
            this.themSach_view1.Size = new System.Drawing.Size(1100, 745);
            this.themSach_view1.TabIndex = 74;
            // 
            // suaSach_view1
            // 
            this.suaSach_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaSach_view1.Location = new System.Drawing.Point(93, 702);
            this.suaSach_view1.Name = "suaSach_view1";
            this.suaSach_view1.Size = new System.Drawing.Size(1100, 745);
            this.suaSach_view1.TabIndex = 75;
            // 
            // QLSach_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaSach_view1);
            this.Controls.Add(this.themSach_view1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.tracuusach_label);
            this.Name = "QLSach_view";
            this.Size = new System.Drawing.Size(1100, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label tracuusach_label;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn macuonsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private QLsach.ThemSach_view themSach_view1;
        private QLsach.SuaSach_view suaSach_view1;
    }
}
