using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ProductXuat : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public ProductXuat()
        {
            InitializeComponent();
        }
        public string MaThuoc { get { return txtmathuoc.Text; }
            set
            {
                txtmathuoc.Text = value;
            }
        }
        public string TenThuoc
        {
            get
            {
                return txttenthuoc.Text;
            }
            set
            {
                txttenthuoc.Text = value;
            }
        }
        public Image HinhAnh
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string NhaCungCap { get { return txtncc.Text; } set { txtncc.Text = value; } }
        public string nsx { get { return txtnsx.Text; } set { txtnsx.Text = value; } }
        public string hsd { get { return txthsd.Text; } set { txthsd.Text = value; } }
        public string slton { get { return txtslton.Text; }
            set { txtslton.Text = value; } }
        public decimal slgoc { get { return selectsoluong1.Value; } set { selectsoluong1.Value = value; } }
        public decimal slquydoi { get { return selectsoluong2.Value; } set { selectsoluong2.Value = value; } }
        public string matonkho { get { return txtmaton.Text; } set { txtmaton.Text = value; } }
        public decimal hesoquydoi { get; set; }
        public string donvitinh { get; set; }
        public event EventHandler AddClickedXuat;
        private void addbutton_Click(object sender, EventArgs e)
        {
            AddClickedXuat?.Invoke(this, EventArgs.Empty);
        }

        private void ProductXuat_Load(object sender, EventArgs e)
        {
         
        }
    }
}
