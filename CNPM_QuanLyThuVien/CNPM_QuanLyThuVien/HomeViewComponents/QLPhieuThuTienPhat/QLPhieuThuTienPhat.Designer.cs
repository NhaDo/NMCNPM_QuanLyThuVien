
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
            this.dgv_phieuphat = new System.Windows.Forms.DataGridView();
            this.them_btn = new System.Windows.Forms.Button();
            this.sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.tracuu_combobox = new System.Windows.Forms.ComboBox();
            this.hoten_txt = new System.Windows.Forms.TextBox();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lapPhieuThuTienPhat_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.LapPhieuThuTienPhat_view();
            this.suaPhieuThuTienPhat_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.QLPhieuThuTienPhat.SuaPhieuThuTienPhat_view();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuphat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_phieuphat
            // 
            this.dgv_phieuphat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieuphat.Location = new System.Drawing.Point(84, 198);
            this.dgv_phieuphat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_phieuphat.Name = "dgv_phieuphat";
            this.dgv_phieuphat.RowHeadersWidth = 62;
            this.dgv_phieuphat.RowTemplate.Height = 28;
            this.dgv_phieuphat.Size = new System.Drawing.Size(813, 279);
            this.dgv_phieuphat.TabIndex = 94;
            this.dgv_phieuphat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieuphat_CellContentClick);
            // 
            // them_btn
            // 
            this.them_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(104, 511);
            this.them_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(98, 38);
            this.them_btn.TabIndex = 91;
            this.them_btn.Text = "Thêm";
            this.them_btn.UseVisualStyleBackColor = true;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // sua_btn
            // 
            this.sua_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_btn.Location = new System.Drawing.Point(327, 511);
            this.sua_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sua_btn.Name = "sua_btn";
            this.sua_btn.Size = new System.Drawing.Size(98, 38);
            this.sua_btn.TabIndex = 93;
            this.sua_btn.Text = "Sửa";
            this.sua_btn.UseVisualStyleBackColor = true;
            this.sua_btn.Click += new System.EventHandler(this.sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(216, 511);
            this.xoa_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(98, 38);
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
            this.tracuu_combobox.Location = new System.Drawing.Point(675, 135);
            this.tracuu_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tracuu_combobox.Name = "tracuu_combobox";
            this.tracuu_combobox.Size = new System.Drawing.Size(155, 28);
            this.tracuu_combobox.TabIndex = 89;
            this.tracuu_combobox.Text = "Tìm theo...";
            // 
            // hoten_txt
            // 
            this.hoten_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten_txt.Location = new System.Drawing.Point(138, 135);
            this.hoten_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoten_txt.Name = "hoten_txt";
            this.hoten_txt.Size = new System.Drawing.Size(500, 26);
            this.hoten_txt.TabIndex = 88;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(239, 46);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(550, 39);
            this.tracuusach_label.TabIndex = 87;
            this.tracuusach_label.Text = "QUẢN LÝ PHIẾU THU TIỀN PHẠT";
            this.tracuusach_label.Click += new System.EventHandler(this.tracuusach_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CNPM_QuanLyThuVien.Properties.Resources._1024px_Search_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(104, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lapPhieuThuTienPhat_view1
            // 
            this.lapPhieuThuTienPhat_view1.BackColor = System.Drawing.Color.LightBlue;
            this.lapPhieuThuTienPhat_view1.Location = new System.Drawing.Point(33, 563);
            this.lapPhieuThuTienPhat_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lapPhieuThuTienPhat_view1.Name = "lapPhieuThuTienPhat_view1";
            this.lapPhieuThuTienPhat_view1.Size = new System.Drawing.Size(978, 596);
            this.lapPhieuThuTienPhat_view1.TabIndex = 95;
            this.lapPhieuThuTienPhat_view1.Visible = false;
            // 
            // suaPhieuThuTienPhat_view1
            // 
            this.suaPhieuThuTienPhat_view1.BackColor = System.Drawing.Color.PowderBlue;
            this.suaPhieuThuTienPhat_view1.Location = new System.Drawing.Point(76, 563);
            this.suaPhieuThuTienPhat_view1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suaPhieuThuTienPhat_view1.Name = "suaPhieuThuTienPhat_view1";
            this.suaPhieuThuTienPhat_view1.Size = new System.Drawing.Size(978, 596);
            this.suaPhieuThuTienPhat_view1.TabIndex = 96;
            this.suaPhieuThuTienPhat_view1.Visible = false;
            // 
            // QLPhieuThuTienPhat_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.suaPhieuThuTienPhat_view1);
            this.Controls.Add(this.lapPhieuThuTienPhat_view1);
            this.Controls.Add(this.dgv_phieuphat);
            this.Controls.Add(this.them_btn);
            this.Controls.Add(this.sua_btn);
            this.Controls.Add(this.xoa_btn);
            this.Controls.Add(this.tracuu_combobox);
            this.Controls.Add(this.hoten_txt);
            this.Controls.Add(this.tracuusach_label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLPhieuThuTienPhat_view";
            this.Size = new System.Drawing.Size(978, 596);
            this.Load += new System.EventHandler(this.QLPhieuThuTienPhat_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieuphat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_phieuphat;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.Button sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.ComboBox tracuu_combobox;
        private System.Windows.Forms.TextBox hoten_txt;
        private System.Windows.Forms.Label tracuusach_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LapPhieuThuTienPhat_view lapPhieuThuTienPhat_view1;
        private SuaPhieuThuTienPhat_view suaPhieuThuTienPhat_view1;
    }
}
