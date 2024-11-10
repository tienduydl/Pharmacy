namespace Pharmacy
{
    partial class frmCustomer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.PharmacyDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.khachHangTableAdapter = new Pharmacy.PharmacyDataSetTableAdapters.KhachHangTableAdapter();
            this.khachHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Ma_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadbutton = new System.Windows.Forms.Button();
            this.savesplbutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(30, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 45);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::Pharmacy.Properties.Resources.magnifying_glass_solid__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(197, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 21);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(0, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tìm kiếm theo tên";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_KH,
            this.Ten_KH,
            this.SDT,
            this.DiaChi,
            this.Email});
            this.dataGridView1.DataSource = this.khachHangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(625, 463);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh mục khách hàng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Pharmacy.Properties.Resources.notes_medical_solid__1_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(547, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tạo mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::Pharmacy.Properties.Resources.angles_right_solid1;
            this.btnLast.Location = new System.Drawing.Point(660, 188);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 30);
            this.btnLast.TabIndex = 24;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Pharmacy.Properties.Resources.chevron_left_solid1;
            this.btnNext.Location = new System.Drawing.Point(660, 159);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::Pharmacy.Properties.Resources.angles_left_solid1;
            this.btnFirst.Location = new System.Drawing.Point(660, 110);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(37, 32);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::Pharmacy.Properties.Resources.chevron_right_solid1;
            this.btnPrev.Location = new System.Drawing.Point(660, 137);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 32);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.savesplbutton);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtdiachi);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.txtsdt);
            this.panel3.Controls.Add(this.txthoten);
            this.panel3.Controls.Add(this.txtmakh);
            this.panel3.Location = new System.Drawing.Point(702, 99);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 464);
            this.panel3.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(19, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(19, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(19, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiachi.Location = new System.Drawing.Point(19, 347);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ReadOnly = true;
            this.txtdiachi.Size = new System.Drawing.Size(283, 27);
            this.txtdiachi.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Location = new System.Drawing.Point(19, 195);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(284, 27);
            this.txtemail.TabIndex = 0;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsdt.Location = new System.Drawing.Point(19, 271);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.ReadOnly = true;
            this.txtsdt.Size = new System.Drawing.Size(283, 27);
            this.txtsdt.TabIndex = 0;
            // 
            // txthoten
            // 
            this.txthoten.BackColor = System.Drawing.Color.White;
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthoten.Location = new System.Drawing.Point(19, 119);
            this.txthoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.ReadOnly = true;
            this.txthoten.Size = new System.Drawing.Size(284, 27);
            this.txthoten.TabIndex = 0;
            // 
            // txtmakh
            // 
            this.txtmakh.BackColor = System.Drawing.Color.White;
            this.txtmakh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmakh.Location = new System.Drawing.Point(19, 43);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakh.Multiline = true;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.ReadOnly = true;
            this.txtmakh.Size = new System.Drawing.Size(284, 27);
            this.txtmakh.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Image = global::Pharmacy.Properties.Resources.trash_solid1;
            this.button3.Location = new System.Drawing.Point(610, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 37);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Pharmacy.Properties.Resources.pen_to_square_solid1;
            this.button2.Location = new System.Drawing.Point(554, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 38);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangBindingSource1
            // 
            this.khachHangBindingSource1.DataMember = "KhachHang";
            this.khachHangBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // Ma_KH
            // 
            this.Ma_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ma_KH.DataPropertyName = "Ma_KH";
            this.Ma_KH.HeaderText = "Mã khách hàng";
            this.Ma_KH.MinimumWidth = 8;
            this.Ma_KH.Name = "Ma_KH";
            this.Ma_KH.Width = 117;
            // 
            // Ten_KH
            // 
            this.Ten_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_KH.DataPropertyName = "Ten_KH";
            this.Ten_KH.HeaderText = "Tên khách hàng";
            this.Ten_KH.MinimumWidth = 8;
            this.Ten_KH.Name = "Ten_KH";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 64;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 56;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 70;
            // 
            // reloadbutton
            // 
            this.reloadbutton.Image = global::Pharmacy.Properties.Resources.refresh;
            this.reloadbutton.Location = new System.Drawing.Point(486, 62);
            this.reloadbutton.Name = "reloadbutton";
            this.reloadbutton.Size = new System.Drawing.Size(40, 31);
            this.reloadbutton.TabIndex = 43;
            this.reloadbutton.UseVisualStyleBackColor = true;
            this.reloadbutton.Click += new System.EventHandler(this.reloadbutton_Click);
            // 
            // savesplbutton
            // 
            this.savesplbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savesplbutton.BackColor = System.Drawing.Color.Green;
            this.savesplbutton.FlatAppearance.BorderSize = 0;
            this.savesplbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesplbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savesplbutton.Image = global::Pharmacy.Properties.Resources.floppy_disk_solid1;
            this.savesplbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savesplbutton.Location = new System.Drawing.Point(221, 411);
            this.savesplbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savesplbutton.Name = "savesplbutton";
            this.savesplbutton.Size = new System.Drawing.Size(100, 30);
            this.savesplbutton.TabIndex = 15;
            this.savesplbutton.Text = "Lưu";
            this.savesplbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savesplbutton.UseVisualStyleBackColor = false;
            this.savesplbutton.Visible = false;
            this.savesplbutton.Click += new System.EventHandler(this.savesplbutton_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1127, 669);
            this.Controls.Add(this.reloadbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private PharmacyDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.BindingSource khachHangBindingSource1;
        private System.Windows.Forms.Button reloadbutton;
        private System.Windows.Forms.Button savesplbutton;
    }
}