namespace Pharmacy
{
    partial class ProductItem
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
            this.giathuoclabel = new System.Windows.Forms.TextBox();
            this.soluongbaninput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mednamelabel = new System.Windows.Forms.Label();
            this.hinhanhthuoc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soluongbaninput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // giathuoclabel
            // 
            this.giathuoclabel.Location = new System.Drawing.Point(81, 111);
            this.giathuoclabel.Name = "giathuoclabel";
            this.giathuoclabel.Size = new System.Drawing.Size(105, 22);
            this.giathuoclabel.TabIndex = 19;
            // 
            // soluongbaninput
            // 
            this.soluongbaninput.Location = new System.Drawing.Point(81, 139);
            this.soluongbaninput.Name = "soluongbaninput";
            this.soluongbaninput.Size = new System.Drawing.Size(78, 22);
            this.soluongbaninput.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số lượng:";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá bán:";
            // 
            // mednamelabel
            // 
            this.mednamelabel.AutoSize = true;
            this.mednamelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednamelabel.Location = new System.Drawing.Point(106, 81);
            this.mednamelabel.Name = "mednamelabel";
            this.mednamelabel.Size = new System.Drawing.Size(76, 20);
            this.mednamelabel.TabIndex = 14;
            this.mednamelabel.Text = "Tên thuốc";
            // 
            // hinhanhthuoc
            // 
            this.hinhanhthuoc.Image = global::Pharmacy.Properties.Resources.image_2__1_;
            this.hinhanhthuoc.Location = new System.Drawing.Point(101, 11);
            this.hinhanhthuoc.Name = "hinhanhthuoc";
            this.hinhanhthuoc.Size = new System.Drawing.Size(86, 64);
            this.hinhanhthuoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanhthuoc.TabIndex = 13;
            this.hinhanhthuoc.TabStop = false;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.giathuoclabel);
            this.Controls.Add(this.soluongbaninput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mednamelabel);
            this.Controls.Add(this.hinhanhthuoc);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(305, 193);
            ((System.ComponentModel.ISupportInitialize)(this.soluongbaninput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhthuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox giathuoclabel;
        private System.Windows.Forms.NumericUpDown soluongbaninput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mednamelabel;
        private System.Windows.Forms.PictureBox hinhanhthuoc;
    }
}
