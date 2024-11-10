namespace Pharmacy
{
    partial class frmHDNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHDNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dien_Giai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Ma_Lo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_HDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanh_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(14, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(438, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_CT,
            this.Ngay_CT,
            this.Ma_NV,
            this.Tong_tien,
            this.Dien_Giai});
            this.dataGridView1.Location = new System.Drawing.Point(5, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(419, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ma_CT
            // 
            this.Ma_CT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_CT.HeaderText = "Mã hoá đơn";
            this.Ma_CT.MinimumWidth = 8;
            this.Ma_CT.Name = "Ma_CT";
            this.Ma_CT.Width = 107;
            // 
            // Ngay_CT
            // 
            this.Ngay_CT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ngay_CT.HeaderText = "Ngày";
            this.Ngay_CT.MinimumWidth = 8;
            this.Ngay_CT.Name = "Ngay_CT";
            this.Ngay_CT.Width = 69;
            // 
            // Ma_NV
            // 
            this.Ma_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_NV.HeaderText = "Mã Nhân Viên";
            this.Ma_NV.MinimumWidth = 8;
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.Width = 120;
            // 
            // Tong_tien
            // 
            this.Tong_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tong_tien.HeaderText = "Tổng tiền";
            this.Tong_tien.MinimumWidth = 8;
            this.Tong_tien.Name = "Tong_tien";
            this.Tong_tien.Width = 92;
            // 
            // Dien_Giai
            // 
            this.Dien_Giai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dien_Giai.HeaderText = "Diễn giải";
            this.Dien_Giai.MinimumWidth = 8;
            this.Dien_Giai.Name = "Dien_Giai";
            this.Dien_Giai.Width = 89;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(434, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc phiếu nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Pharmacy.Properties.Resources.magnifying_glass_solid__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(380, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 18);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(76, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(471, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(636, 574);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phiếu nhập";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(410, 97);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(222, 22);
            this.textBox7.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(410, 31);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 97);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 31);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 22);
            this.textBox4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 102);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng tiền: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(22, 35);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 16);
            this.lb.TabIndex = 1;
            this.lb.Text = "Mã hoá đơn: ";
            this.lb.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(16, 150);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(609, 397);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hoá đơn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Lo,
            this.Ma_HDN,
            this.Ma_Thuoc,
            this.Ma_NCC,
            this.NSX,
            this.HSD,
            this.DVT,
            this.So_Luong,
            this.Don_Gia,
            this.Thanh_Tien});
            this.dataGridView2.Location = new System.Drawing.Point(11, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(597, 375);
            this.dataGridView2.TabIndex = 0;
            // 
            // Ma_Lo
            // 
            this.Ma_Lo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_Lo.HeaderText = "Mã Lô";
            this.Ma_Lo.MinimumWidth = 8;
            this.Ma_Lo.Name = "Ma_Lo";
            this.Ma_Lo.Width = 55;
            // 
            // Ma_HDN
            // 
            this.Ma_HDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_HDN.HeaderText = "Mã HĐ nhập";
            this.Ma_HDN.MinimumWidth = 8;
            this.Ma_HDN.Name = "Ma_HDN";
            this.Ma_HDN.Width = 101;
            // 
            // Ma_Thuoc
            // 
            this.Ma_Thuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_Thuoc.HeaderText = "Danh mục thuốc";
            this.Ma_Thuoc.MinimumWidth = 8;
            this.Ma_Thuoc.Name = "Ma_Thuoc";
            this.Ma_Thuoc.Width = 120;
            // 
            // Ma_NCC
            // 
            this.Ma_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_NCC.HeaderText = "Nhà cung cấp";
            this.Ma_NCC.MinimumWidth = 8;
            this.Ma_NCC.Name = "Ma_NCC";
            this.Ma_NCC.Width = 110;
            // 
            // NSX
            // 
            this.NSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 8;
            this.NSX.Name = "NSX";
            this.NSX.Width = 63;
            // 
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 8;
            this.HSD.Name = "HSD";
            this.HSD.Width = 65;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 8;
            this.DVT.Name = "DVT";
            this.DVT.Width = 64;
            // 
            // So_Luong
            // 
            this.So_Luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.So_Luong.HeaderText = "Số lượng";
            this.So_Luong.MinimumWidth = 8;
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.Width = 83;
            // 
            // Don_Gia
            // 
            this.Don_Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Don_Gia.HeaderText = "Đơn giá";
            this.Don_Gia.MinimumWidth = 8;
            this.Don_Gia.Name = "Don_Gia";
            this.Don_Gia.Width = 76;
            // 
            // Thanh_Tien
            // 
            this.Thanh_Tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Thanh_Tien.HeaderText = "Thành tiền";
            this.Thanh_Tien.MinimumWidth = 8;
            this.Thanh_Tien.Name = "Thanh_Tien";
            this.Thanh_Tien.Width = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(21, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hoá đơn nhập";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1003, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "PRINT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // frmHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHDNhap";
            this.Text = "HDNhap";
            this.Load += new System.EventHandler(this.frmHDNhap_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dien_Giai;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Lo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanh_Tien;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}