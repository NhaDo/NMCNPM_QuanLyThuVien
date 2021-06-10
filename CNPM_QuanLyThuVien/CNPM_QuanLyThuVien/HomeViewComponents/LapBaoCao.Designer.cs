
namespace CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao
{
    partial class LapBaoCao_view
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
            this.tktratre_btn = new System.Windows.Forms.Button();
            this.bctheloai_btn = new System.Windows.Forms.Button();
            this.thongKeSachTraTre_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao.ThongKeSachTraTre_view();
            this.baoCaoTheoTheLoai_view1 = new CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao.BaoCaoTheoTheLoai_view();
            this.SuspendLayout();
            // 
            // tktratre_btn
            // 
            this.tktratre_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tktratre_btn.Location = new System.Drawing.Point(594, 51);
            this.tktratre_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tktratre_btn.Name = "tktratre_btn";
            this.tktratre_btn.Size = new System.Drawing.Size(125, 31);
            this.tktratre_btn.TabIndex = 55;
            this.tktratre_btn.Text = "Thống kê sách trả trễ";
            this.tktratre_btn.UseVisualStyleBackColor = true;
            this.tktratre_btn.Click += new System.EventHandler(this.tktratre_btn_Click);
            // 
            // bctheloai_btn
            // 
            this.bctheloai_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bctheloai_btn.Location = new System.Drawing.Point(594, 16);
            this.bctheloai_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bctheloai_btn.Name = "bctheloai_btn";
            this.bctheloai_btn.Size = new System.Drawing.Size(125, 31);
            this.bctheloai_btn.TabIndex = 54;
            this.bctheloai_btn.Text = "Báo cáo theo thể loại";
            this.bctheloai_btn.UseVisualStyleBackColor = true;
            this.bctheloai_btn.Click += new System.EventHandler(this.bctheloai_btn_Click);
            // 
            // thongKeSachTraTre_view1
            // 
            this.thongKeSachTraTre_view1.Location = new System.Drawing.Point(0, 0);
            this.thongKeSachTraTre_view1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.thongKeSachTraTre_view1.Name = "thongKeSachTraTre_view1";
            this.thongKeSachTraTre_view1.Size = new System.Drawing.Size(576, 483);
            this.thongKeSachTraTre_view1.TabIndex = 57;
            this.thongKeSachTraTre_view1.Visible = false;
            // 
            // baoCaoTheoTheLoai_view1
            // 
            this.baoCaoTheoTheLoai_view1.Location = new System.Drawing.Point(0, 0);
            this.baoCaoTheoTheLoai_view1.Margin = new System.Windows.Forms.Padding(1);
            this.baoCaoTheoTheLoai_view1.Name = "baoCaoTheoTheLoai_view1";
            this.baoCaoTheoTheLoai_view1.Size = new System.Drawing.Size(567, 455);
            this.baoCaoTheoTheLoai_view1.TabIndex = 56;
            this.baoCaoTheoTheLoai_view1.Visible = false;
            // 
            // LapBaoCao_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.thongKeSachTraTre_view1);
            this.Controls.Add(this.baoCaoTheoTheLoai_view1);
            this.Controls.Add(this.tktratre_btn);
            this.Controls.Add(this.bctheloai_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LapBaoCao_view";
            this.Size = new System.Drawing.Size(733, 484);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tktratre_btn;
        private System.Windows.Forms.Button bctheloai_btn;
        private BaoCaoTheoTheLoai_view baoCaoTheoTheLoai_view1;
        private ThongKeSachTraTre_view thongKeSachTraTre_view1;
    }
}
