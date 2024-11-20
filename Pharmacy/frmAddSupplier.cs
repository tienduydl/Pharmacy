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
    public partial class frmAddSupplier : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmAddSupplier()
        {
            InitializeComponent();
        }
        private int getmaxSplcount()
        {
            int count = 0;
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_NCC, 2, LEN(Ma_NCC) - 1) AS INT)) FROM NhaCungCap";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateSplCode()
        {
            int maxSpl = getmaxSplcount();
            string newSplCode = "S" + (maxSpl + 1).ToString("D2");
            addsplcode.Text = newSplCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsupplier();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            GenerateSplCode();
        }

        private void addsupplier()
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            SqlConnection conn = new SqlConnection(constr);
            sql = "Insert into NhaCungCap(Ma_NCC,Ten_NCC,SDT,DiaChi,MaSoThue) Values (N'"+addsplcode.Text+"',N'"+addsplten.Text+"','"+addsplsdt.Text+"',N'"+addspldiachi.Text+"','"+addsplmst.Text+"')";
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

    }
}
