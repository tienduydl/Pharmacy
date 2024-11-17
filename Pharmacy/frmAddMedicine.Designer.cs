namespace Pharmacy
{
    partial class frmAddMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectmaloai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adddvt = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adddongia = new System.Windows.Forms.TextBox();
            this.addmota = new System.Windows.Forms.TextBox();
            this.addhsqd = new System.Windows.Forms.TextBox();
            this.adddvtqd = new System.Windows.Forms.TextBox();
            this.addtenthuoc = new System.Windows.Forms.TextBox();
            this.addmathuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thêm thuốc";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtgianhap);
            this.panel3.Controls.Add(this.selectmaloai);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.adddvt);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.adddongia);
            this.panel3.Controls.Add(this.addmota);
            this.panel3.Controls.Add(this.addhsqd);
            this.panel3.Controls.Add(this.adddvtqd);
            this.panel3.Controls.Add(this.addtenthuoc);
            this.panel3.Controls.Add(this.addmathuoc);
            this.panel3.Location = new System.Drawing.Point(29, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 608);
            this.panel3.TabIndex = 16;
            // 
            // selectmaloai
            // 
            this.selectmaloai.FormattingEnabled = true;
            this.selectmaloai.Items.AddRange(new object[] {
            "Thuốc điều trị",
            "Thực phẩm chức năng",
            "Thuốc kháng sinh",
            "Thuốc giảm đau và chống viêm"});
            this.selectmaloai.Location = new System.Drawing.Point(849, 230);
            this.selectmaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectmaloai.Name = "selectmaloai";
            this.selectmaloai.Size = new System.Drawing.Size(180, 28);
            this.selectmaloai.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(845, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phân loại";
            // 
            // adddvt
            // 
            this.adddvt.FormattingEnabled = true;
            this.adddvt.Items.AddRange(new object[] {
            "Hộp",
            "Lọ"});
            this.adddvt.Location = new System.Drawing.Point(29, 130);
            this.adddvt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adddvt.Name = "adddvt";
            this.adddvt.Size = new System.Drawing.Size(180, 28);
            this.adddvt.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(26, 284);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 274);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Pharmacy.Properties.Resources.floppy_disk_solid1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(917, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lưu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(25, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Đơn giá bán";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(399, 279);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mô tả";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(696, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hệ số quy đổi";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(281, 96);
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
            this.label5.Location = new System.Drawing.Point(26, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đvt";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(279, 4);
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
            // adddongia
            // 
            this.adddongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adddongia.Location = new System.Drawing.Point(25, 224);
            this.adddongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adddongia.Multiline = true;
            this.adddongia.Name = "adddongia";
            this.adddongia.Size = new System.Drawing.Size(326, 34);
            this.adddongia.TabIndex = 0;
            // 
            // addmota
            // 
            this.addmota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addmota.Location = new System.Drawing.Point(404, 324);
            this.addmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addmota.Multiline = true;
            this.addmota.Name = "addmota";
            this.addmota.Size = new System.Drawing.Size(623, 155);
            this.addmota.TabIndex = 0;
            // 
            // addhsqd
            // 
            this.addhsqd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addhsqd.Location = new System.Drawing.Point(701, 125);
            this.addhsqd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addhsqd.Multiline = true;
            this.addhsqd.Name = "addhsqd";
            this.addhsqd.Size = new System.Drawing.Size(326, 34);
            this.addhsqd.TabIndex = 0;
            // 
            // adddvtqd
            // 
            this.adddvtqd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adddvtqd.Location = new System.Drawing.Point(285, 125);
            this.adddvtqd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adddvtqd.Multiline = true;
            this.adddvtqd.Name = "adddvtqd";
            this.adddvtqd.Size = new System.Drawing.Size(346, 34);
            this.adddvtqd.TabIndex = 0;
            // 
            // addtenthuoc
            // 
            this.addtenthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addtenthuoc.Location = new System.Drawing.Point(285, 40);
            this.addtenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addtenthuoc.Multiline = true;
            this.addtenthuoc.Name = "addtenthuoc";
            this.addtenthuoc.Size = new System.Drawing.Size(744, 34);
            this.addtenthuoc.TabIndex = 0;
            // 
            // addmathuoc
            // 
            this.addmathuoc.Location = new System.Drawing.Point(25, 40);
            this.addmathuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addmathuoc.Multiline = true;
            this.addmathuoc.Name = "addmathuoc";
            this.addmathuoc.Size = new System.Drawing.Size(180, 34);
            this.addmathuoc.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(404, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Đơn giá nhập";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgianhap.Location = new System.Drawing.Point(404, 224);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgianhap.Multiline = true;
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(326, 34);
            this.txtgianhap.TabIndex = 17;
            // 
            // frmAddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1171, 685);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddMedicine";
            this.Text = "frmAddMedicine";
            this.Load += new System.EventHandler(this.frmAddMedicine_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addmathuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adddongia;
        private System.Windows.Forms.TextBox addhsqd;
        private System.Windows.Forms.TextBox adddvtqd;
        private System.Windows.Forms.TextBox addtenthuoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addmota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox adddvt;
        private System.Windows.Forms.ComboBox selectmaloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgianhap;
    }
}