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
    public partial class frmMedicine : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        bool addnewFlag = false;
        private byte[] imagebyte;
        string maloai;

        public frmMedicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddMedicine frmAddMedicine = new frmAddMedicine();
            frmAddMedicine.ShowDialog();
        }
        
        public void NapCT()
        {
            
            if (dataGridView1.RowCount != 1)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmathuoc.Text = dataGridView1.Rows[i].Cells["MaThuoc"].Value.ToString();
                txttenthuoc.Text = dataGridView1.Rows[i].Cells["TenThuoc"].Value.ToString();
                txtmota.Text = dataGridView1.Rows[i].Cells["MT"].Value.ToString();
                txtdongia.Text = dataGridView1.Rows[i].Cells["DG"].Value.ToString();
                txtdvt.Text = dataGridView1.Rows[i].Cells["Donvitinh"].Value.ToString();
                txtdvtqd.Text = dataGridView1.Rows[i].Cells["Donvitinh_QD"].Value.ToString();
                txtsoluong.Text = dataGridView1.Rows[i].Cells["SLTonKho"].Value.ToString();
                txthsqd.Text = dataGridView1.Rows[i].Cells["HSquydoi"].Value.ToString();
                txtphanloai.Text = dataGridView1.Rows[i].Cells["Ten_Loai"].Value.ToString();
                if (dataGridView1.CurrentRow.Index == dataGridView1.RowCount - 1 || dataGridView1.Rows[i].Cells["Hinh_Anh"].Value ==DBNull.Value)
                {
                    medpic.Image = null;
                }
                else
                {
                    var data = (Byte[])(dataGridView1.Rows[i].Cells["Hinh_Anh"].Value);
                    var stream = new MemoryStream(data);
                    medpic.Image = Image.FromStream(stream);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0,0];
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.RowCount - 2];
            NapCT() ;
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

        private void button3_Click(object sender, EventArgs e)
        {
            string mathuoc;
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận yêu cầu", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = Convert.ToInt16(dataGridView1.CurrentRow.Index.ToString());
                mathuoc = dataGridView1.Rows[i].Cells["MaThuoc"].Value.ToString();
                sql = "Delete from DanhMucThuoc where Ma_Thuoc = '" + mathuoc + "'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                sql = "select dmt.Ma_Thuoc, dmt.Ten_Thuoc,dmt.DonGia,dmt.DVT,dmt.Hinh_Anh,dmt.DVT_QD,dmt.HSQD, dmt.Mo_ta,Loai.Ten_Loai,sum(tk.So_Luong_Ton) as 'SLTonKho'" +
                "\r\nfrom DanhMucThuoc as dmt left join TonKho as tk on dmt.Ma_Thuoc = tk.Ma_Thuoc left join Loai on dmt.Ma_Loai = Loai.Ma_Loai" +
                "\r\ngroup by dmt.Ma_Thuoc,dmt.Ten_Thuoc,dmt.Mo_ta,dmt.DonGia,dmt.DVT,dmt.DVT_QD,dmt.HSQD,dmt.Hinh_Anh,Loai.Ten_Loai";
                dt.Clear();
                da = new SqlDataAdapter(sql, conn);                
                da.Fill(dt);
                dataGridView1.DataSource = dt;
               
                NapCT();
            }
        }

        private void textupdate()
        {
            if (addnewFlag == false)
            {
                txttenthuoc.ReadOnly = false;
                txtmota.ReadOnly = false;
                txtdvt.ReadOnly = false;
                txtdvtqd.ReadOnly = false;
                txthsqd.ReadOnly = false;
                selectmaloai.Visible = true;
                switch (txtphanloai.Text)
                {
                    case "Thuốc điều trị":
                        selectmaloai.SelectedIndex = 0;
                        break;
                    case "Thực phẩm chức năng":
                        selectmaloai.SelectedIndex = 1;
                        break;
                    case "Thuốc kháng sinh":
                        selectmaloai.SelectedIndex = 2;
                        break;
                    case "Thuốc giảm đau và chống viêm":
                        selectmaloai.SelectedIndex = 3;
                        break;
                }
                txtphanloai.Visible = false;
                savemedbutton.Visible = true;
                txtdongia.ReadOnly = false;
                medpic.Enabled = true;
                if(medpic.Image != null) { imagebyte = ConvertImageToBytes(medpic.Image); }
                
                
            }
            else
            {
                txttenthuoc.ReadOnly = true;
                txtmota.ReadOnly = true;
                txtdvt.ReadOnly = true;
                txtdvtqd.ReadOnly = true;
                txthsqd.ReadOnly = true;
                selectmaloai.Visible = false;
                txtphanloai.Visible = true;
                txtphanloai.Text = selectmaloai.Text;
                savemedbutton.Visible = false;
                txtdongia.ReadOnly = true;
                medpic.Enabled = false;
            }
        }
        private void reloadbutton_Click(object sender, EventArgs e)
        {
            
            sql = "select dmt.Ma_Thuoc, dmt.Ten_Thuoc,dmt.DonGia,dmt.DVT,dmt.Hinh_Anh,dmt.DVT_QD,dmt.HSQD, dmt.Mo_ta,Loai.Ten_Loai,sum(tk.So_Luong_Ton) as 'SLTonKho'" +
                "\r\nfrom DanhMucThuoc as dmt left join TonKho as tk on dmt.Ma_Thuoc = tk.Ma_Thuoc left join Loai on dmt.Ma_Loai = Loai.Ma_Loai" +
                "\r\ngroup by dmt.Ma_Thuoc,dmt.Ten_Thuoc,dmt.Mo_ta,dmt.DonGia,dmt.DVT,dmt.DVT_QD,dmt.HSQD,dmt.Hinh_Anh,Loai.Ten_Loai";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addnewFlag = false;
            MessageBox.Show("Hãy thực hiện chỉnh sửa thông tin, kết thúc khi ấn nút Lưu");
            textupdate();

        }

        private void savemedbutton_Click(object sender, EventArgs e)
        {            
            sql = "Update DanhMucThuoc set Ten_Thuoc = N'" + txttenthuoc.Text + "',DVT = N'" + txtdvt.Text + "',DVT_QD = N'" + txtdvtqd.Text + "',HSQD = @HSQD, DonGia = '" + txtdongia.Text + "',Mo_ta = N'" + txtmota.Text + "',Ma_Loai = @MaLoai ,Hinh_Anh = @Hinhanh" +
                    " where Ma_Thuoc = '"+txtmathuoc.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            
                cmd.Parameters.AddWithValue("@HSQD", decimal.Parse(txthsqd.Text));
                cmd.Parameters.AddWithValue("@MaLoai",maloai);
                    
                if (medpic.Image == null)
                {
                    cmd.Parameters.Add("@Hinhanh", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Hinhanh", imagebyte);
                }
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    {
                        MessageBox.Show("Thông tin đã được lưu thành công!");

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi lưu.");
                    }
                
            
            addnewFlag = true;
            textupdate();
        }

        private void UpdateAllMed()
        {
            if (string.IsNullOrEmpty(textBox1.Text)||textBox1.Text == "Tìm kiếm theo tên")
            {
                sql = "select dmt.Ma_Thuoc, dmt.Ten_Thuoc,dmt.DonGia,dmt.DVT,dmt.Hinh_Anh,dmt.DVT_QD,dmt.HSQD, dmt.Mo_ta,Loai.Ten_Loai,sum(tk.So_Luong_Ton) as 'SLTonKho'" +
                "\r\nfrom DanhMucThuoc as dmt left join TonKho as tk on dmt.Ma_Thuoc = tk.Ma_Thuoc left join Loai on dmt.Ma_Loai = Loai.Ma_Loai" +
                "\r\ngroup by dmt.Ma_Thuoc,dmt.Ten_Thuoc,dmt.Mo_ta,dmt.DonGia,dmt.DVT,dmt.DVT_QD,dmt.HSQD,dmt.Hinh_Anh,Loai.Ten_Loai";
            }
            else
            {
                sql = "select dmt.Ma_Thuoc, dmt.Ten_Thuoc,dmt.DonGia,dmt.DVT,dmt.Hinh_Anh,dmt.DVT_QD,dmt.HSQD, dmt.Mo_ta,Loai.Ten_Loai,sum(tk.So_Luong_Ton) as 'SLTonKho'" +
                "\r\nfrom DanhMucThuoc as dmt left join TonKho as tk on dmt.Ma_Thuoc = tk.Ma_Thuoc left join Loai on dmt.Ma_Loai = Loai.Ma_Loai Where dmt.Ten_Thuoc LIKE N'%"+textBox1.Text+"%'" +
                "\r\ngroup by dmt.Ma_Thuoc,dmt.Ten_Thuoc,dmt.Mo_ta,dmt.DonGia,dmt.DVT,dmt.DVT_QD,dmt.HSQD,dmt.Hinh_Anh,Loai.Ten_Loai";
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
            UpdateAllMed();
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

        private void medpic_Paint(object sender, PaintEventArgs e)
        {
            if (medpic.Image == null)
            {
                // Tạo Font và Brush cho dòng chữ
                using (Font font = new Font("Arial", 11, FontStyle.Italic))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    string text = "Ấn để thêm ảnh";
                    SizeF textSize = e.Graphics.MeasureString(text, font);

                    // Tính toán vị trí để đặt dòng chữ ở giữa PictureBox
                    float x = (medpic.Width - textSize.Width) / 2;
                    float y = (medpic.Height - textSize.Height) / 2;

                    // Vẽ dòng chữ lên PictureBox
                    e.Graphics.DrawString(text, font, brush, x, y);
                }
            }
        }

        private void medpic_Click(object sender, EventArgs e)
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
                medpic.Image = Image.FromFile(filePath);
                medpic.SizeMode = PictureBoxSizeMode.Zoom; // Để ảnh vừa với PictureBox
                imagebyte = ConvertImageToBytes(medpic.Image);
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

        private void selectmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectmaloai.SelectedIndex)
            {
                case 0:
                    maloai = "L01";
                    break;
                case 1:
                    maloai = "L02";
                    break;
                case 2:
                    maloai = "L03";
                    break;
                case 3:
                    maloai = "L04";
                    break;
            }           
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
                constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
                conn.ConnectionString = constr;
                conn.Open();
                sql = "select dmt.Ma_Thuoc, dmt.Ten_Thuoc,dmt.DonGia,dmt.DVT,dmt.Hinh_Anh,dmt.DVT_QD,dmt.HSQD, dmt.Mo_ta,Loai.Ten_Loai,sum(tk.So_Luong_Ton) as 'SLTonKho'" +
                "\r\nfrom DanhMucThuoc as dmt left join TonKho as tk on dmt.Ma_Thuoc = tk.Ma_Thuoc left join Loai on dmt.Ma_Loai = Loai.Ma_Loai" +
                "\r\ngroup by dmt.Ma_Thuoc,dmt.Ten_Thuoc,dmt.Mo_ta,dmt.DonGia,dmt.DVT,dmt.DVT_QD,dmt.HSQD,dmt.Hinh_Anh,Loai.Ten_Loai";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                NapCT();
            
            
        }
    }
}
