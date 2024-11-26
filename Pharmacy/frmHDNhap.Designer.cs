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
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdiengiai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtngayhdn = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmahdn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CTHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Ma_Lo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Don_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanh_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.reloadbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(709, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hoá đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dataGridView1.Size = new System.Drawing.Size(691, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ma_CT
            // 
            this.Ma_CT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_CT.DataPropertyName = "Ma_CT";
            this.Ma_CT.HeaderText = "Mã hoá đơn";
            this.Ma_CT.MinimumWidth = 8;
            this.Ma_CT.Name = "Ma_CT";
            this.Ma_CT.Width = 107;
            // 
            // Ngay_CT
            // 
            this.Ngay_CT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ngay_CT.DataPropertyName = "Ngay_CT";
            this.Ngay_CT.HeaderText = "Ngày";
            this.Ngay_CT.MinimumWidth = 8;
            this.Ngay_CT.Name = "Ngay_CT";
            this.Ngay_CT.Width = 69;
            // 
            // Ma_NV
            // 
            this.Ma_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân Viên";
            this.Ma_NV.MinimumWidth = 8;
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.Width = 120;
            // 
            // Tong_tien
            // 
            this.Tong_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tong_tien.DataPropertyName = "Tong_tien";
            this.Tong_tien.HeaderText = "Tổng tiền";
            this.Tong_tien.MinimumWidth = 8;
            this.Tong_tien.Name = "Tong_tien";
            this.Tong_tien.Width = 92;
            // 
            // Dien_Giai
            // 
            this.Dien_Giai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dien_Giai.DataPropertyName = "Dien_Giai";
            this.Dien_Giai.HeaderText = "Diễn giải";
            this.Dien_Giai.MinimumWidth = 8;
            this.Dien_Giai.Name = "Dien_Giai";
            this.Dien_Giai.Width = 89;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterbutton);
            this.groupBox2.Controls.Add(this.reloadbutton);
            this.groupBox2.Controls.Add(this.enddate);
            this.groupBox2.Controls.Add(this.startdate);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(707, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ lọc phiếu nhập";
            // 
            // enddate
            // 
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.Location = new System.Drawing.Point(377, 81);
            this.enddate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(145, 22);
            this.enddate.TabIndex = 11;
            // 
            // startdate
            // 
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(97, 81);
            this.startdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(143, 22);
            this.startdate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày :";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(97, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Tìm theo mã hóa đơn";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdiengiai);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txttongtien);
            this.groupBox3.Controls.Add(this.txtngayhdn);
            this.groupBox3.Controls.Add(this.txtmanv);
            this.groupBox3.Controls.Add(this.txtmahdn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(773, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1005, 574);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phiếu nhập";
            // 
            // txtdiengiai
            // 
            this.txtdiengiai.Location = new System.Drawing.Point(117, 105);
            this.txtdiengiai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiengiai.Multiline = true;
            this.txtdiengiai.Name = "txtdiengiai";
            this.txtdiengiai.Size = new System.Drawing.Size(516, 43);
            this.txtdiengiai.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Diễn giải:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(411, 69);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(223, 22);
            this.txttongtien.TabIndex = 8;
            // 
            // txtngayhdn
            // 
            this.txtngayhdn.Location = new System.Drawing.Point(411, 31);
            this.txtngayhdn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngayhdn.Name = "txtngayhdn";
            this.txtngayhdn.Size = new System.Drawing.Size(223, 22);
            this.txtngayhdn.TabIndex = 7;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(117, 69);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(223, 22);
            this.txtmanv.TabIndex = 6;
            // 
            // txtmahdn
            // 
            this.txtmahdn.Location = new System.Drawing.Point(117, 31);
            this.txtmahdn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahdn.Name = "txtmahdn";
            this.txtmahdn.Size = new System.Drawing.Size(223, 22);
            this.txtmahdn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 74);
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
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(21, 34);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(84, 16);
            this.lb.TabIndex = 1;
            this.lb.Text = "Mã hoá đơn: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CTHoaDonNhap);
            this.groupBox4.Location = new System.Drawing.Point(16, 150);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(953, 398);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hoá đơn";
            // 
            // CTHoaDonNhap
            // 
            this.CTHoaDonNhap.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CTHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Lo,
            this.Ma_Thuoc,
            this.Ten_NCC,
            this.NSX,
            this.HSD,
            this.DVT,
            this.So_Luong,
            this.Don_Gia,
            this.Thanh_Tien});
            this.CTHoaDonNhap.Location = new System.Drawing.Point(11, 22);
            this.CTHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CTHoaDonNhap.Name = "CTHoaDonNhap";
            this.CTHoaDonNhap.RowHeadersWidth = 62;
            this.CTHoaDonNhap.RowTemplate.Height = 28;
            this.CTHoaDonNhap.Size = new System.Drawing.Size(937, 375);
            this.CTHoaDonNhap.TabIndex = 0;
            // 
            // Ma_Lo
            // 
            this.Ma_Lo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_Lo.DataPropertyName = "Ma_Lo";
            this.Ma_Lo.HeaderText = "Mã Lô";
            this.Ma_Lo.MinimumWidth = 8;
            this.Ma_Lo.Name = "Ma_Lo";
            this.Ma_Lo.Width = 73;
            // 
            // Ma_Thuoc
            // 
            this.Ma_Thuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_Thuoc.DataPropertyName = "Ma_Thuoc";
            this.Ma_Thuoc.HeaderText = "Ten thuoc";
            this.Ma_Thuoc.MinimumWidth = 8;
            this.Ma_Thuoc.Name = "Ma_Thuoc";
            this.Ma_Thuoc.Width = 95;
            // 
            // Ten_NCC
            // 
            this.Ten_NCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten_NCC.DataPropertyName = "Ten_NCC";
            this.Ten_NCC.HeaderText = "Nhà cung cấp";
            this.Ten_NCC.MinimumWidth = 8;
            this.Ten_NCC.Name = "Ten_NCC";
            this.Ten_NCC.Width = 119;
            // 
            // NSX
            // 
            this.NSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 8;
            this.NSX.Name = "NSX";
            this.NSX.Width = 63;
            // 
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 8;
            this.HSD.Name = "HSD";
            this.HSD.Width = 65;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 8;
            this.DVT.Name = "DVT";
            this.DVT.Width = 64;
            // 
            // So_Luong
            // 
            this.So_Luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.So_Luong.DataPropertyName = "So_Luong";
            this.So_Luong.HeaderText = "Số lượng";
            this.So_Luong.MinimumWidth = 8;
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.Width = 89;
            // 
            // Don_Gia
            // 
            this.Don_Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Don_Gia.DataPropertyName = "Don_Gia";
            this.Don_Gia.HeaderText = "Đơn giá";
            this.Don_Gia.MinimumWidth = 8;
            this.Don_Gia.Name = "Don_Gia";
            this.Don_Gia.Width = 82;
            // 
            // Thanh_Tien
            // 
            this.Thanh_Tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Thanh_Tien.DataPropertyName = "Thanh_Tien";
            this.Thanh_Tien.HeaderText = "Thành tiền";
            this.Thanh_Tien.MinimumWidth = 8;
            this.Thanh_Tien.Name = "Thanh_Tien";
            this.Thanh_Tien.Width = 98;
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
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::Pharmacy.Properties.Resources.angles_right_solid1;
            this.btnLast.Location = new System.Drawing.Point(731, 273);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 32);
            this.btnLast.TabIndex = 43;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Pharmacy.Properties.Resources.chevron_left_solid1;
            this.btnNext.Location = new System.Drawing.Point(731, 250);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 25);
            this.btnNext.TabIndex = 44;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::Pharmacy.Properties.Resources.angles_left_solid1;
            this.btnFirst.Location = new System.Drawing.Point(731, 199);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(37, 34);
            this.btnFirst.TabIndex = 45;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::Pharmacy.Properties.Resources.chevron_right_solid1;
            this.btnPrev.Location = new System.Drawing.Point(731, 231);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 28);
            this.btnPrev.TabIndex = 46;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1650, 628);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "PRINT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filterbutton.Image = global::Pharmacy.Properties.Resources.filter;
            this.filterbutton.Location = new System.Drawing.Point(583, 33);
            this.filterbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(87, 36);
            this.filterbutton.TabIndex = 45;
            this.filterbutton.Text = "Lọc";
            this.filterbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // reloadbutton
            // 
            this.reloadbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reloadbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reloadbutton.Image = global::Pharmacy.Properties.Resources.refresh;
            this.reloadbutton.Location = new System.Drawing.Point(583, 75);
            this.reloadbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reloadbutton.Name = "reloadbutton";
            this.reloadbutton.Size = new System.Drawing.Size(87, 36);
            this.reloadbutton.TabIndex = 44;
            this.reloadbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reloadbutton.UseVisualStyleBackColor = false;
            this.reloadbutton.Click += new System.EventHandler(this.reloadbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Pharmacy.Properties.Resources.magnifying_glass_solid__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(495, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 18);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // frmHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1811, 769);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmahdn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txtngayhdn;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CTHoaDonNhap;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.Button reloadbutton;
        private System.Windows.Forms.TextBox txtdiengiai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dien_Giai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Lo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Don_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanh_Tien;
    }
}