
namespace CNPM_QuanLyThuVien
{
    partial class LapPhieuMuonTra_view
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
            this.phieumuon_btn = new System.Windows.Forms.Button();
            this.phieutra_btn = new System.Windows.Forms.Button();
            this.phieuTra_view1 = new CNPM_QuanLyThuVien.PhieuTra_view();
            this.phieuMuon_view1 = new CNPM_QuanLyThuVien.PhieuMuon_view();
            this.SuspendLayout();
            // 
            // phieumuon_btn
            // 
            this.phieumuon_btn.Location = new System.Drawing.Point(604, 18);
            this.phieumuon_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phieumuon_btn.Name = "phieumuon_btn";
            this.phieumuon_btn.Size = new System.Drawing.Size(109, 31);
            this.phieumuon_btn.TabIndex = 48;
            this.phieumuon_btn.Text = "Lập phiếu mượn";
            this.phieumuon_btn.UseVisualStyleBackColor = true;
            this.phieumuon_btn.Click += new System.EventHandler(this.phieumuon_btn_Click);
            // 
            // phieutra_btn
            // 
            this.phieutra_btn.Location = new System.Drawing.Point(604, 53);
            this.phieutra_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phieutra_btn.Name = "phieutra_btn";
            this.phieutra_btn.Size = new System.Drawing.Size(109, 31);
            this.phieutra_btn.TabIndex = 51;
            this.phieutra_btn.Text = "Lập phiếu trả";
            this.phieutra_btn.UseVisualStyleBackColor = true;
            this.phieutra_btn.Click += new System.EventHandler(this.phieutra_btn_Click);
            // 
            // phieuTra_view1
            // 
            this.phieuTra_view1.Location = new System.Drawing.Point(1, 1);
            this.phieuTra_view1.Margin = new System.Windows.Forms.Padding(1);
            this.phieuTra_view1.Name = "phieuTra_view1";
            this.phieuTra_view1.Size = new System.Drawing.Size(576, 483);
            this.phieuTra_view1.TabIndex = 53;
            this.phieuTra_view1.Visible = false;
            // 
            // phieuMuon_view1
            // 
            this.phieuMuon_view1.Location = new System.Drawing.Point(0, 0);
            this.phieuMuon_view1.Margin = new System.Windows.Forms.Padding(1);
            this.phieuMuon_view1.Name = "phieuMuon_view1";
            this.phieuMuon_view1.Size = new System.Drawing.Size(576, 483);
            this.phieuMuon_view1.TabIndex = 52;
            // 
            // LapPhieuMuonTra_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.phieuTra_view1);
            this.Controls.Add(this.phieuMuon_view1);
            this.Controls.Add(this.phieutra_btn);
            this.Controls.Add(this.phieumuon_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LapPhieuMuonTra_view";
            this.Size = new System.Drawing.Size(733, 484);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button phieumuon_btn;
        private System.Windows.Forms.Button phieutra_btn;
        private PhieuMuon_view phieuMuon_view1;
        private PhieuTra_view phieuTra_view1;
    }
}
