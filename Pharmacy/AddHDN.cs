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
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            sql = "Insert into HoaDonNhap (Ma_CT,Ngay_CT,Ma_NV,Tong_tien,Dien_Giai)" +
                " Values ('" + txtmahdn.Text + "',@Ngay_CT,'" + txtnv.Text + "','" + txttongtien.Text + "',N'" + txtdiengiai.Text + "')";
            conn = new SqlConnection(constr);
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ngay_CT", txtngayhdn.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string i = String.Concat(txtmahdn.Text, "-", row.Index + 1);

                    // Chuyển đổi NgaySX và HSD
                    DateTime ngaySX;
                    DateTime hsd;
                    bool isNgaySXValid = DateTime.TryParse(row.Cells["NgaySX"].Value.ToString(), out ngaySX);
                    bool isHSDValid = DateTime.TryParse(row.Cells["HSD"].Value.ToString(), out hsd);

                    // Tạo câu lệnh SQL với tham số
                    string sql = "    BEGIN TRANSACTION; INSERT INTO CTHoaDonNhap (Ma_Lo, Ma_HDN, Ma_Thuoc, Ma_NCC, NSX, HSD, DVT, So_Luong, Don_Gia, Thanh_Tien)" +
                        "    VALUES (@Ma_Lo, @Ma_HDN, @Ma_Thuoc, @Ma_NCC, @NSX, @HSD, @DVT, @So_Luong, @Don_Gia, @Thanh_Tien);" +
                        "    DECLARE @maxID nvarchar(20);    DECLARE @newID nvarchar(20);    SELECT @maxID = MAX(ID) FROM TonKho;" +
                        "    IF @maxID IS NULL        SET @newID = 'TK1';    ELSE        SET @newID = 'TK' + CAST(CAST(SUBSTRING(@maxID, 3, LEN(@maxID) - 2) AS INT) + 1 AS NVARCHAR);" +
                        "    INSERT INTO TonKho (ID, Ma_Thuoc, Ma_Lo, So_Luong_Goc, So_Luong_Ton)    VALUES (@newID, @Ma_Thuoc, @Ma_Lo, @So_Luong_Goc, @So_Luong_Ton);    COMMIT TRANSACTION;";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Ma_Lo", i);
                        cmd.Parameters.AddWithValue("@Ma_HDN", txtmahdn.Text);
                        cmd.Parameters.AddWithValue("@Ma_Thuoc", row.Cells["Ma_Thuoc"].Value.ToString());
                        cmd.Parameters.AddWithValue("@Ma_NCC", row.Cells["NCC"].Value.ToString());
                        cmd.Parameters.AddWithValue("@NSX", isNgaySXValid ? (object)ngaySX : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HSD", isHSDValid ? (object)hsd : DBNull.Value);
                        cmd.Parameters.AddWithValue("@DVT", row.Cells["DVT"].Value.ToString());
                        cmd.Parameters.AddWithValue("@So_Luong", row.Cells["So_Luong"].Value.ToString());
                        cmd.Parameters.AddWithValue("@Don_Gia", row.Cells["Don_Gia"].Value.ToString());
                        cmd.Parameters.AddWithValue("@Thanh_Tien", row.Cells["Thanh_Tien"].Value.ToString());
                        cmd.Parameters.AddWithValue("@So_Luong_Goc", row.Cells["So_Luong"].Value.ToString());  // Giả sử số lượng gốc là số lượng nhập
                        cmd.Parameters.AddWithValue("@So_Luong_Ton", row.Cells["So_Luong"].Value.ToString());   // Giả sử số lượng tồn là số lượng nhập

                        // Mở kết nối và thực thi câu lệnh
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            MessageBox.Show("Lưu thông tin thành công!");
            GenerateHDNCode();
            dataGridView1.Rows.Clear();
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
