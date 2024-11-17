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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy
{
    public partial class ProductNhap : UserControl
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public ProductNhap()
        {
            InitializeComponent();
            label1.Text = "NCC:";
            label3.Text = "Giá nhập:";
            label4.Text = "Số lượng:";
            label2.Text = "NSX:";
            label5.Text = "HSD:";
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
        public string GiaNhap
        {
            get
            {
                return txtgianhap.Text;
            }
            set
            {
                txtgianhap.Text = value;
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
        public string MaThuoc
        {
            get
            {
                return txtmathuoc.Text;
            }
            set
            {
                txtmathuoc.Text = value;
            }
        }
        public string Donvitinh { get; set; }

        public string NhaCungCap { get { return selectNCC.SelectedValue.ToString(); } set { selectNCC.SelectedValue = value; } }
        public decimal soluong { get { return txtsoluong.Value; } set { txtsoluong.Value = value; } }
        public string nsx { get { return dateTimePicker1.Text; } set { dateTimePicker1.Text = value; } }
        public string hsd { get { return dateTimePicker2.Text; } set { dateTimePicker2.Text = value; } }
        public event EventHandler AddClickedNhap;


        private void addbutton_Click(object sender, EventArgs e)
        {
            AddClickedNhap?.Invoke(this, EventArgs.Empty);
        }

        private void ProductNhap_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            sql = "Select Ma_NCC, Ten_NCC from NhaCungCap";
            conn = new SqlConnection(constr);
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            selectNCC.DisplayMember = "Ten_NCC";
            selectNCC.ValueMember = "Ma_NCC";
            selectNCC.DataSource = dt;
        }
    }
}
