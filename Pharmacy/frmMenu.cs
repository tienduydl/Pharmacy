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
            OpenChildForm(new AddPhieuXuat());
        }

        private void thôngTinUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserInfo());
        }

        private void nhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
