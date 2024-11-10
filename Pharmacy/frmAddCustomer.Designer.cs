namespace Pharmacy
{
    partial class frmAddCustomer
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
            this.savebutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.SeaGreen;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebutton.Image = global::Pharmacy.Properties.Resources.floppy_disk_solid1;
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebutton.Location = new System.Drawing.Point(450, 233);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(100, 30);
            this.savebutton.TabIndex = 12;
            this.savebutton.Text = "Lưu";
            this.savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(18, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(241, 76);
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
            this.label8.Location = new System.Drawing.Point(20, 76);
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
            this.label4.Location = new System.Drawing.Point(240, 9);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thêm khách hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.savebutton);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtdiachi);
            this.panel3.Controls.Add(this.txtemail);
            this.panel3.Controls.Add(this.txtsdt);
            this.panel3.Controls.Add(this.txthoten);
            this.panel3.Controls.Add(this.txtmakh);
            this.panel3.Location = new System.Drawing.Point(27, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 298);
            this.panel3.TabIndex = 22;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(22, 172);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(528, 28);
            this.txtdiachi.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(245, 99);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(305, 28);
            this.txtemail.TabIndex = 0;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(23, 99);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdt.Multiline = true;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(155, 28);
            this.txtsdt.TabIndex = 0;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(244, 32);
            this.txthoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthoten.Multiline = true;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(306, 28);
            this.txthoten.TabIndex = 0;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(22, 32);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakh.Multiline = true;
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(155, 28);
            this.txtmakh.TabIndex = 0;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(652, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmakh;
    }
}