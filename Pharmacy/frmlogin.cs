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

namespace Pharmacy
{
    public partial class frmlogin : Form
    {
        public class NhanVienInfo
        {
            public string MaNV { get; set; }    
            public string Ten { get; set; }  
            public string SDT { get; set; }    
            public string Email { get; set; }   
            public string Chucvu { get; set; }
            public string Username { get; set; } 
            public string Password { get; set; } 
            public byte[] HinhAnh { get; set; }  
        }
        public frmlogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connectionString = @"Data Source=LAPTOP-I5KR571R\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";

            // SQL query to fetch the role (Chuc_vu) based on username and password
            string query = "SELECT * FROM Nhanvien WHERE LOWER(Username) = LOWER(@Username) AND Password = @Password";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Kiểm tra kết nối đến cơ sở dữ liệu
                try
                {
                    con.Open();
                    //MessageBox.Show("Connected to Database successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                    return; // Ngừng lại nếu không kết nối được
                }
                finally
                {
                    con.Close();
                }

                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Username", txtuser.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());

                try
                {
                    con.Open(); // Mở kết nối lại để thực thi truy vấn
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) // Kiểm tra nếu có hàng nào trả về
                    {
                        reader.Read();
                        string chucVu = reader["Chuc_vu"].ToString();
                        UserSession.CurrentNhanVien = new NhanVienInfo
                        {
                            MaNV = reader.GetString(0),
                            Ten = reader.GetString(1),
                            Chucvu = reader.GetString(2),
                            SDT = reader.GetString(3),
                            Email = reader.GetString(4),
                            Username = reader.GetString(5),
                            Password = reader.GetString(6),
                            HinhAnh = (byte[])reader["Hinh_Anh"]

                        };

                        // Phân quyền dựa trên Chuc_vu
                        if (chucVu == "Quản lý")
                        {
                            MessageBox.Show("Welcome, Manager!");
                            this.Hide();
                            frmMenu adminForm = new frmMenu(); // Chuyển đến form Admin
                            adminForm.Show();
                        }
                        else if (chucVu == "Nhân viên")
                        {
                            MessageBox.Show("Welcome, Employee!");
                            this.Hide();
                            EmployeeMenu employeeMenu = new EmployeeMenu(); // Chuyển đến form Nhân viên
                            employeeMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role. Please contact support.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        public static class UserSession
        {
            public static NhanVienInfo CurrentNhanVien { get; set; }
        }
        private void clearbutton_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpassword.Clear();
        }
    }
}
