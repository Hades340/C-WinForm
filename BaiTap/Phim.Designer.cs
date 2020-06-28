namespace BaiTap
{
    partial class Phim
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_MaVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_NuocNgot = new System.Windows.Forms.CheckBox();
            this.cb_BongNgo = new System.Windows.Forms.CheckBox();
            this.NgayGioChieu = new System.Windows.Forms.DateTimePicker();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_MaLoaiVe = new System.Windows.Forms.ComboBox();
            this.cb_MaKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 359);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_MaVe
            // 
            this.txt_MaVe.Location = new System.Drawing.Point(93, 24);
            this.txt_MaVe.Name = "txt_MaVe";
            this.txt_MaVe.Size = new System.Drawing.Size(199, 20);
            this.txt_MaVe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MaVe";
            // 
            // txt_TenPhim
            // 
            this.txt_TenPhim.Location = new System.Drawing.Point(93, 178);
            this.txt_TenPhim.Name = "txt_TenPhim";
            this.txt_TenPhim.Size = new System.Drawing.Size(199, 20);
            this.txt_TenPhim.TabIndex = 7;
            this.txt_TenPhim.TextChanged += new System.EventHandler(this.txt_TenPhim_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MaLoaiVe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "MaKH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TenPhim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "NgayGioChieu";
            // 
            // cb_NuocNgot
            // 
            this.cb_NuocNgot.AutoSize = true;
            this.cb_NuocNgot.Location = new System.Drawing.Point(15, 257);
            this.cb_NuocNgot.Name = "cb_NuocNgot";
            this.cb_NuocNgot.Size = new System.Drawing.Size(75, 17);
            this.cb_NuocNgot.TabIndex = 14;
            this.cb_NuocNgot.Text = "NuocNgot";
            this.cb_NuocNgot.UseVisualStyleBackColor = true;
            // 
            // cb_BongNgo
            // 
            this.cb_BongNgo.AutoSize = true;
            this.cb_BongNgo.Location = new System.Drawing.Point(112, 257);
            this.cb_BongNgo.Name = "cb_BongNgo";
            this.cb_BongNgo.Size = new System.Drawing.Size(71, 17);
            this.cb_BongNgo.TabIndex = 15;
            this.cb_BongNgo.Text = "BongNgo";
            this.cb_BongNgo.UseVisualStyleBackColor = true;
            // 
            // NgayGioChieu
            // 
            this.NgayGioChieu.Location = new System.Drawing.Point(93, 218);
            this.NgayGioChieu.Name = "NgayGioChieu";
            this.NgayGioChieu.Size = new System.Drawing.Size(199, 20);
            this.NgayGioChieu.TabIndex = 16;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(276, 349);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "TimKiem";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(135, 309);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(27, 309);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(249, 309);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(65, 351);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(189, 20);
            this.txt_TimKiem.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "MaVe";
            // 
            // cb_MaLoaiVe
            // 
            this.cb_MaLoaiVe.FormattingEnabled = true;
            this.cb_MaLoaiVe.Location = new System.Drawing.Point(93, 68);
            this.cb_MaLoaiVe.Name = "cb_MaLoaiVe";
            this.cb_MaLoaiVe.Size = new System.Drawing.Size(199, 21);
            this.cb_MaLoaiVe.TabIndex = 23;
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.FormattingEnabled = true;
            this.cb_MaKH.Location = new System.Drawing.Point(93, 122);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(199, 21);
            this.cb_MaKH.TabIndex = 24;
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 392);
            this.Controls.Add(this.cb_MaKH);
            this.Controls.Add(this.cb_MaLoaiVe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.NgayGioChieu);
            this.Controls.Add(this.cb_BongNgo);
            this.Controls.Add(this.cb_NuocNgot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaVe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Phim";
            this.Text = "Phim";
            this.Load += new System.EventHandler(this.Phim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_MaVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_NuocNgot;
        private System.Windows.Forms.CheckBox cb_BongNgo;
        private System.Windows.Forms.DateTimePicker NgayGioChieu;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_MaLoaiVe;
        private System.Windows.Forms.ComboBox cb_MaKH;
    }
}