
namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuThuTienPhat
{
    partial class QLPhieuThuTienPhat_view
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
            this.madocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotienthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lapPhieuThuTienPhat_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.LapPhieuThuTienPhat_view();
            this.suaPhieuThuTienPhat_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuThuTienPhat.SuaPhieuThuTienPhat_view();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.madocgia,
            this.hoten,
            this.tongno,
            this.sotienthu,
            this.conlai});
            this.dataGridView1.Location = new System.Drawing.Point(95, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 349);
            this.dataGridView1.TabIndex = 94;
            // 
            // maphieu
            // 
            this.maphieu.HeaderText = "Mã Phiếu";
            this.maphieu.MinimumWidth = 8;
            this.maphieu.Name = "maphieu";
            this.maphieu.Width = 150;
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
            // tongno
            // 
            this.tongno.HeaderText = "Tổng Nợ";
            this.tongno.MinimumWidth = 8;
            this.tongno.Name = "tongno";
            this.tongno.Width = 150;
            // 
            // sotienthu
            // 
            this.sotienthu.HeaderText = "Số Tiền Thu";
            this.sotienthu.MinimumWidth = 8;
            this.sotienthu.Name = "sotienthu";
            this.sotienthu.Width = 150;
            // 
            // conlai
            // 
            this.conlai.HeaderText = "Còn Lại";
            this.conlai.MinimumWidth = 8;
            this.conlai.Name = "conlai";
            this.conlai.Width = 150;
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(117, 639);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(110, 48);
            this.them_btn.TabIndex = 91;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(368, 639);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 48);
            this.sua_btn.TabIndex = 93;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(243, 639);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 48);
            this.xoa_btn.TabIndex = 92;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = true;
            // 
            // tracuu_combobox
            // 
            this.tracuu_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuu_combobox.FormattingEnabled = true;
            this.tracuu_combobox.Items.AddRange(new object[] {
            "Mã Phiếu",
            "Mã Độc Giả",
            "Họ Tên Độc Giả",
            "Tổng Nợ",
            "Số Tiền Thu",
            "Còn Lại"});
            this.tracuu_combobox.Location = new System.Drawing.Point(759, 169);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(174, 33);
            this.tracuu_combobox.TabIndex = 89;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(155, 169);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(562, 30);
            this.hoten_txt.TabIndex = 88;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(269, 58);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(640, 46);
            this.tracuusach_label.TabIndex = 87;
            this.tracuusach_label.Text = "QUẢN LÝ PHIẾU THU TIỀN PHẠT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(117, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lapPhieuThuTienPhat_view1
            // 
            this.lapPhieuThuTienPhat_view1.BackColor = System.Drawing.Color.LightBlue;
            this.lapPhieuThuTienPhat_view1.Location = new System.Drawing.Point(37, 704);
            this.lapPhieuThuTienPhat_view1.Name = "lapPhieuThuTienPhat_view1";
            this.lapPhieuThuTienPhat_view1.Size = new System.Drawing.Size(1100, 745);
            this.lapPhieuThuTienPhat_view1.TabIndex = 95;
            this.lapPhieuThuTienPhat_view1.Visible = false;
            // 
            // suaPhieuThuTienPhat_view1
            // 
            this.suaPhieuThuTienPhat_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaPhieuThuTienPhat_view1.Location = new System.Drawing.Point(85, 704);
            this.suaPhieuThuTienPhat_view1.Name = "suaPhieuThuTienPhat_view1";
            this.suaPhieuThuTienPhat_view1.Size = new System.Drawing.Size(1100, 745);
            this.suaPhieuThuTienPhat_view1.TabIndex = 96;
            this.suaPhieuThuTienPhat_view1.Visible = false;
            // 
            // QLPhieuThuTienPhat_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaPhieuThuTienPhat_view1);
            this.Controls.Add(this.lapPhieuThuTienPhat_view1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.tracuusach_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QLPhieuThuTienPhat_view";
            this.Size = new System.Drawing.Size(1100, 745);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label tracuusach_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotienthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlai;
        private LapPhieuThuTienPhat_view lapPhieuThuTienPhat_view1;
        private SuaPhieuThuTienPhat_view suaPhieuThuTienPhat_view1;
    }
}
