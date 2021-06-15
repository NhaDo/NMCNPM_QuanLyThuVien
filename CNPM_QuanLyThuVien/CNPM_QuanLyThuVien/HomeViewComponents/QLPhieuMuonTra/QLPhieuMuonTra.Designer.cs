
namespace CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuMuonTra
{
    partial class QLPhieuMuonTra_view
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
            this.ngaylapphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.suaSach_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLsach.SuaSach_view();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lapPhieuMuonTra_view1 = new CNPM_QuanLyThuVien.LapPhieuMuonTra_view();
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
            this.ngaylapphieu,
            this.loaiphieu});
            this.dataGridView1.Location = new System.Drawing.Point(101, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(915, 349);
            this.dataGridView1.TabIndex = 83;
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
            // ngaylapphieu
            // 
            this.ngaylapphieu.HeaderText = "Ngày Lập Phiếu";
            this.ngaylapphieu.MinimumWidth = 8;
            this.ngaylapphieu.Name = "ngaylapphieu";
            this.ngaylapphieu.Width = 150;
            // 
            // loaiphieu
            // 
            this.loaiphieu.HeaderText = "Loại Phiếu";
            this.loaiphieu.MinimumWidth = 8;
            this.loaiphieu.Name = "loaiphieu";
            this.loaiphieu.Width = 150;
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(117, 634);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(110, 48);
            this.them_btn.TabIndex = 80;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(368, 634);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(110, 48);
            this.sua_btn.TabIndex = 82;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(243, 634);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(110, 48);
            this.xoa_btn.TabIndex = 81;
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
            "Ngày Lập Phiếu"});
            this.tracuu_combobox.Location = new System.Drawing.Point(759, 164);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(174, 33);
            this.tracuu_combobox.TabIndex = 78;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(155, 164);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(562, 30);
            this.hoten_txt.TabIndex = 77;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(269, 53);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(552, 46);
            this.tracuusach_label.TabIndex = 76;
            this.tracuusach_label.Text = "QUẢN LÝ PHIẾU MƯỢN TRẢ";
            // 
            // suaSach_view1
            // 
            this.suaSach_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaSach_view1.Location = new System.Drawing.Point(88, 711);
            this.suaSach_view1.Name = "suaSach_view1";
            this.suaSach_view1.Size = new System.Drawing.Size(1100, 745);
            this.suaSach_view1.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(117, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // lapPhieuMuonTra_view1
            // 
            this.lapPhieuMuonTra_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.lapPhieuMuonTra_view1.Location = new System.Drawing.Point(35, 688);
            this.lapPhieuMuonTra_view1.Name = "lapPhieuMuonTra_view1";
            this.lapPhieuMuonTra_view1.Size = new System.Drawing.Size(1100, 745);
            this.lapPhieuMuonTra_view1.TabIndex = 86;
            this.lapPhieuMuonTra_view1.Visible = false;
            // 
            // QLPhieuMuonTra_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.lapPhieuMuonTra_view1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.tracuusach_label);
            this.Controls.Add(this.suaSach_view1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QLPhieuMuonTra_view";
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
        private QLsach.SuaSach_view suaSach_view1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn madocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphieu;
        private LapPhieuMuonTra_view lapPhieuMuonTra_view1;
    }
}
