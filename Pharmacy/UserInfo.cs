using iTextSharp.text.pdf.codec;
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
    public partial class UserInfo : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private byte[] imagebyte;
        bool edit = false;
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            txtmanv.Text = frmlogin.UserSession.CurrentNhanVien.MaNV.ToString();
            txttennv.Text = frmlogin.UserSession.CurrentNhanVien.Ten.ToString();
            txtsdt.Text = frmlogin.UserSession.CurrentNhanVien.SDT.ToString();
            txtemail.Text = frmlogin.UserSession.CurrentNhanVien.Email.ToString();
            txtusername.Text = frmlogin.UserSession.CurrentNhanVien.Username.ToString();
            txtpassword.Text = frmlogin.UserSession.CurrentNhanVien.Password.ToString();
            if(frmlogin.UserSession.CurrentNhanVien.HinhAnh != null)
            {
                using (var ms = new MemoryStream(frmlogin.UserSession.CurrentNhanVien.HinhAnh))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    imagebyte = ConvertImageToBytes(pictureBox1.Image);                
            }
            }
            else
            {
                pictureBox1.Image = null;
            }
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

        private void updatebutton_Click(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            using (conn = new SqlConnection(constr))
            {
                sql = "UPDATE Nhanvien SET Ten_NV = @TenNV, SDT = @SDT, Email = @Email, Username = @Username, Password = @Password, Hinh_Anh = @Hinhanh WHERE Ma_NV = @MaNV";
                cmd = new SqlCommand(sql, conn);

                // Gán giá trị cho các tham số
                cmd.Parameters.AddWithValue("@TenNV", txttennv.Text);
                cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@MaNV", txtmanv.Text); // Đảm bảo txtmanv.Text chứa đúng mã nhân viên

                // Xử lý hình ảnh
                if (pictureBox1.Image == null)
                {
                    cmd.Parameters.AddWithValue("@Hinhanh", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Hinhanh", imagebyte);
                }

                // Thực thi câu lệnh
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên cần cập nhật!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            frmlogin.UserSession.CurrentNhanVien = new frmlogin.NhanVienInfo
            {
                MaNV = txtmanv.Text,
                Ten = txttennv.Text,
                SDT = txtsdt.Text,
                Email = txtemail.Text,
                Username = txtusername.Text,
                Password = txtpassword.Text,
                Chucvu = txtchucvu.Text,
                HinhAnh = imagebyte
            };
            edit = true;
            updateinfo();

        }
        private void updateinfo()
        {
            if (edit == false) {
                txttennv.ReadOnly = false;
                txtsdt.ReadOnly = false;
                txtemail.ReadOnly = false;
                txtusername.ReadOnly = false;
                txtpassword.ReadOnly = false;
                pictureBox1.Enabled = true;
                editbutton.Visible = false;
            }
            else
            {
                txttennv.ReadOnly = true;
                txtsdt.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtusername.ReadOnly = true;
                txtpassword.ReadOnly = true;
                pictureBox1.Enabled = false;
                editbutton.Visible = true;
            }
        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            updateinfo();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                // Tạo Font và Brush cho dòng chữ
                using (Font font = new Font("Arial", 10, FontStyle.Italic))
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
    }
}
