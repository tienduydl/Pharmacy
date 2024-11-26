using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
using static Pharmacy.frmHDBan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy
{
    public partial class AddPhieuXuat : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public AddPhieuXuat(List<ChiTietDonHang> danhSach, string value)
        {
            InitializeComponent();
            this.danhSachDonHang = danhSach;
            mahdbref = value;
            txtmahdb.Text = mahdbref;

        }
        private List<ChiTietDonHang> danhSachDonHang;
        public string mahdbref {  get; set; }
        

        private void AddPhieuXuat_Load(object sender, EventArgs e)
        {
            if (danhSachDonHang != null)
            {
                foreach (var chiTiet in danhSachDonHang)
                {
                    dataGridView1.Rows.Add(chiTiet.MaThuoc, chiTiet.TenThuoc, chiTiet.DonViTinh, chiTiet.SoLuong);
                }
            }
            LoadAllMed();
            txtmanv.Text = frmlogin.UserSession.CurrentNhanVien.MaNV.ToString();
            GeneratePXCode();
            

        }
        private int getmaxPXcount()
        {
            int count = 0;
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                sql = "SELECT MAX(CAST(SUBSTRING(Ma_CT, 3, LEN(Ma_CT) - 1) AS INT)) FROM PhieuXuat";
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    count = (int)command.ExecuteScalar();
                    conn.Close();
                }
            }

            return count;

        }
        private void GeneratePXCode()
        {
            int maxPX = getmaxPXcount();
            string newPXCode = "PX" + (maxPX + 1).ToString("D3");
            txtmapx.Text = newPXCode;
        }
        private void LoadAllMed()
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            List<string> maThuocList = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ma_Thuoc"].Value != null)
                {
                    maThuocList.Add("'" + row.Cells["Ma_Thuoc"].Value.ToString() + "'");
                }
            }
            List<string> parameterNames = new List<string>();
            for (int i = 0; i < maThuocList.Count; i++)
            {
                parameterNames.Add($"@MaThuoc{i}");
            }
            string inClause = string.Join(", ", parameterNames);
           
            sql = "select tk.ID, tk.Ma_Thuoc, tk.So_Luong_Ton, dm.Ten_Thuoc, dm.DVT, dm.HSQD, dm.Hinh_Anh, ct.NSX, ct.HSD, ncc.Ten_NCC " +
                  "from TonKho tk left join DanhMucThuoc dm on tk.Ma_Thuoc = dm.Ma_Thuoc " +
                  "left join CTHoaDonNhap ct on tk.Ma_Lo = ct.Ma_Lo " +
                  "left join NhaCungCap ncc on ct.Ma_NCC = ncc.Ma_NCC " +
                  $"where tk.Ma_Thuoc in ({inClause}) and ct.HSD > DATEADD(DAY, 14, GETDATE())";

            conn = new SqlConnection(constr);
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                for (int i = 0; i < maThuocList.Count; i++)
                {
                    cmd.Parameters.AddWithValue(parameterNames[i], maThuocList[i].Trim('\''));
                }
                SqlDataReader reader = cmd.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
                while (reader.Read())
                {
                    ProductXuat item = new ProductXuat();
                    item.matonkho = reader["ID"].ToString();
                    item.MaThuoc = reader["Ma_Thuoc"].ToString();
                    item.TenThuoc = reader["Ten_Thuoc"].ToString();
                    item.NhaCungCap = reader["Ten_NCC"].ToString();
                    item.slton = reader["So_Luong_Ton"].ToString();
                    item.donvitinh = reader["DVT"].ToString();
                    item.hesoquydoi = decimal.Parse(reader["HSQD"].ToString());
                    item.nsx = Convert.ToDateTime(reader["NSX"]).ToString("dd/MM/yyyy");
                    item.hsd = Convert.ToDateTime(reader["HSD"]).ToString("dd/MM/yyyy");

                    if (reader["Hinh_Anh"] != DBNull.Value)
                    {
                        byte[] imagebytes = (byte[])reader["Hinh_Anh"];
                        using (MemoryStream ms = new MemoryStream(imagebytes))
                        {
                            item.HinhAnh = Image.FromStream(ms);
                        }
                    }
                    item.AddClickedXuat += ProductXuat_AddClicked;
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            conn.Close();
        }


        private void ProductXuat_AddClicked(object sender, EventArgs e)
        {
            var item = sender as ProductXuat;
            if (item != null && (item.slgoc > 0||item.slquydoi >0))
            {
                string ID = txtmapx.Text + "-" + dataGridView2.RowCount;
                string maTonkho = item.matonkho;              
                string maThuoc = item.MaThuoc;
                decimal soLuong = item.slgoc  + item.slquydoi * item.hesoquydoi; 
                string DVTinh = item.donvitinh;
                if(soLuong > decimal.Parse(item.slton)) {
                    MessageBox.Show(
                $"Số lượng xuất lớn hơn số lượng tồn!",
                "Lỗi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
                    return;
                }

                bool found = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow || row.Cells["MaTK"].Value == null) continue;
                    if (row.Cells["MaTK"].Value != null && row.Cells["MaTK"].Value.ToString() == maTonkho)
                    {
                        decimal currentQuantityInGrid = decimal.Parse(row.Cells["SoLuong"].Value.ToString());
                        row.Cells["SoLuong"].Value = currentQuantityInGrid + soLuong;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dataGridView2.Rows.Add(ID,maTonkho,maThuoc,DVTinh, soLuong.ToString());
                }
                item.slton = (decimal.Parse(item.slton)-soLuong).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row1 in dataGridView1.Rows) // Duyệt qua từng hàng trong bảng trên
            {
                if (!row1.IsNewRow)
                {
                    string maThuoc1 = row1.Cells["Ma_Thuoc"].Value?.ToString(); // Lấy mã thuốc từ bảng trên
                    decimal soLuong1 = Convert.ToDecimal(row1.Cells["So_Luong"].Value); // Lấy số lượng từ bảng trên
                    decimal totalSoLuong2 = 0; // Tổng số lượng của mã thuốc trong bảng dưới

                    foreach (DataGridViewRow row2 in dataGridView2.Rows) // Duyệt qua bảng dưới
                    {
                        if (!row2.IsNewRow)
                        {
                            string maThuoc2 = row2.Cells["MaThuoc"].Value?.ToString(); // Lấy mã thuốc từ bảng dưới
                            if (maThuoc1 == maThuoc2) // Nếu mã thuốc khớp
                            {
                                totalSoLuong2 += Convert.ToDecimal(row2.Cells["SoLuong"].Value); // Cộng số lượng từ bảng dưới
                            }
                        }
                    }

                    // Kiểm tra tổng số lượng của bảng dưới với bảng trên
                    if (soLuong1 != totalSoLuong2)
                    {
                        MessageBox.Show($"Số lượng không khớp cho mã thuốc {maThuoc1}: Bảng trên = {soLuong1}, Bảng dưới = {totalSoLuong2}.",
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            sql = "Insert into PhieuXuat (Ma_CT,Ngay_CT,Ma_HDB,Ma_NV,Dien_Giai)" +
                " Values ('" + txtmapx.Text + "',@Ngay_CT,'" + txtmahdb.Text + "','" + txtmanv.Text + "',N'" + txtmota.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ngay_CT", txtngaytaopx.Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    sql = "INSERT INTO CTPhieuXuat (ID, Ma_PX, Ma_Thuoc, Ma_Kho, So_Luong) " +
      "VALUES (@ID, @Ma_PX, @Ma_Thuoc, @Ma_Kho, @So_Luong)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Ma_PX", txtmapx.Text);
                    cmd.Parameters.AddWithValue("@Ma_Thuoc", row.Cells["MaThuoc"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Ma_Kho", row.Cells["MaTK"].Value);
                    cmd.Parameters.AddWithValue("@So_Luong", decimal.Parse(row.Cells["SoLuong"].Value.ToString()));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    sql = "UPDATE TonKho SET So_Luong_Ton = So_Luong_Ton - @So_Luong WHERE ID = @ID";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@So_Luong", decimal.Parse(row.Cells["SoLuong"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@ID", row.Cells["MaTK"].Value.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            sql = "update HoaDonBan set Trang_Thai =N'Đã xuất hàng' where Ma_CT = '" + txtmahdb.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open(); cmd.ExecuteNonQuery();conn.Close();
            MessageBox.Show("Lưu thông tin thành công!");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            LoadAllMed();
        }
    }
}
