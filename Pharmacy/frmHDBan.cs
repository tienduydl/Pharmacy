using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmHDBan : Form
    { SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr;
        public frmHDBan()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmahdb.Text = dataGridView1.Rows[i].Cells["Ma_CT"].Value.ToString();
                txtmanv.Text = dataGridView1.Rows[i].Cells["Ma_NV"].Value.ToString();
                txtngayhdb.Text = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Ngay_CT"].Value).ToString("dd/MM/yyyy");
                txttongtien.Text = dataGridView1.Rows[i].Cells["Tong_Tien"].Value.ToString();
                txtdiengiai.Text = dataGridView1.Rows[i].Cells["Dien_Giai"].Value.ToString();
                txtmakh.Text = dataGridView1.Rows[i].Cells["Ma_KH"].Value.ToString();
                string sql1 = "Select ID,ct.Ma_Thuoc, dm.Ten_Thuoc,dm.DVT_QD as DVT,ct.So_Luong,ct.Don_Gia, ct.Thanh_Tien " +
                "from CTHoaDonBan ct left join DanhMucThuoc dm on ct.Ma_Thuoc = dm.Ma_Thuoc " +
                "Where Ma_HDB = '" + txtmahdb.Text + "'";
                da1 = new SqlDataAdapter(sql1, conn);
                dt1.Clear();
                da1.Fill(dt1);
                CThoadon.DataSource = dt1;
                CThoadon.Refresh();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, 0];
            NapCT();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (i > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[0, i - 1];
            }
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (i < dataGridView1.RowCount - 1)
            {
                dataGridView1.CurrentCell = dataGridView1[0, i + 1];
            };
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.RowCount - 2];
            NapCT();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm theo mã hóa đơn";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm theo mã hóa đơn")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }
        private void UpdateHDB()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm theo mã hóa đơn")
            {
                sql = "select * from HoaDonBan";
            }
            else
            {
                sql = "select * form HoaDonBan where Ma_CT LIKE '%"+textBox1.Text+"%'";
            }
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm theo mã hóa đơn") {
                sql = "select * from HoaDonBan where Ngay_CT between @StartDate and @EndDate";
            }
            else
            {
                sql = "select * from HoaDonBan where Ma_CT Like @MaCT and Ngay_CT between @StartDate and @EndDate";
            }
            da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@StartDate", startdate.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@EndDate", enddate.Value.Date);

            if (!(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm theo mã hóa đơn"))
            {
                da.SelectCommand.Parameters.AddWithValue("@MaCT", "%" + textBox1.Text + "%");
            }
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Không tìm thấy kết quả nào");
            }
            else
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                NapCT();
            }
        }

        private void reloadbutton_Click(object sender, EventArgs e)
        {
            sql = "select * from HoaDonBan";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }

        private void delmedbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());
                sql = "Delete from HoaDonBan where Ma_CT = '" + dataGridView1.Rows[i].Cells["Ma_CT"].Value.ToString() + "'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                sql = "select * from HoaDonBan";
                dt.Clear();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                NapCT();
            }
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from HoaDonBan";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }
    }
}
