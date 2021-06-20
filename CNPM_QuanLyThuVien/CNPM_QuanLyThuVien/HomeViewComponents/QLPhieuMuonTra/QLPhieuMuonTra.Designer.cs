
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
            this.dgv_borrow = new System.Windows.Forms.DataGridView();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.suaSach_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLsach.SuaSach_view();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lapPhieuMuonTra_view1 = new CNPM_QuanLyThuVien.LapPhieuMuonTra_view();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_borrow
            // 
            this.dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_borrow.Location = new System.Drawing.Point(90, 194);
            this.dgv_borrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_borrow.Name = "dgv_borrow";
            this.dgv_borrow.RowHeadersWidth = 62;
            this.dgv_borrow.RowTemplate.Height = 28;
            this.dgv_borrow.Size = new System.Drawing.Size(813, 279);
            this.dgv_borrow.TabIndex = 83;
            this.dgv_borrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(104, 507);
            this.them_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(98, 38);
            this.them_btn.TabIndex = 80;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(327, 507);
            this.sua_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(98, 38);
            this.sua_btn.TabIndex = 82;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(216, 507);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(98, 38);
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
            this.tracuu_combobox.Location = new System.Drawing.Point(675, 131);
            this.tracuu_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(155, 28);
            this.tracuu_combobox.TabIndex = 78;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(138, 131);
            this.hoten_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(500, 26);
            this.hoten_txt.TabIndex = 77;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(239, 42);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(472, 39);
            this.tracuusach_label.TabIndex = 76;
            this.tracuusach_label.Text = "QUẢN LÝ PHIẾU MƯỢN TRẢ";
            // 
            // suaSach_view1
            // 
            this.suaSach_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaSach_view1.Location = new System.Drawing.Point(78, 569);
            this.suaSach_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suaSach_view1.Name = "suaSach_view1";
            this.suaSach_view1.Size = new System.Drawing.Size(978, 596);
            this.suaSach_view1.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(104, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // lapPhieuMuonTra_view1
            // 
            this.lapPhieuMuonTra_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.lapPhieuMuonTra_view1.Location = new System.Drawing.Point(31, 550);
            this.lapPhieuMuonTra_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lapPhieuMuonTra_view1.Name = "lapPhieuMuonTra_view1";
            this.lapPhieuMuonTra_view1.Size = new System.Drawing.Size(978, 596);
            this.lapPhieuMuonTra_view1.TabIndex = 86;
            this.lapPhieuMuonTra_view1.Visible = false;
            // 
            // QLPhieuMuonTra_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.lapPhieuMuonTra_view1);
            this.Controls.Add(this.dgv_borrow);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.tracuusach_label);
            this.Controls.Add(this.suaSach_view1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLPhieuMuonTra_view";
            this.Size = new System.Drawing.Size(978, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_borrow;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label tracuusach_label;
        private QLsach.SuaSach_view suaSach_view1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LapPhieuMuonTra_view lapPhieuMuonTra_view1;
    }
}
