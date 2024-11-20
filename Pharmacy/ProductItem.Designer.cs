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
            this.medcodelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectsoluong2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.soluongbaninput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhthuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectsoluong2)).BeginInit();
            this.SuspendLayout();
            // 
            // giathuoclabel
            // 
            this.giathuoclabel.Location = new System.Drawing.Point(108, 121);
            this.giathuoclabel.Name = "giathuoclabel";
            this.giathuoclabel.Size = new System.Drawing.Size(105, 22);
            this.giathuoclabel.TabIndex = 19;
            // 
            // soluongbaninput
            // 
            this.soluongbaninput.Location = new System.Drawing.Point(135, 149);
            this.soluongbaninput.Name = "soluongbaninput";
            this.soluongbaninput.Size = new System.Drawing.Size(78, 22);
            this.soluongbaninput.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số lượng (Gốc):";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 142);
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
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Giá bán:";
            // 
            // mednamelabel
            // 
            this.mednamelabel.AutoSize = true;
            this.mednamelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednamelabel.Location = new System.Drawing.Point(106, 91);
            this.mednamelabel.Name = "mednamelabel";
            this.mednamelabel.Size = new System.Drawing.Size(76, 20);
            this.mednamelabel.TabIndex = 14;
            this.mednamelabel.Text = "Tên thuốc";
            this.mednamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hinhanhthuoc
            // 
            this.hinhanhthuoc.Image = global::Pharmacy.Properties.Resources.image_2__1_;
            this.hinhanhthuoc.Location = new System.Drawing.Point(101, 21);
            this.hinhanhthuoc.Name = "hinhanhthuoc";
            this.hinhanhthuoc.Size = new System.Drawing.Size(86, 64);
            this.hinhanhthuoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhanhthuoc.TabIndex = 13;
            this.hinhanhthuoc.TabStop = false;
            // 
            // medcodelabel
            // 
            this.medcodelabel.AutoSize = true;
            this.medcodelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medcodelabel.Location = new System.Drawing.Point(9, 21);
            this.medcodelabel.Name = "medcodelabel";
            this.medcodelabel.Size = new System.Drawing.Size(75, 20);
            this.medcodelabel.TabIndex = 20;
            this.medcodelabel.Text = "Mã thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số lượng (Quy đổi):";
            // 
            // selectsoluong2
            // 
            this.selectsoluong2.Location = new System.Drawing.Point(135, 177);
            this.selectsoluong2.Name = "selectsoluong2";
            this.selectsoluong2.Size = new System.Drawing.Size(78, 22);
            this.selectsoluong2.TabIndex = 36;
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectsoluong2);
            this.Controls.Add(this.medcodelabel);
            this.Controls.Add(this.giathuoclabel);
            this.Controls.Add(this.soluongbaninput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mednamelabel);
            this.Controls.Add(this.hinhanhthuoc);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(303, 213);
            ((System.ComponentModel.ISupportInitialize)(this.soluongbaninput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhthuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectsoluong2)).EndInit();
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
        private System.Windows.Forms.Label medcodelabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown selectsoluong2;
    }
}
