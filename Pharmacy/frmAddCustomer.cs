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

    public partial class frmAddCustomer : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private int getmaxCuscount()
        {
            int count = 0;
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_KH, 3, LEN(Ma_KH) - 1) AS INT)) FROM KhachHang";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateCusCode()
        {
            int maxSpl = getmaxCuscount();
            string newCusCode = "KH" + (maxSpl + 1).ToString("D3");
            txtmakh.Text = newCusCode;
        }
        private void addcus()
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(constr);
            sql = "Insert into KhachHang (Ma_KH,Ten_KH,SDT,DiaChi,Email) Values (N'" + txtmakh.Text + "',N'" + txthoten.Text + "','" + txtsdt.Text + "',N'" + txtdiachi.Text + "',N'" + txtemail.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                this.Close();
                MessageBox.Show("Thông tin đã được lưu thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi lưu.");
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            GenerateCusCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcus();
        }
    }
}
