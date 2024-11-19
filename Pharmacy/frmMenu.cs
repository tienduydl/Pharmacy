using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmMenu : Form
    {
        private Form currentFormChild;
        public frmMenu()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmployee());
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMedicine());
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomer());
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSupplier());
        }

        private void nhậpMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddHDN());
        }

        private void nhậpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddHDB());
        }

        private void xuấtThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmxuatthuoc());
        }

        private void thôngTinUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInfo());
        }

        private void nhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bánThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHDNhap());
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoChiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportCost());
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportRevenue());
        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportStock());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHDBan());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmlogin login = new frmlogin();
            login.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void báoCáoThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExpiredReport());
        }
    }
}
