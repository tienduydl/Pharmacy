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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Pharmacy
{
    public partial class frmxuatthuoc : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        string sql, constr;
        public frmxuatthuoc()
        {
            InitializeComponent();
        }
        public void NapCT()
        {
            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                int i = dataGridView1.CurrentRow.Index;
                txtmapx.Text = dataGridView1.Rows[i].Cells["Ma_CT"].Value.ToString();
                txtmanv.Text = dataGridView1.Rows[i].Cells["Ma_NV"].Value.ToString();
                txtngay.Text = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Ngay_CT"].Value).ToString("dd/MM/yyyy");
                txtmahdb.Text = dataGridView1.Rows[i].Cells["Ma_HDB"].Value.ToString();
                txtdiengiai.Text = dataGridView1.Rows[i].Cells["Dien_Giai"].Value.ToString();
                string sql1 = "select ct.ID, ct.Ma_Thuoc, ct.Ma_PX, ct.Ma_Kho, ct.So_Luong, dn.NSX, dn.HSD " +
                    "from CTPhieuXuat ct left join TonKho tk on ct.Ma_Kho = tk.ID left join CTHoaDonNhap dn on dn.Ma_Lo = tk.Ma_Lo " +
                "Where Ma_PX = '" + txtmapx.Text + "'";
                da1 = new SqlDataAdapter(sql1, conn);
                dt1.Clear();
                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;
                dataGridView2.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm theo mã phiếu";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm theo mã phiếu")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm theo mã phiếu")
            {
                sql = "select * from PhieuXuat where Ngay_CT between @StartDate and @EndDate";
            }
            else
            {
                sql = "select * from PhieuXuat where Ma_CT Like @MaCT and Ngay_CT between @StartDate and @EndDate";
            }
            da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@StartDate", startdate.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@EndDate", enddate.Value.Date);

            if (!(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm theo mã phiếu"))
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
            sql = "select * from PhieuXuat";
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
                saveFileDialog.FileName = "PhieuXuat" + txtmapx.Text + ".pdf";

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
            Document document = new Document(PageSize.A5.Rotate());

            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font timesNewRoman = new iTextSharp.text.Font(bf, 12);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bf, 10);

            try
            {
                // Tạo PdfWriter instance và mở tài liệu
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Thêm tiêu đề và thông tin chung của hóa đơn
                Paragraph title = new Paragraph("PHIẾU XUẤT KHO", timesNewRoman);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                document.Add(title);

                document.Add(new Paragraph("Mã phiếu xuất: " + txtmapx.Text, times));
                document.Add(new Paragraph("Ngày tạo: " + txtngay.Text, times));
                document.Add(new Paragraph("Người tạo: " + txtmanv.Text, times));
                document.Add(new Paragraph("Hóa đơn bán tương ứng: " + txtmahdb.Text, times));
                document.Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------------"));

                // Tạo bảng cho chi tiết hóa đơn
                PdfPTable table = new PdfPTable(9);
                table.WidthPercentage = 100;
                float[] columnWidths = { 1f, 2f, 2f, 2f, 2f, 2f };
                table.SetWidths(columnWidths);

                // Thêm tiêu đề cho các cột
                table.AddCell(new PdfPCell(new Phrase("ID", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Mã thuốc", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Mã tồn kho", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Số lượng", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Ngày sản xuất", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Hạn sử dụng", times)) { HorizontalAlignment = Element.ALIGN_CENTER });

                // Thêm bảng vào tài liệu
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["ID"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["Ma_Thuoc"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["Ma_Kho"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["So_Luong"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["NSX"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new Phrase(row.Cells["HSD"].Value?.ToString() ?? "", times)) { HorizontalAlignment = Element.ALIGN_LEFT });
                    }
                }

                // Thêm bảng vào tài liệu PDF
                document.Add(table);
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
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
            finally
            {
                // Đóng tài liệu PDF
                document.Close();
            }
        }

        private void frmxuatthuoc_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select * from PhieuXuat";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            NapCT();
        }
    }
}
