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
    public partial class frmAddEmployee : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        byte[] imagebyte = null;
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private int getmaxEmpcount()
        {
            int count = 0;
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_NV, 3, LEN(Ma_NV) - 1) AS INT)) FROM Nhanvien";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateEmpCode()
        {
            int maxEmp = getmaxEmpcount();
            string newEmpCode = "NV" + (maxEmp + 1).ToString("D2");
            addempcode.Text = newEmpCode;
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            GenerateEmpCode();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Chọn một ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file ảnh được chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            sql = "Insert into Nhanvien (Ma_NV,Ten_NV,Chuc_vu,SDT,Email,Username,Password,Hinh_Anh) values " +
                "('" + addempcode.Text + "',N'" + addempten.Text + "',N'" + txtempchucvu.Text + "','" + addempsdt.Text + "',N'" + addempemail.Text + "','" + addusername.Text + "','" + addpassword.Text + "',@Hinhanh)";
            conn = new SqlConnection(constr);
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {   if(pictureBox1.Image == null)
                {
                    cmd.Parameters.Add("@Hinhanh",SqlDbType.VarBinary).Value = DBNull.Value;
                }
                else { cmd.Parameters.AddWithValue("@Hinhanh", imagebyte); }
                
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    this.Close();
                    MessageBox.Show("Thông tin đã được lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi lưu!");
                }
            }
        }
    }
}
