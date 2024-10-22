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
    public partial class EmployeeMenu : Form
    {
        private Form currentFormChild;
        public EmployeeMenu()
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
        private void nhậpThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuManager_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bánThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhậpMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddMedicine());
        }

        private void nhậpMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddHDB());
        }
    }
}
