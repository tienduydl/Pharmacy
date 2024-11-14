using Microsoft.Build.Evaluation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class AddHDB : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        private int comboboxprev = -1;
        public AddHDB()
        {
            InitializeComponent();
        }

        private void LoadCus()
        {
            sql = "Select Ma_KH, Ten_KH from KhachHang";
            conn = new SqlConnection(constr);
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            comboBox2.DisplayMember = "Ten_KH";
            comboBox2.ValueMember = "Ma_KH";
            comboBox2.DataSource = dt;
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
                    fpanelsanpham.Controls.Clear();
                    while (reader.Read())
                    {
                        ProductItem item = new ProductItem();
                        item.MaThuoc = reader["Ma_Thuoc"].ToString();
                        item.TenThuoc = reader["Ten_Thuoc"].ToString();
                        item.Price = reader["DonGia"].ToString();
                        item.Donvitinh = reader["DVT_QD"].ToString();
                        if (reader["Hinh_Anh"]!= DBNull.Value)
                        {
                            byte[] imagebytes = (byte[])reader["Hinh_Anh"];
                            using (MemoryStream ms = new MemoryStream(imagebytes))
                            {
                                item.HinhAnh = Image.FromStream(ms);
                            }
                        }
                        item.AddClicked += ProductItem_AddClicked;
                    fpanelsanpham.Controls.Add(item);
                    }
                  }
                }
            }
        private void ProductItem_AddClicked(object sender, EventArgs e)
        {
            var item = sender as ProductItem;
            if (item != null && item.soluong >0)
            {
                string tenThuoc = item.TenThuoc;
                decimal soLuong = item.soluong; 
                decimal donGia = decimal.Parse(item.Price);
                decimal thanhTien = donGia * soLuong;
                string maThuoc = item.MaThuoc;
                string dvt = item.Donvitinh;
               
                bool found = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["Ten_Thuoc"].Value != null && row.Cells["Ten_Thuoc"].Value.ToString() == tenThuoc)
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
                    dataGridView1.Rows.Add(maThuoc, tenThuoc, dvt, donGia.ToString(), soLuong.ToString(), thanhTien.ToString());
                }
                
            }
        }
        private void UpdateAllMed()
        {
            
            if ((string.IsNullOrEmpty(textBox1.Text)||textBox1.Text == "Tìm kiếm...")&&comboboxprev == -1)
            {
                sql = "Select * from DanhMucThuoc";
            }
            else if((string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm kiếm...") && comboboxprev != -1)
            {
                sql = "select Ma_Thuoc,Ten_Thuoc,DonGia,Mo_ta,Hinh_Anh,Ten_Loai" +
                    "\r\nfrom DanhMucThuoc dm left join Loai on dm.Ma_Loai = Loai.Ma_Loai where Ten_Loai LIKE N'" + comboBox1.Text + "'  ";
            }
            else if ( comboboxprev == -1)
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
                    fpanelsanpham.Controls.Clear();
                    while (reader.Read())
                    {
                        ProductItem item = new ProductItem();
                        item.TenThuoc = reader["Ten_Thuoc"].ToString();
                        item.Price = reader["DonGia"].ToString();
                        if (reader["Hinh_Anh"] != DBNull.Value)
                        {
                            byte[] imagebytes = (byte[])reader["Hinh_Anh"];
                            using (MemoryStream ms = new MemoryStream(imagebytes))
                            {
                                item.HinhAnh = Image.FromStream(ms);
                            }
                        }
                        fpanelsanpham.Controls.Add(item);
                    }
                }
            }
        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "Tìm kiếm...")) { UpdateAllMed(); }
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxprev == comboBox1.SelectedIndex)
            {
                comboboxprev = -1;
                comboBox1.SelectedIndex = -1;
            }
            else {
                comboboxprev = comboBox1.SelectedIndex;
            }
            
            UpdateAllMed();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           if(textBox1.Text == "Tìm kiếm...")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            txttotal.Text = TotalMoney().ToString();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txttotal.Text = TotalMoney().ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txttotal.Text = TotalMoney().ToString();
        }

        private void trabutton_Click(object sender, EventArgs e)
        {
            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                int returnedQuantity = Convert.ToInt32(soluongtrainput.Text);
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

                txttotal.Text = TotalMoney().ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để trả.");
            }
        }
        private int getmaxHDBcount()
        {
            int count = 0;
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_CT, 3, LEN(Ma_CT) - 1) AS INT)) FROM HoaDonBan";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            return count;

        }
        private void GenerateHDBCode()
        {
            int maxHDB = getmaxHDBcount();
            string newHDBCode = "HD" + (maxHDB + 1).ToString("D3");
            txtmahdb.Text = newHDBCode;
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            sql = "Insert into HoaDonBan (Ma_CT,Ngay_CT,Ma_KH,Ma_NV,Tong_tien,Dien_Giai)" +
                " Values ('" + txtmahdb.Text + "',@Ngay_CT,'" + comboBox2.SelectedValue + "','"+txtnv.Text+"','" + txttotal.Text + "',N'" + txtghichu.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ngay_CT", ngayhoadon.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string i = String.Concat(txtmahdb.Text,"-", row.Index+1);
                    sql = "Insert into CTHoaDonBan ( ID,Ma_HDB,Ma_Thuoc,DVT,So_Luong,Don_Gia,Thanh_Tien) " +
                        "Values ( '" + i + "','"+txtmahdb.Text+"','" + row.Cells["Ma_Thuoc"].Value + "',N'" + row.Cells["DVT"].Value + "','" + row.Cells["So_Luong"].Value + "','" + row.Cells["Don_Gia"].Value + "','" + row.Cells["Thanh_Tien"].Value + "')";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open(); cmd.ExecuteNonQuery(); conn.Close();
                }
            }
            MessageBox.Show("Lưu thông tin thành công!");
            GenerateHDBCode();
            dataGridView1.Rows.Clear();
        }

        private void AddHDB_Load(object sender, EventArgs e)
        {
           LoadAllMed();
            LoadCus();
            GenerateHDBCode();
        }
        }
    }

