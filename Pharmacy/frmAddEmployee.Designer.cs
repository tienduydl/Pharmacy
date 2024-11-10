namespace Pharmacy
{
    partial class frmAddEmployee
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtempchucvu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.addpassword = new System.Windows.Forms.TextBox();
            this.addusername = new System.Windows.Forms.TextBox();
            this.addempemail = new System.Windows.Forms.TextBox();
            this.addempsdt = new System.Windows.Forms.TextBox();
            this.addempten = new System.Windows.Forms.TextBox();
            this.addempcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(19, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(19, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(334, 89);
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
            this.label8.Location = new System.Drawing.Point(334, 174);
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
            this.label4.Location = new System.Drawing.Point(334, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thêm nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtempchucvu);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.savebutton);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addpassword);
            this.panel3.Controls.Add(this.addusername);
            this.panel3.Controls.Add(this.addempemail);
            this.panel3.Controls.Add(this.addempsdt);
            this.panel3.Controls.Add(this.addempten);
            this.panel3.Controls.Add(this.addempcode);
            this.panel3.Location = new System.Drawing.Point(37, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 382);
            this.panel3.TabIndex = 19;
            // 
            // txtempchucvu
            // 
            this.txtempchucvu.FormattingEnabled = true;
            this.txtempchucvu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.txtempchucvu.Location = new System.Drawing.Point(21, 112);
            this.txtempchucvu.Name = "txtempchucvu";
            this.txtempchucvu.Size = new System.Drawing.Size(240, 24);
            this.txtempchucvu.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chức vụ";
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Green;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebutton.Image = global::Pharmacy.Properties.Resources.floppy_disk_solid1;
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebutton.Location = new System.Drawing.Point(705, 325);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(100, 30);
            this.savebutton.TabIndex = 13;
            this.savebutton.Text = "Lưu";
            this.savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // addpassword
            // 
            this.addpassword.Location = new System.Drawing.Point(21, 274);
            this.addpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addpassword.Multiline = true;
            this.addpassword.Name = "addpassword";
            this.addpassword.Size = new System.Drawing.Size(240, 28);
            this.addpassword.TabIndex = 0;
            // 
            // addusername
            // 
            this.addusername.Location = new System.Drawing.Point(21, 196);
            this.addusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addusername.Multiline = true;
            this.addusername.Name = "addusername";
            this.addusername.Size = new System.Drawing.Size(239, 28);
            this.addusername.TabIndex = 0;
            // 
            // addempemail
            // 
            this.addempemail.Location = new System.Drawing.Point(337, 112);
            this.addempemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addempemail.Multiline = true;
            this.addempemail.Name = "addempemail";
            this.addempemail.Size = new System.Drawing.Size(239, 28);
            this.addempemail.TabIndex = 0;
            // 
            // addempsdt
            // 
            this.addempsdt.Location = new System.Drawing.Point(337, 196);
            this.addempsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addempsdt.Multiline = true;
            this.addempsdt.Name = "addempsdt";
            this.addempsdt.Size = new System.Drawing.Size(239, 28);
            this.addempsdt.TabIndex = 0;
            // 
            // addempten
            // 
            this.addempten.Location = new System.Drawing.Point(337, 30);
            this.addempten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addempten.Multiline = true;
            this.addempten.Name = "addempten";
            this.addempten.Size = new System.Drawing.Size(239, 28);
            this.addempten.TabIndex = 0;
            // 
            // addempcode
            // 
            this.addempcode.Location = new System.Drawing.Point(22, 32);
            this.addempcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addempcode.Multiline = true;
            this.addempcode.Name = "addempcode";
            this.addempcode.Size = new System.Drawing.Size(239, 28);
            this.addempcode.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(646, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 237);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(919, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox addpassword;
        private System.Windows.Forms.TextBox addusername;
        private System.Windows.Forms.TextBox addempemail;
        private System.Windows.Forms.TextBox addempsdt;
        private System.Windows.Forms.TextBox addempten;
        private System.Windows.Forms.TextBox addempcode;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtempchucvu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}