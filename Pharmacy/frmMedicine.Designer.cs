namespace Pharmacy
{
    partial class frmMedicine
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh_QD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSquydoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh_Anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.danhMucThuocBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.selectmaloai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphanloai = new System.Windows.Forms.TextBox();
            this.medpic = new System.Windows.Forms.PictureBox();
            this.savemedbutton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txthsqd = new System.Windows.Forms.TextBox();
            this.txtdvtqd = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txttenthuoc = new System.Windows.Forms.TextBox();
            this.txtmathuoc = new System.Windows.Forms.TextBox();
            this.danhMucThuocTableAdapter1 = new Pharmacy.PharmacyDataSetTableAdapters.DanhMucThuocTableAdapter();
            this.reloadbutton = new System.Windows.Forms.Button();
            this.delmedbutton = new System.Windows.Forms.Button();
            this.editmedbutton = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.danhMucThuocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.danhMucThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.Ten_Loai,
            this.Donvitinh,
            this.Donvitinh_QD,
            this.HSquydoi,
            this.SLTonKho,
            this.DonGiaNhap,
            this.DG,
            this.MT,
            this.Hinh_Anh});
            this.dataGridView1.DataSource = this.danhMucThuocBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(662, 492);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "Ma_Thuoc";
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 111;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "Ten_Thuoc";
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 116;
            // 
            // Ten_Loai
            // 
            this.Ten_Loai.DataPropertyName = "Ten_Loai";
            this.Ten_Loai.HeaderText = "Phân loại";
            this.Ten_Loai.MinimumWidth = 6;
            this.Ten_Loai.Name = "Ten_Loai";
            this.Ten_Loai.Width = 110;
            // 
            // Donvitinh
            // 
            this.Donvitinh.DataPropertyName = "DVT";
            this.Donvitinh.HeaderText = "Đơn vị tính";
            this.Donvitinh.MinimumWidth = 6;
            this.Donvitinh.Name = "Donvitinh";
            this.Donvitinh.Width = 119;
            // 
            // Donvitinh_QD
            // 
            this.Donvitinh_QD.DataPropertyName = "DVT_QD";
            this.Donvitinh_QD.HeaderText = "Đơn vị tính quy đổi";
            this.Donvitinh_QD.MinimumWidth = 6;
            this.Donvitinh_QD.Name = "Donvitinh_QD";
            this.Donvitinh_QD.Width = 173;
            // 
            // HSquydoi
            // 
            this.HSquydoi.DataPropertyName = "HSQD";
            this.HSquydoi.HeaderText = "Hệ số quy đổi";
            this.HSquydoi.MinimumWidth = 6;
            this.HSquydoi.Name = "HSquydoi";
            this.HSquydoi.Width = 141;
            // 
            // SLTonKho
            // 
            this.SLTonKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SLTonKho.DataPropertyName = "SLTonKho";
            this.SLTonKho.HeaderText = "Lượng tồn kho";
            this.SLTonKho.MinimumWidth = 6;
            this.SLTonKho.Name = "SLTonKho";
            this.SLTonKho.Width = 147;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Giá nhập";
            this.DonGiaNhap.MinimumWidth = 8;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Width = 110;
            // 
            // DG
            // 
            this.DG.DataPropertyName = "DonGia";
            this.DG.HeaderText = "Đơn giá bán";
            this.DG.MinimumWidth = 6;
            this.DG.Name = "DG";
            this.DG.Width = 131;
            // 
            // MT
            // 
            this.MT.DataPropertyName = "Mo_ta";
            this.MT.HeaderText = "Mô tả";
            this.MT.MinimumWidth = 6;
            this.MT.Name = "MT";
            this.MT.Width = 85;
            // 
            // Hinh_Anh
            // 
            this.Hinh_Anh.DataPropertyName = "Hinh_Anh";
            this.Hinh_Anh.HeaderText = "Hình ảnh";
            this.Hinh_Anh.MinimumWidth = 6;
            this.Hinh_Anh.Name = "Hinh_Anh";
            this.Hinh_Anh.Visible = false;
            this.Hinh_Anh.Width = 79;
            // 
            // danhMucThuocBindingSource2
            // 
            this.danhMucThuocBindingSource2.DataMember = "DanhMucThuoc";
            this.danhMucThuocBindingSource2.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(37, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 56);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::Pharmacy.Properties.Resources.magnifying_glass_solid__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(222, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 26);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(0, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tìm kiếm theo tên";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtdongianhap);
            this.panel3.Controls.Add(this.selectmaloai);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtphanloai);
            this.panel3.Controls.Add(this.medpic);
            this.panel3.Controls.Add(this.savemedbutton);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtdongia);
            this.panel3.Controls.Add(this.txtmota);
            this.panel3.Controls.Add(this.txtsoluong);
            this.panel3.Controls.Add(this.txthsqd);
            this.panel3.Controls.Add(this.txtdvtqd);
            this.panel3.Controls.Add(this.txtdvt);
            this.panel3.Controls.Add(this.txttenthuoc);
            this.panel3.Controls.Add(this.txtmathuoc);
            this.panel3.Location = new System.Drawing.Point(753, 134);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 782);
            this.panel3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(21, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Đơn giá nhập";
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(21, 544);
            this.txtdongianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdongianhap.Multiline = true;
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.ReadOnly = true;
            this.txtdongianhap.Size = new System.Drawing.Size(213, 34);
            this.txtdongianhap.TabIndex = 18;
            // 
            // selectmaloai
            // 
            this.selectmaloai.FormattingEnabled = true;
            this.selectmaloai.Items.AddRange(new object[] {
            "Thuốc điều trị",
            "Thực phẩm chức năng",
            "Thuốc kháng sinh",
            "Thuốc giảm đau và chống viêm"});
            this.selectmaloai.Location = new System.Drawing.Point(20, 286);
            this.selectmaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectmaloai.Name = "selectmaloai";
            this.selectmaloai.Size = new System.Drawing.Size(214, 28);
            this.selectmaloai.TabIndex = 17;
            this.selectmaloai.Visible = false;
            this.selectmaloai.SelectedIndexChanged += new System.EventHandler(this.selectmaloai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phân loại";
            // 
            // txtphanloai
            // 
            this.txtphanloai.Location = new System.Drawing.Point(20, 280);
            this.txtphanloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphanloai.Multiline = true;
            this.txtphanloai.Name = "txtphanloai";
            this.txtphanloai.ReadOnly = true;
            this.txtphanloai.Size = new System.Drawing.Size(214, 54);
            this.txtphanloai.TabIndex = 15;
            // 
            // medpic
            // 
            this.medpic.Enabled = false;
            this.medpic.Location = new System.Drawing.Point(256, 22);
            this.medpic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.medpic.Name = "medpic";
            this.medpic.Size = new System.Drawing.Size(285, 198);
            this.medpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medpic.TabIndex = 14;
            this.medpic.TabStop = false;
            this.medpic.Click += new System.EventHandler(this.medpic_Click);
            this.medpic.Paint += new System.Windows.Forms.PaintEventHandler(this.medpic_Paint);
            // 
            // savemedbutton
            // 
            this.savemedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savemedbutton.BackColor = System.Drawing.Color.Green;
            this.savemedbutton.FlatAppearance.BorderSize = 0;
            this.savemedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savemedbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savemedbutton.Image = global::Pharmacy.Properties.Resources.floppy_disk_solid1;
            this.savemedbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savemedbutton.Location = new System.Drawing.Point(429, 722);
            this.savemedbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savemedbutton.Name = "savemedbutton";
            this.savemedbutton.Size = new System.Drawing.Size(112, 38);
            this.savemedbutton.TabIndex = 13;
            this.savemedbutton.Text = "Lưu";
            this.savemedbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savemedbutton.UseVisualStyleBackColor = false;
            this.savemedbutton.Visible = false;
            this.savemedbutton.Click += new System.EventHandler(this.savemedbutton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(252, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Đơn giá bán";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(26, 592);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mô tả";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(21, 420);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số lượng tồn kho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(251, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hệ số quy đổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(255, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đvt quy đổi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(21, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đvt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(21, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã thuốc";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(255, 456);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdongia.Multiline = true;
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(284, 34);
            this.txtdongia.TabIndex = 0;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(20, 619);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.ReadOnly = true;
            this.txtmota.Size = new System.Drawing.Size(518, 80);
            this.txtmota.TabIndex = 0;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(21, 456);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Multiline = true;
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.ReadOnly = true;
            this.txtsoluong.Size = new System.Drawing.Size(213, 34);
            this.txtsoluong.TabIndex = 0;
            // 
            // txthsqd
            // 
            this.txthsqd.Location = new System.Drawing.Point(255, 372);
            this.txthsqd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthsqd.Multiline = true;
            this.txthsqd.Name = "txthsqd";
            this.txthsqd.ReadOnly = true;
            this.txthsqd.Size = new System.Drawing.Size(284, 34);
            this.txthsqd.TabIndex = 0;
            // 
            // txtdvtqd
            // 
            this.txtdvtqd.Location = new System.Drawing.Point(255, 281);
            this.txtdvtqd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdvtqd.Multiline = true;
            this.txtdvtqd.Name = "txtdvtqd";
            this.txtdvtqd.ReadOnly = true;
            this.txtdvtqd.Size = new System.Drawing.Size(285, 34);
            this.txtdvtqd.TabIndex = 0;
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(21, 372);
            this.txtdvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdvt.Multiline = true;
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.ReadOnly = true;
            this.txtdvt.Size = new System.Drawing.Size(213, 34);
            this.txtdvt.TabIndex = 0;
            // 
            // txttenthuoc
            // 
            this.txttenthuoc.Location = new System.Drawing.Point(20, 134);
            this.txttenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenthuoc.Multiline = true;
            this.txttenthuoc.Name = "txttenthuoc";
            this.txttenthuoc.ReadOnly = true;
            this.txttenthuoc.Size = new System.Drawing.Size(214, 83);
            this.txttenthuoc.TabIndex = 0;
            // 
            // txtmathuoc
            // 
            this.txtmathuoc.Location = new System.Drawing.Point(21, 48);
            this.txtmathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmathuoc.Multiline = true;
            this.txtmathuoc.Name = "txtmathuoc";
            this.txtmathuoc.ReadOnly = true;
            this.txtmathuoc.Size = new System.Drawing.Size(213, 34);
            this.txtmathuoc.TabIndex = 0;
            // 
            // danhMucThuocTableAdapter1
            // 
            this.danhMucThuocTableAdapter1.ClearBeforeFill = true;
            // 
            // reloadbutton
            // 
            this.reloadbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reloadbutton.Image = global::Pharmacy.Properties.Resources.refresh;
            this.reloadbutton.Location = new System.Drawing.Point(507, 76);
            this.reloadbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reloadbutton.Name = "reloadbutton";
            this.reloadbutton.Size = new System.Drawing.Size(45, 49);
            this.reloadbutton.TabIndex = 41;
            this.reloadbutton.UseVisualStyleBackColor = true;
            this.reloadbutton.Click += new System.EventHandler(this.reloadbutton_Click);
            // 
            // delmedbutton
            // 
            this.delmedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delmedbutton.Image = global::Pharmacy.Properties.Resources.trash_solid1;
            this.delmedbutton.Location = new System.Drawing.Point(638, 650);
            this.delmedbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delmedbutton.Name = "delmedbutton";
            this.delmedbutton.Size = new System.Drawing.Size(44, 46);
            this.delmedbutton.TabIndex = 40;
            this.delmedbutton.UseVisualStyleBackColor = false;
            this.delmedbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // editmedbutton
            // 
            this.editmedbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editmedbutton.Image = global::Pharmacy.Properties.Resources.pen_to_square_solid1;
            this.editmedbutton.Location = new System.Drawing.Point(569, 651);
            this.editmedbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editmedbutton.Name = "editmedbutton";
            this.editmedbutton.Size = new System.Drawing.Size(47, 45);
            this.editmedbutton.TabIndex = 39;
            this.editmedbutton.UseVisualStyleBackColor = true;
            this.editmedbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::Pharmacy.Properties.Resources.angles_right_solid1;
            this.btnLast.Location = new System.Drawing.Point(705, 255);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(42, 39);
            this.btnLast.TabIndex = 35;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Pharmacy.Properties.Resources.chevron_left_solid1;
            this.btnNext.Location = new System.Drawing.Point(705, 225);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 29);
            this.btnNext.TabIndex = 36;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::Pharmacy.Properties.Resources.angles_left_solid1;
            this.btnFirst.Location = new System.Drawing.Point(705, 162);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(42, 41);
            this.btnFirst.TabIndex = 37;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::Pharmacy.Properties.Resources.chevron_right_solid1;
            this.btnPrev.Location = new System.Drawing.Point(705, 201);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 34);
            this.btnPrev.TabIndex = 38;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Pharmacy.Properties.Resources.notes_medical_solid__1_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(586, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tạo mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // danhMucThuocBindingSource
            // 
            this.danhMucThuocBindingSource.DataMember = "DanhMucThuoc";
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1365, 948);
            this.Controls.Add(this.reloadbutton);
            this.Controls.Add(this.delmedbutton);
            this.Controls.Add(this.editmedbutton);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMedicine";
            this.Text = "frmMedicine";
            this.Load += new System.EventHandler(this.frmMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucThuocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PharmacyDataSet PharmacyDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txthsqd;
        private System.Windows.Forms.TextBox txtdvtqd;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txttenthuoc;
        private System.Windows.Forms.TextBox txtmathuoc;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button editmedbutton;
        private System.Windows.Forms.Button delmedbutton;
        private System.Windows.Forms.BindingSource danhMucThuocBindingSource;
        
        private System.Windows.Forms.BindingSource danhMucThuocBindingSource1;
        private PharmacyDataSetTableAdapters.DanhMucThuocTableAdapter danhMucThuocTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThuocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSQDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgaySudungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT_QD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSQD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo_Ta;
        private System.Windows.Forms.Button savemedbutton;
        private System.Windows.Forms.PictureBox medpic;
        private System.Windows.Forms.BindingSource danhMucThuocBindingSource2;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphanloai;
        private System.Windows.Forms.Button reloadbutton;
        private System.Windows.Forms.ComboBox selectmaloai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh_QD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSquydoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MT;
        private System.Windows.Forms.DataGridViewImageColumn Hinh_Anh;
    }
}