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
    public partial class frmSupplier : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        bool edit = false;
        public frmSupplier()
        {
            InitializeComponent();
        }
        private void NapCT()
        {
            if (dataGridView1.RowCount != 1)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmancc.Text = dataGridView1.Rows[i].Cells["Ma_NCC"].Value.ToString();
                txttenncc.Text = dataGridView1.Rows[i].Cells["Ten_NCC"].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[i].Cells["SDT"].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[i].Cells["DiaChi"].Value.ToString();
                txtmst.Text = dataGridView1.Rows[i].Cells["MaSoThue"].Value.ToString();
            }
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select * from NhaCungCap";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddSupplier frmaddsupplier = new frmAddSupplier();
            frmaddsupplier.ShowDialog();
        }

        private void reloadbutton_Click(object sender, EventArgs e)
        {
            sql = "Select * from NhaCungCap";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
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

        private void delbutton_Click(object sender, EventArgs e)
        {
            string maspl;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận yêu cầu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());
                maspl = dataGridView1.Rows[i].Cells["Ma_NCC"].Value.ToString();
                sql = "Delete from NhaCungCap where Ma_NCC = '" + maspl + "'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                sql = "select * from NhaCungCap" ;
                dt.Clear();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                NapCT();
            }
        }

        private void updatedata()
        {
            if (string.IsNullOrEmpty(textBox1.Text)|| textBox1.Text == "Tìm kiếm theo tên")
            {
                sql = "select * from NhaCungCap";
            }
            else
            {
                sql = "select * from NhaCungCap where Ten_NCC LIKE N'%"+textBox1.Text+"%'";
            }
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updatedata();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm theo tên")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm kiếm theo tên";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void updatetext()
        {
            if(edit == false)
            {
                txttenncc.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtmst.ReadOnly = false;
                txtdiachi.ReadOnly = false;
                
                savesplbutton.Visible = true;
            }
            else
            {
                txttenncc.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtmst.ReadOnly = true;
                txtdiachi.ReadOnly = true;
                savesplbutton.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            edit = false;
            MessageBox.Show("Hãy thực hiện chỉnh sửa thông tin, kết thúc khi ấn nút Lưu");
            updatetext();

        }

        private void savesplbutton_Click(object sender, EventArgs e)
        {
            sql = "Update NhaCungCap set Ten_NCC=N'" + txttenncc.Text + "', SDT = '" + txtsdt.Text + "',DiaChi = N'" + txtdiachi.Text + "',MaSoThue = '" + txtmst.Text + "' where Ma_NCC = '"+txtmancc.Text+"'";
            cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công!");
            edit = true;
            updatetext();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, 0];
            NapCT();
        }
    }
}
