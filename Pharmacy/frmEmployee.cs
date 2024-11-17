using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmEmployee : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        bool edit = false;
        private byte[] imagebyte;
        public frmEmployee()
        {
            InitializeComponent();
        }

       
        private void frmEmployee_Load(object sender, EventArgs e)
        {

            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from Nhanvien";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }
        public void NapCT()
        {
            int i = dataGridView1.CurrentRow.Index;
            txtmanv.Text = dataGridView1.Rows[i].Cells["MaNV"].Value.ToString();
            txthovaten.Text = dataGridView1.Rows[i].Cells["TenNV"].Value.ToString();
            txtchucvu.Text = dataGridView1.Rows[i].Cells["Chucvu"].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells["sodienthoai"].Value.ToString();
            txtemail.Text = dataGridView1.Rows[i].Cells["mail"].Value.ToString();
            txtusername.Text = dataGridView1.Rows[i].Cells["user"].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[i].Cells["pass"].Value.ToString();
            if (dataGridView1.CurrentRow.Index == dataGridView1.RowCount - 1 || dataGridView1.Rows[i].Cells["Hinh_Anh"].Value == DBNull.Value)
            {
                pictureBox1.Image = null;
            }
            else
            {
                var data = (Byte[])(dataGridView1.Rows[i].Cells["Hinh_Anh"].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, 0];
            NapCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmadd = new frmAddEmployee();
            frmadd.ShowDialog();
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

        private void textupdate()
        {
            if(edit == false)
            {
                txthovaten.ReadOnly = false;
                txtchucvu.Visible = false;
                comboBox1.Visible = true;
                comboBox1.SelectedText = txtchucvu.Text;
                txtemail.ReadOnly = false;
                txtusername.ReadOnly = false;
                txtpassword .ReadOnly = false;
                txtsdt.ReadOnly = false;
                pictureBox1.Enabled = true;
                savebutton.Visible = true;
            }
            else
            {
                txthovaten.ReadOnly = true;
                txtchucvu.Visible = true;
                comboBox1.Visible = false;
                txtemail.ReadOnly = true;
                txtusername.ReadOnly =  true;
                txtpassword.ReadOnly = true;
                txtsdt.ReadOnly= true;
                pictureBox1.Enabled = false;
                savebutton .Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            edit = false;
            textupdate();
            MessageBox.Show("Hãy thực hiện chỉnh sửa thông tin, kết thúc khi ấn nút Lưu");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Khởi tạo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Chọn một ảnh";

            // Kiểm tra xem người dùng đã chọn ảnh hay chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh được chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Để ảnh vừa với PictureBox
                imagebyte = ConvertImageToBytes(pictureBox1.Image);
            }
        }
        private byte[] ConvertImageToBytes(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                // Tạo Font và Brush cho dòng chữ
                using (Font font = new Font("Arial", 11, FontStyle.Italic))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    string text = "Ấn để thêm ảnh";
                    SizeF textSize = e.Graphics.MeasureString(text, font);

                    // Tính toán vị trí để đặt dòng chữ ở giữa PictureBox
                    float x = (pictureBox1.Width - textSize.Width) / 2;
                    float y = (pictureBox1.Height - textSize.Height) / 2;

                    // Vẽ dòng chữ lên PictureBox
                    e.Graphics.DrawString(text, font, brush, x, y);
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                if (pictureBox1.Image != null) { imagebyte = ConvertImageToBytes(pictureBox1.Image); }
                
                sql = "Update Nhanvien set Ten_NV = N'" + txthovaten.Text + "',Chuc_vu = N'" + comboBox1.Text + "', SDT = '" + txtsdt.Text + "'," +
                "Email = '" + txtemail.Text + "', Username = '" + txtusername.Text + "',Password = '" + txtpassword.Text + "',Hinh_Anh = @Hinhanh Where Ma_NV = '"+txtmanv.Text+"'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pictureBox1.Image == null)
                    {
                        cmd.Parameters.Add("@Hinhanh", SqlDbType.VarBinary).Value = DBNull.Value;
                    }
                    else 
                    { 
                        cmd.Parameters.Add("@Hinhanh",SqlDbType.VarBinary).Value=imagebyte; 
                    }
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thông tin đã được lưu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi lưu!");
                    }
                    edit = true;
                    textupdate();
                }
            }
        }

        private void reloadbutton_Click(object sender, EventArgs e)
        {
            sql = "select * from Nhanvien";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận yêu cầu",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());
                sql = "Delete from Nhanvien where Ma_NV = '" + dataGridView1.Rows[i].Cells["MaNV"].Value + "'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
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

        
    }
}
