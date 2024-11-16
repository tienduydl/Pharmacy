namespace Pharmacy
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuManager = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMớiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bánThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoChiPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.thôngTinUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuManager.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuManager
            // 
            this.menuManager.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuManager.Dock = System.Windows.Forms.DockStyle.None;
            this.menuManager.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.nhậpThuốcToolStripMenuItem,
            this.bánThuốcToolStripMenuItem,
            this.xuấtThuốcToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.toolStripSeparator5,
            this.thôngTinUserToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuManager.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuManager.Location = new System.Drawing.Point(4, 142);
            this.menuManager.Name = "menuManager";
            this.menuManager.Padding = new System.Windows.Forms.Padding(8, 7, 0, 2);
            this.menuManager.Size = new System.Drawing.Size(169, 437);
            this.menuManager.TabIndex = 0;
            this.menuManager.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.toolStripSeparator1,
            this.thuốcToolStripMenuItem,
            this.toolStripSeparator3,
            this.kháchHàngToolStripMenuItem,
            this.toolStripSeparator2,
            this.nhàCungCấpToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.danhMụcToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.bars_solid;
            this.danhMụcToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.users_solid;
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // thuốcToolStripMenuItem
            // 
            this.thuốcToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.pills_solid;
            this.thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            this.thuốcToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.thuốcToolStripMenuItem.Text = "Thuốc";
            this.thuốcToolStripMenuItem.Click += new System.EventHandler(this.thuốcToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.address_book_solid;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.handshake_regular;
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // nhậpThuốcToolStripMenuItem
            // 
            this.nhậpThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnNhậpToolStripMenuItem,
            this.nhậpMớiToolStripMenuItem1});
            this.nhậpThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nhậpThuốcToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.truck_solid;
            this.nhậpThuốcToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhậpThuốcToolStripMenuItem.Name = "nhậpThuốcToolStripMenuItem";
            this.nhậpThuốcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.nhậpThuốcToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.nhậpThuốcToolStripMenuItem.Text = "Nhập thuốc";
            this.nhậpThuốcToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nhậpThuốcToolStripMenuItem.Click += new System.EventHandler(this.nhậpThuốcToolStripMenuItem_Click);
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hóaĐơnNhậpToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.print_solid;
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập";
            this.hóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click);
            // 
            // nhậpMớiToolStripMenuItem1
            // 
            this.nhậpMớiToolStripMenuItem1.Image = global::Pharmacy.Properties.Resources.cart_plus_solid;
            this.nhậpMớiToolStripMenuItem1.Name = "nhậpMớiToolStripMenuItem1";
            this.nhậpMớiToolStripMenuItem1.Size = new System.Drawing.Size(205, 28);
            this.nhậpMớiToolStripMenuItem1.Text = "Nhập mới";
            this.nhậpMớiToolStripMenuItem1.Click += new System.EventHandler(this.nhậpMớiToolStripMenuItem1_Click);
            // 
            // bánThuốcToolStripMenuItem
            // 
            this.bánThuốcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HóaĐơnBánToolStripMenuItem,
            this.nhậpMớiToolStripMenuItem});
            this.bánThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bánThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bánThuốcToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.receipt_solid;
            this.bánThuốcToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bánThuốcToolStripMenuItem.Name = "bánThuốcToolStripMenuItem";
            this.bánThuốcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.bánThuốcToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.bánThuốcToolStripMenuItem.Text = "Bán thuốc";
            this.bánThuốcToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bánThuốcToolStripMenuItem.Click += new System.EventHandler(this.bánThuốcToolStripMenuItem_Click);
            // 
            // HóaĐơnBánToolStripMenuItem
            // 
            this.HóaĐơnBánToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HóaĐơnBánToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.document_png;
            this.HóaĐơnBánToolStripMenuItem.Name = "HóaĐơnBánToolStripMenuItem";
            this.HóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.HóaĐơnBánToolStripMenuItem.Text = "Hóa đơn bán";
            this.HóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // nhậpMớiToolStripMenuItem
            // 
            this.nhậpMớiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpMớiToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.add;
            this.nhậpMớiToolStripMenuItem.Name = "nhậpMớiToolStripMenuItem";
            this.nhậpMớiToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.nhậpMớiToolStripMenuItem.Text = "Nhập mới";
            this.nhậpMớiToolStripMenuItem.Click += new System.EventHandler(this.nhậpMớiToolStripMenuItem_Click);
            // 
            // xuấtThuốcToolStripMenuItem
            // 
            this.xuấtThuốcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuấtThuốcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xuấtThuốcToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.shop_solid;
            this.xuấtThuốcToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuấtThuốcToolStripMenuItem.Name = "xuấtThuốcToolStripMenuItem";
            this.xuấtThuốcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.xuấtThuốcToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.xuấtThuốcToolStripMenuItem.Text = "Xuất thuốc";
            this.xuấtThuốcToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuấtThuốcToolStripMenuItem.Click += new System.EventHandler(this.xuấtThuốcToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoChiPhíToolStripMenuItem,
            this.báoCáoDoanhThuToolStripMenuItem,
            this.báoCáoTồnKhoToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.báoCáoToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.chart_simple_solid;
            this.báoCáoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // báoCáoChiPhíToolStripMenuItem
            // 
            this.báoCáoChiPhíToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.money_bag;
            this.báoCáoChiPhíToolStripMenuItem.Name = "báoCáoChiPhíToolStripMenuItem";
            this.báoCáoChiPhíToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.báoCáoChiPhíToolStripMenuItem.Text = "Báo cáo chi phí";
            this.báoCáoChiPhíToolStripMenuItem.Click += new System.EventHandler(this.báoCáoChiPhíToolStripMenuItem_Click);
            // 
            // báoCáoDoanhThuToolStripMenuItem
            // 
            this.báoCáoDoanhThuToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.file_contract_solid;
            this.báoCáoDoanhThuToolStripMenuItem.Name = "báoCáoDoanhThuToolStripMenuItem";
            this.báoCáoDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.báoCáoDoanhThuToolStripMenuItem.Text = "Báo cáo doanh thu";
            this.báoCáoDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuToolStripMenuItem_Click);
            // 
            // báoCáoTồnKhoToolStripMenuItem
            // 
            this.báoCáoTồnKhoToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.boxes;
            this.báoCáoTồnKhoToolStripMenuItem.Name = "báoCáoTồnKhoToolStripMenuItem";
            this.báoCáoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.báoCáoTồnKhoToolStripMenuItem.Text = "Báo cáo tồn kho";
            this.báoCáoTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTồnKhoToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(160, 6);
            // 
            // thôngTinUserToolStripMenuItem
            // 
            this.thôngTinUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.thôngTinUserToolStripMenuItem.Image = global::Pharmacy.Properties.Resources.user_regular;
            this.thôngTinUserToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thôngTinUserToolStripMenuItem.Name = "thôngTinUserToolStripMenuItem";
            this.thôngTinUserToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 20, 6, 0);
            this.thôngTinUserToolStripMenuItem.Size = new System.Drawing.Size(160, 48);
            this.thôngTinUserToolStripMenuItem.Text = "Thông tin user";
            this.thôngTinUserToolStripMenuItem.Click += new System.EventHandler(this.thôngTinUserToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 80, 6, 0);
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 108);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHARMACY";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuManager);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 616);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 616);
            this.panel2.TabIndex = 4;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1024, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuManager;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Pharmacy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuManager.ResumeLayout(false);
            this.menuManager.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuManager;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem nhậpThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem HóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpMớiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoChiPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem;
    }
}

