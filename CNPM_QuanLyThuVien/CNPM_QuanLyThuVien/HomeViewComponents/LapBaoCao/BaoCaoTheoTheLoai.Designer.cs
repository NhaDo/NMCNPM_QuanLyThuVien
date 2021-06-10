
namespace CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao
{
    partial class BaoCaoTheoTheLoai_view
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("abc");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ssss",
            "mani",
            "saw"}, -1);
            this.listView2 = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tentheloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.luotmuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.tracuusach_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.madocgia_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tongsoluotmuon_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tentheloai,
            this.luotmuon,
            this.tile});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView2.Location = new System.Drawing.Point(42, 144);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(518, 212);
            this.listView2.TabIndex = 59;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // tentheloai
            // 
            this.tentheloai.Text = "Tên thể loại";
            // 
            // luotmuon
            // 
            this.luotmuon.Text = "Lượt mượn";
            // 
            // tile
            // 
            this.tile.Text = "Tỉ lệ";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(388, 414);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(73, 31);
            this.cancel_btn.TabIndex = 56;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(487, 414);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(73, 31);
            this.ok_btn.TabIndex = 55;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // tracuusach_label
            // 
            this.tracuusach_label.AutoSize = true;
            this.tracuusach_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuusach_label.Location = new System.Drawing.Point(37, 25);
            this.tracuusach_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tracuusach_label.Name = "tracuusach_label";
            this.tracuusach_label.Size = new System.Drawing.Size(493, 58);
            this.tracuusach_label.TabIndex = 53;
            this.tracuusach_label.Text = "BÁO CÁO THỐNG KÊ\r\nTÌNH HÌNH MƯỢN SÁCH THEO THỂ LOẠI";
            this.tracuusach_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // madocgia_label
            // 
            this.madocgia_label.AutoSize = true;
            this.madocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madocgia_label.Location = new System.Drawing.Point(56, 108);
            this.madocgia_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.madocgia_label.Name = "madocgia_label";
            this.madocgia_label.Size = new System.Drawing.Size(123, 17);
            this.madocgia_label.TabIndex = 77;
            this.madocgia_label.Text = "Ngày/Tháng /Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 365);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 78;
            this.label1.Text = "Tổng số lượt mượn:";
            // 
            // tongsoluotmuon_txtbox
            // 
            this.tongsoluotmuon_txtbox.Location = new System.Drawing.Point(443, 365);
            this.tongsoluotmuon_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tongsoluotmuon_txtbox.Name = "tongsoluotmuon_txtbox";
            this.tongsoluotmuon_txtbox.Size = new System.Drawing.Size(117, 20);
            this.tongsoluotmuon_txtbox.TabIndex = 79;
            // 
            // BaoCaoTheoTheLoai_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tongsoluotmuon_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.madocgia_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.tracuusach_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoTheoTheLoai_view";
            this.Size = new System.Drawing.Size(576, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label tracuusach_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label madocgia_label;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader tentheloai;
        private System.Windows.Forms.ColumnHeader luotmuon;
        private System.Windows.Forms.ColumnHeader tile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tongsoluotmuon_txtbox;
    }
}
