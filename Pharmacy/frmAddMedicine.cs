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
    public partial class frmAddMedicine : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private byte[] imagebyte;
        private string maloai;
        public frmAddMedicine()
        {
            InitializeComponent();
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
        private int getmaxDrugcount()
        {
            int count = 0;
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_Thuoc, 2, LEN(Ma_Thuoc) - 1) AS INT)) FROM DanhMucThuoc";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateDrugCode()
        {
            int maxDrug = getmaxDrugcount();
            string newDrugCode = "M" + (maxDrug + 1).ToString("D3");
            addmathuoc.Text = newDrugCode;
        }

     private void addmedicine()
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";        
               
            switch (selectmaloai.SelectedText)
            {
                case "Thuốc điều trị": maloai = "L01";
                    break;
                case "Thực phẩm chức năng":
                    maloai = "L02";
                    break;
                case "Thuốc kháng sinh":
                    maloai = "L03";
                    break;
                case "Thuốc giảm đau và chống viêm":
                    maloai = "L04";
                    break;
            }
            using (SqlConnection conn = new SqlConnection(constr)) {
                
                    sql = "Insert into DanhMucThuoc(Ma_Thuoc,Ten_Thuoc,DVT,DVT_QD,HSQD,DonGia,Mo_ta,Ma_Loai,Hinh_Anh)" +
                         "Values ('" + addmathuoc.Text + "',N'" + addtenthuoc.Text + "',N'" + adddvt.Text + "',N'" + adddvtqd.Text + "',@HSQD,'" + adddongia.Text + "',N'" + addmota.Text + "',@MaLoai,@HinhAnh)";
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@HSQD",decimal.Parse(addhsqd.Text));
                    cmd.Parameters.AddWithValue("@MaLoai",maloai);
                    if (pictureBox1.Image == null) {
                        cmd.Parameters.Add("@HinhAnh", SqlDbType.VarBinary).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HinhAnh", imagebyte ?? (object)DBNull.Value);
                    }                    
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
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
        private void button1_Click(object sender, EventArgs e)
        {
            addmedicine();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void frmAddMedicine_Load(object sender, EventArgs e)
        {
            GenerateDrugCode();
        }
    }
}
