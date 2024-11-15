namespace Pharmacy
{
    partial class loginscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginscreen));
            this.txtuserr = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.nutlg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtuser = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuserr
            // 
            this.txtuserr.Location = new System.Drawing.Point(233, 121);
            this.txtuserr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtuserr.Name = "txtuserr";
            this.txtuserr.Size = new System.Drawing.Size(183, 20);
            this.txtuserr.TabIndex = 0;
            this.txtuserr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(233, 178);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(183, 20);
            this.txtpassword.TabIndex = 2;
            // 
            // nutlg
            // 
            this.nutlg.Location = new System.Drawing.Point(262, 276);
            this.nutlg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nutlg.Name = "nutlg";
            this.nutlg.Size = new System.Drawing.Size(89, 32);
            this.nutlg.TabIndex = 3;
            this.nutlg.Text = "Log in";
            this.nutlg.UseVisualStyleBackColor = true;
            this.nutlg.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Location = new System.Drawing.Point(158, 121);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(58, 13);
            this.txtuser.TabIndex = 5;
            this.txtuser.Text = "Username:";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Location = new System.Drawing.Point(158, 180);
            this.txtpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(56, 13);
            this.txtpass.TabIndex = 6;
            this.txtpass.Text = "Password:";
            // 
            // loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(596, 342);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nutlg);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuserr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginscreen";
            this.Text = "loginscreen";
            this.Load += new System.EventHandler(this.loginscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button nutlg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.Label txtpass;
    }
}