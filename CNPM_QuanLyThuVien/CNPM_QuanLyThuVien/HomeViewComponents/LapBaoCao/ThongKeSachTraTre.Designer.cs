
namespace CNPM_QuanLyThuVien.HomeViewComponents.LapBaoCao
{
    partial class ThongKeSachTraTre_view
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("abc");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "ssss",
            "mani",
            "saw"}, -1);
            this.madocgia_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView2 = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tensach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaymuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songaytratre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.lapthedocgia_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // madocgia_label
            // 
            this.madocgia_label.AutoSize = true;
            this.madocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madocgia_label.Location = new System.Drawing.Point(39, 122);
            this.madocgia_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.madocgia_label.Name = "madocgia_label";
            this.madocgia_label.Size = new System.Drawing.Size(135, 17);
            this.madocgia_label.TabIndex = 83;
            this.madocgia_label.Text = "Ngày / Tháng / Năm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 21);
            this.dateTimePicker1.TabIndex = 82;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tensach,
            this.ngaymuon,
            this.songaytratre});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
            this.listView2.Location = new System.Drawing.Point(42, 159);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(518, 212);
            this.listView2.TabIndex = 81;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // tensach
            // 
            this.tensach.Text = "Tên sách";
            // 
            // ngaymuon
            // 
            this.ngaymuon.Text = "Ngày mượn";
            // 
            // songaytratre
            // 
            this.songaytratre.Text = "Số ngày trả trễ";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(395, 386);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(73, 31);
            this.cancel_btn.TabIndex = 80;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(487, 386);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(73, 31);
            this.ok_btn.TabIndex = 79;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            // 
            // lapthedocgia_label
            // 
            this.lapthedocgia_label.AutoSize = true;
            this.lapthedocgia_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapthedocgia_label.Location = new System.Drawing.Point(51, 46);
            this.lapthedocgia_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lapthedocgia_label.Name = "lapthedocgia_label";
            this.lapthedocgia_label.Size = new System.Drawing.Size(493, 31);
            this.lapthedocgia_label.TabIndex = 84;
            this.lapthedocgia_label.Text = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            // 
            // ThongKeSachTraTre_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lapthedocgia_label);
            this.Controls.Add(this.madocgia_label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThongKeSachTraTre_view";
            this.Size = new System.Drawing.Size(576, 483);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label madocgia_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader tensach;
        private System.Windows.Forms.ColumnHeader ngaymuon;
        private System.Windows.Forms.ColumnHeader songaytratre;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label lapthedocgia_label;
    }
}
