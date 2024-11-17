namespace Pharmacy
{
    partial class frmReportCost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comFilter = new System.Windows.Forms.ComboBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.resetfilterbutt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rptCost = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(608, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "BÁO CÁO CHI PHÍ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Báo cáo chi phí";
            // 
            // comFilter
            // 
            this.comFilter.FormattingEnabled = true;
            this.comFilter.Location = new System.Drawing.Point(819, 111);
            this.comFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comFilter.Name = "comFilter";
            this.comFilter.Size = new System.Drawing.Size(162, 28);
            this.comFilter.TabIndex = 62;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(542, 112);
            this.dtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(142, 26);
            this.dtTo.TabIndex = 61;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(274, 111);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(140, 26);
            this.dtFrom.TabIndex = 60;
            // 
            // resetfilterbutt
            // 
            this.resetfilterbutt.BackColor = System.Drawing.Color.Navy;
            this.resetfilterbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetfilterbutt.ForeColor = System.Drawing.Color.White;
            this.resetfilterbutt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetfilterbutt.Location = new System.Drawing.Point(1021, 108);
            this.resetfilterbutt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetfilterbutt.Name = "resetfilterbutt";
            this.resetfilterbutt.Size = new System.Drawing.Size(79, 32);
            this.resetfilterbutt.TabIndex = 59;
            this.resetfilterbutt.Text = "Reset";
            this.resetfilterbutt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.resetfilterbutt.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Từ ngày :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Lọc theo:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Brown;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Image = global::Pharmacy.Properties.Resources.notes_medical_solid__1_1;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(1135, 107);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(79, 32);
            this.btnCreate.TabIndex = 58;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rptCost
            // 
            this.rptCost.Location = new System.Drawing.Point(44, 155);
            this.rptCost.Name = "rptCost";
            this.rptCost.ServerReport.BearerToken = null;
            this.rptCost.Size = new System.Drawing.Size(1339, 557);
            this.rptCost.TabIndex = 63;
            // 
            // frmReportCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1417, 724);
            this.Controls.Add(this.rptCost);
            this.Controls.Add(this.comFilter);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.resetfilterbutt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReportCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReportCost";
            this.Load += new System.EventHandler(this.frmReportCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comFilter;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button resetfilterbutt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private Microsoft.Reporting.WinForms.ReportViewer rptCost;
    }
}