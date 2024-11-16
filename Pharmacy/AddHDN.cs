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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy
{
    public partial class AddHDN : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private int comboboxprev = -1;
        public AddHDN()
        {
            InitializeComponent();
        }
        private void LoadAllMed()
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            sql = "Select * from DanhMucThuoc ";

            using (SqlConnection conn = new SqlConnection(constr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        ProductNhap item = new ProductNhap();
                        item.MaThuoc = reader["Ma_Thuoc"].ToString();
                        item.TenThuoc = reader["Ten_Thuoc"].ToString();
                        item.GiaNhap = reader["DonGiaNhap"].ToString();
                        item.Donvitinh = reader["DVT"].ToString();

                        if (reader["Hinh_Anh"] != DBNull.Value)
                        {
                            byte[] imagebytes = (byte[])reader["Hinh_Anh"];
                            using (MemoryStream ms = new MemoryStream(imagebytes))
                            {
                                item.HinhAnh = Image.FromStream(ms);
                            }
                        }
                        item.AddClickedNhap += ProductNhap_AddClicked;
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }
        private void ProductNhap_AddClicked(object sender, EventArgs e)
        {
            var item = sender as ProductNhap;
            if (item != null && item.soluong > 0)
            {
                string tenThuoc = item.TenThuoc;
                decimal soLuong = item.soluong;
                decimal donGia = decimal.Parse(item.GiaNhap);
                decimal thanhTien = donGia * soLuong;
                string ngaysx = item.nsx;
                string hansd = item.hsd;
                string maThuoc = item.MaThuoc;
                string dvt = item.Donvitinh;
                string ncc = item.NhaCungCap;

                bool found = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["Ten_Thuoc"].Value != null && row.Cells["Ten_Thuoc"].Value.ToString() == tenThuoc && decimal.Parse(row.Cells["Don_Gia"].Value.ToString()) == donGia && row.Cells["NCC"].Value.ToString() == ncc)
                    {
                        int currentQuantityInGrid = Convert.ToInt32(row.Cells["So_Luong"].Value);
                        row.Cells["So_Luong"].Value = currentQuantityInGrid + soLuong;

                        decimal currentTotal = Convert.ToDecimal(row.Cells["Thanh_Tien"].Value);
                        row.Cells["Thanh_Tien"].Value = (currentQuantityInGrid + soLuong) * donGia;

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dataGridView1.Rows.Add(maThuoc, tenThuoc, ncc,ngaysx,hansd, dvt, donGia.ToString(), soLuong.ToString(), thanhTien.ToString());
                }

            }
        }
        private void UpdateAllMed()
        {

            if ((string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm kiếm...") && comboboxprev == -1)
            {
                sql = "Select * from DanhMucThuoc";
            }
            else if ((string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm kiếm...") && comboboxprev != -1)
            {
                sql = "select Ma_Thuoc,Ten_Thuoc,DonGia,Mo_ta,Hinh_Anh,Ten_Loai" +
                    " from DanhMucThuoc dm left join Loai on dm.Ma_Loai = Loai.Ma_Loai where Ten_Loai LIKE N'%" + comboBox1.Text + "%'  ";
            }
            else if (comboboxprev == -1)
            {
                sql = "select Ma_Thuoc,Ten_Thuoc,DonGia,Mo_ta,Hinh_Anh,Ten_Loai from DanhMucThuoc dm left join Loai on dm.Ma_Loai = Loai.Ma_Loai where Ten_Thuoc  LIKE N'%" + textBox1.Text + "%' ";
            }
            else
            {
                sql = "select Ma_Thuoc,Ten_Thuoc,DonGia,Mo_ta,Hinh_Anh,Ten_Loai from DanhMucThuoc dm left join Loai on dm.Ma_Loai = Loai.Ma_Loai where  Ten_Thuoc  LIKE N'%" + textBox1.Text + "%' and Ten_Loai LIKE N'" + comboBox1.Text + "' ";
            }

            using (SqlConnection conn = new SqlConnection(constr))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Ten_Thuoc", Ten_Thuoc + "%");
                    SqlDataReader reader = cmd.ExecuteReader();
                    flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        ProductNhap item = new ProductNhap();
                        item.MaThuoc = reader["Ma_Thuoc"].ToString();
                        item.TenThuoc = reader["Ten_Thuoc"].ToString();
                        item.GiaNhap = reader["DonGia"].ToString();
                        if (reader["Hinh_Anh"] != DBNull.Value)
                        {
                            byte[] imagebytes = (byte[])reader["Hinh_Anh"];
                            using (MemoryStream ms = new MemoryStream(imagebytes))
                            {
                                item.HinhAnh = Image.FromStream(ms);
                            }
                        }
                        item.AddClickedNhap += ProductNhap_AddClicked;
                        flowLayoutPanel1.Controls.Add(item);
                    }
                }
            }
        }
        private decimal TotalMoney()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    decimal rowTotal = Convert.ToDecimal(row.Cells["Thanh_Tien"].Value);
                    totalAmount += rowTotal;
                }
            }

            return totalAmount;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddHDN_Load(object sender, EventArgs e)
        {
            LoadAllMed();
            GenerateHDNCode();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm...")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxprev == comboBox1.SelectedIndex)
            {
                comboboxprev = -1;
                comboBox1.SelectedIndex = -1;
            }
            else
            {
                comboboxprev = comboBox1.SelectedIndex;
            }

            UpdateAllMed();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateAllMed();
        }

        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            txttongtien.Text = TotalMoney().ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txttongtien.Text = TotalMoney().ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txttongtien.Text = TotalMoney().ToString();
        }

        private void trabutton_Click(object sender, EventArgs e)
        {
            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                int returnedQuantity = Convert.ToInt32(txtsoluongtra.Text);
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["So_Luong"].Value);

                if (returnedQuantity > currentQuantity)
                {
                    MessageBox.Show("Số lượng trả không thể lớn hơn số lượng hiện tại.");
                    return;
                }

                int newQuantity = currentQuantity - returnedQuantity;
                selectedRow.Cells["So_Luong"].Value = newQuantity;

                decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["Don_Gia"].Value);
                selectedRow.Cells["Thanh_Tien"].Value = newQuantity * unitPrice;

                if (newQuantity <= 0)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                }

                txttongtien.Text = TotalMoney().ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để trả.");
            }
        }
        private int getmaxHDBcount()
        {
            int count = 0;

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_CT, 3, LEN(Ma_CT) - 1) AS INT)) FROM HoaDonNhap";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateHDNCode()
        {
            int maxHDB = getmaxHDBcount();
            string newHDNCode = "DN" + (maxHDB + 1).ToString("D3");
            txtmahdn.Text = newHDNCode;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuỗi kết nối
                string constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password=1234";
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    // Thêm thông tin hóa đơn nhập
                    string sqlHDN = "INSERT INTO HoaDonNhap (Ma_CT, Ngay_CT, Ma_NV, Tong_tien, Dien_Giai) " +
                                    "VALUES (@Ma_CT, @Ngay_CT, @Ma_NV, @Tong_tien, @Dien_Giai)";
                    using (SqlCommand cmd = new SqlCommand(sqlHDN, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ma_CT", txtmahdn.Text);
                        cmd.Parameters.AddWithValue("@Ngay_CT", txtngayhdn.Value);
                        cmd.Parameters.AddWithValue("@Ma_NV", txtnv.Text);
                        cmd.Parameters.AddWithValue("@Tong_tien", txttongtien.Text);
                        cmd.Parameters.AddWithValue("@Dien_Giai", txtdiengiai.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    // Duyệt qua các dòng trong DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Chuyển đổi giá trị ngày
                            DateTime.TryParse(row.Cells["NgaySX"].Value?.ToString(), out DateTime ngaySX);
                            DateTime.TryParse(row.Cells["HSD"].Value?.ToString(), out DateTime hsd);

                            // Tạo mã lô
                            string maLo = $"{txtmahdn.Text}-{row.Index + 1}";

                            // Thêm thông tin chi tiết hóa đơn nhập và tồn kho
                            string sqlCTHDN = @"
                            BEGIN TRANSACTION;
                            INSERT INTO CTHoaDonNhap (Ma_Lo, Ma_HDN, Ma_Thuoc, Ma_NCC, NSX, HSD, DVT, So_Luong, Don_Gia, Thanh_Tien)
                            VALUES (@Ma_Lo, @Ma_HDN, @Ma_Thuoc, @Ma_NCC, @NSX, @HSD, @DVT, @So_Luong, @Don_Gia, @Thanh_Tien);

                            DECLARE @maxID NVARCHAR(20), @newID NVARCHAR(20);
                            SELECT @maxID = ISNULL(MAX(CAST(SUBSTRING(ID, 3, LEN(ID) - 2) AS INT)), 0) 
                            FROM TonKho 
                            WHERE ID LIKE 'TK%' AND ISNUMERIC(SUBSTRING(ID, 3, LEN(ID) - 2)) = 1;

                            IF @maxID = 0
                                SET @newID = 'TK1';
                            ELSE
                                SET @newID = 'TK' + CAST(@maxID + 1 AS NVARCHAR);

                            INSERT INTO TonKho (ID, Ma_Thuoc, Ma_Lo, So_Luong_Goc, So_Luong_Ton)
                            VALUES (@newID, @Ma_Thuoc, @Ma_Lo, @So_Luong, @So_Luong);

                            COMMIT TRANSACTION;";

                            using (SqlCommand cmd = new SqlCommand(sqlCTHDN, conn))
                            {
                                cmd.Parameters.AddWithValue("@Ma_Lo", maLo);
                                cmd.Parameters.AddWithValue("@Ma_HDN", txtmahdn.Text);
                                cmd.Parameters.AddWithValue("@Ma_Thuoc", row.Cells["Ma_Thuoc"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@Ma_NCC", row.Cells["NCC"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@NSX", ngaySX == DateTime.MinValue ? DBNull.Value : (object)ngaySX);
                                cmd.Parameters.AddWithValue("@HSD", hsd == DateTime.MinValue ? DBNull.Value : (object)hsd);
                                cmd.Parameters.AddWithValue("@DVT", row.Cells["DVT"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@So_Luong", row.Cells["So_Luong"].Value?.ToString() ?? "0");
                                cmd.Parameters.AddWithValue("@Don_Gia", row.Cells["Don_Gia"].Value?.ToString() ?? "0");
                                cmd.Parameters.AddWithValue("@Thanh_Tien", row.Cells["Thanh_Tien"].Value?.ToString() ?? "0");

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                }

                MessageBox.Show("Lưu thông tin thành công!");
                GenerateHDNCode();
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Tìm kiếm...";
                textBox1.ForeColor = Color.Gray;

            }
        }
    }
}
