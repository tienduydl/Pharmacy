using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

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
        public string mahoadonban;
        public frmHDBan()
        {
            InitializeComponent();
        }
        private void NapCT()
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
                string sql1 = "Select ID,ct.Ma_Thuoc, dm.Ten_Thuoc,dm.DVT,ct.So_Luong,ct.Don_Gia, ct.Thanh_Tien " +
                "from CTHoaDonBan ct left join DanhMucThuoc dm on ct.Ma_Thuoc = dm.Ma_Thuoc " +
                "Where Ma_HDB = '" + txtmahdb.Text + "'";
                da1 = new SqlDataAdapter(sql1, conn);
                dt1.Clear();
                da1.Fill(dt1);
                CThoadon.DataSource = dt1;
                CThoadon.Refresh();
                if (dataGridView1.Rows[i].Cells["Trang_Thai"].Value.ToString() == "Đã xuất hàng")
                {
                    xuathangbutton.Enabled = false;
                }
                else
                {
                    xuathangbutton.Enabled=true;
                }
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


        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "HoaDonBan"+txtmahdb.Text+".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    CreatePdf(filePath);
                }
            }

        }
        private void CreatePdf(string filePath)
        {
            // Kiểm tra xem file có tồn tại không, nếu có thì xóa
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");

            // Tạo tài liệu PDF
            Document document = new Document(PageSize.A5);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font timesNewRoman = new iTextSharp.text.Font(bf, 12);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bf, 10);

            try
            {
                // Mở tài liệu PDF để thêm nội dung
                document.Open();

                // Thêm tiêu đề và thông tin chung của hóa đơn
                document.Add(new Paragraph("HÓA ĐƠN BÁN HÀNG",timesNewRoman));
                document.Add(new Paragraph("Mã đơn hàng: " + txtmahdb.Text,times));
                document.Add(new Paragraph("Ngày đơn hàng: " + txtngayhdb.Text,times));
                document.Add(new Paragraph("Người tạo: " + txtmanv.Text,times));
                document.Add(new Paragraph("Khách hàng: " + txtmakh.Text,times));
                document.Add(new Paragraph("Tổng tiền: " + txttongtien.Text,times));
                document.Add(new Paragraph(" " , times));
                // Tạo bảng cho chi tiết hóa đơn
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;
                float[] columnWidths = { 1f, 3f, 1f, 1f, 2f, 2f };
                table.SetWidths(columnWidths);
                // Thêm tiêu đề cho các cột
                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                table.AddCell(new PdfPCell(new Phrase("Tên thuốc", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
               
                // Thêm bảng vào tài liệu
                foreach (DataGridViewRow row in CThoadon.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        table.AddCell(new PdfPCell(new Phrase(row.Index.ToString() + 1, times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["Ten_Thuoc"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["So_Luong"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["DVT"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["Don_Gia"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["Thanh_Tien"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });

                    }
                }
                document.Add(table);
                Paragraph totalParagraph = new Paragraph("Tổng tiền: " + txttongtien.Text, times);
                totalParagraph.Alignment = Element.ALIGN_RIGHT; // Căn phải
                totalParagraph.SpacingBefore = 20f; // Khoảng cách so với bảng
                document.Add(totalParagraph);
                DateTime today = DateTime.Now;
                string currentDate = $"Hà Nội, Ngày {today.Day} Tháng {today.Month} Năm {today.Year}";

                // Thêm dòng "Hà Nội, Ngày...Tháng...Năm..." dưới bảng
                Paragraph dateParagraph = new Paragraph(currentDate, times);
                dateParagraph.Alignment = Element.ALIGN_RIGHT; // Căn phải
                dateParagraph.SpacingBefore = 20f; // Khoảng cách so với bảng
                document.Add(dateParagraph);
                MessageBox.Show("Lưu hóa đơn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu!");
            }
            finally
            {
                // Đóng tài liệu PDF
                document.Close();
            }
        }
        public class ChiTietDonHang
        {
            public string MaThuoc { get; set; }
            public string TenThuoc { get; set; }
            public string DonViTinh { get; set; }
            public decimal SoLuong { get; set; }
        }
        public List<ChiTietDonHang> GetDanhSachChiTietDonHang()
        {
            // Lấy danh sách từ DataGridView hoặc danh sách hiện tại
            List<ChiTietDonHang> danhSach = new List<ChiTietDonHang>();

            foreach (DataGridViewRow ctrow in CThoadon.Rows)
            {
                if (!ctrow.IsNewRow)
                {
                    ChiTietDonHang chitiet = new ChiTietDonHang()
                    {
                        MaThuoc = ctrow.Cells["Ma_THuoc"].Value.ToString(),
                        TenThuoc = ctrow.Cells["Ten_Thuoc"].Value.ToString(),
                        DonViTinh = ctrow.Cells["DVT"].Value.ToString(),
                        SoLuong = decimal.Parse(ctrow.Cells["So_Luong"].Value.ToString())
                    };
                    danhSach.Add(chitiet);

                }
            }
            return danhSach;
        }
        public string mahdbref;
        private void button2_Click(object sender, EventArgs e)
        {
            List<ChiTietDonHang> danhSach = GetDanhSachChiTietDonHang();
            AddPhieuXuat addPhieuXuat = new AddPhieuXuat(danhSach, txtmahdb.Text);
            addPhieuXuat.Show();
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
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
