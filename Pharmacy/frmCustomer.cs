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
    public partial class frmCustomer : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        bool edit = false;
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void NapCT()
        {
            if (dataGridView1.RowCount != 1)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmakh.Text = dataGridView1.Rows[i].Cells["Ma_KH"].Value.ToString();
                txthoten.Text = dataGridView1.Rows[i].Cells["Ten_KH"].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                txtemail.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmadd = new frmAddCustomer();
            frmadd.ShowDialog();
        }

        private void reloadbutton_Click(object sender, EventArgs e)
        {
            sql = "Select * from KhachHang";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
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

        private void savesplbutton_Click(object sender, EventArgs e)
        {
            sql = "Update KhachHang set Ten_KH =N'" + txthoten.Text + "', SDT = '" + txtsdt.Text + "',DiaChi = N'" + txtdiachi.Text + "',Email = '" + txtemail.Text + "' where Ma_KH = '" + txtmakh.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công!");
            edit = true;
            updatetext();
        }
        private void updatetext()
        {
            if (edit == false)
            {
                txthoten.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtemail.ReadOnly = false;
                txtdiachi.ReadOnly = false;
                savesplbutton.Visible = true;
            }
            else
            {
                txthoten.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                savesplbutton.Visible = false;
            }
        }
        private void updatedata()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm kiếm theo tên")
            {
                sql = "select * from KhachHang";
            }
            else
            {
                sql = "select * from KhachHang where Ten_KH LIKE N'%" + textBox1.Text + "%'";
            }
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            edit = false;
            MessageBox.Show("Hãy thực hiện chỉnh sửa thông tin, kết thúc khi ấn nút Lưu");
            updatetext();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm kiếm theo tên";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo tên")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatedata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận yêu cầu",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());               ;
                sql = "Delete from KhachHang where Ma_KH = '" + dataGridView1.Rows[i].Cells["Ma_KH"].Value.ToString() + "'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công!");
                sql = "select * from KhachHang";
                dt.Clear();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                NapCT();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from KhachHang";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();

        }
    }
}
