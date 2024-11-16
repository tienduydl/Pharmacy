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
                  $"where tk.Ma_Thuoc in ({inClause})";

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
            if (item != null && (item.slhop > 0||item.slvi >0))
            {
                string ID = txtmapx.Text + "-" + dataGridView2.RowCount;
                string maTonkho = item.matonkho;              
                string maThuoc = item.MaThuoc;
                decimal soLuong = item.slvi * item.hesoquydoi + item.slhop * item.hesoquydoi; 
                string DVTinh = item.donvitinh;

                bool found = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow || row.Cells["MaTK"].Value == null) continue;
                    if (row.Cells["MaTK"].Value != null && row.Cells["MaTK"].Value.ToString() == maTonkho)
                    {
                        decimal currentQuantityInGrid = decimal.Parse(row.Cells["SoLuong"].Value.ToString());
                        row.Cells["So_Luong"].Value = currentQuantityInGrid + soLuong;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dataGridView2.Rows.Add(ID,maTonkho,maThuoc,DVTinh, soLuong.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    sql = "Insert into CTPhieuXuat ( ID,Ma_PX,Ma_Thuoc,Ma_Kho,So_Luong) " +
                        "Values ( '" + row.Cells["ID"].Value.ToString() + "','"+txtmapx.Text+"','" + row.Cells["MaThuoc"].Value.ToString() + "','" + row.Cells["MaTK"].Value + "','" + row.Cells["SoLuong"].Value + "')";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open(); cmd.ExecuteNonQuery(); conn.Close();
                    sql = "update TonKho set So_Luong_Ton = So_Luong_Ton - '" + decimal.Parse(row.Cells["SoLuong"].Value.ToString()) + "' where ID = '" + row.Cells["MaTK"].Value.ToString() +"'";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open(); cmd.ExecuteNonQuery();conn.Close();
                }
            }
            sql = "update HoaDonBan set Trang_Thai =N'Đã xuất hàng' where Ma_CT = '" + txtmahdb.Text + "'";
            cmd = new SqlCommand(sql, conn);
            conn.Open(); cmd.ExecuteNonQuery();conn.Close();
            MessageBox.Show("Lưu thông tin thành công!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null && !dataGridView2.CurrentRow.IsNewRow)
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            }
        }
    }
}
