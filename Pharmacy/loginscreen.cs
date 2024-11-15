using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy
{
    public partial class loginscreen : Form
    {
        public loginscreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connectionString = @"Data Source=DESKTOP-2URP72G\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            // SQL query to fetch the role (Chuc_vu) based on username and password
            string query = "SELECT Chuc_vu FROM Nhanvien WHERE LOWER(Username) = LOWER(@Username) AND Password = @Password";

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
                cmd.Parameters.AddWithValue("@Username", txtuserr.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text.Trim());

                try
                {
                    con.Open(); // Mở kết nối lại để thực thi truy vấn
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) // Kiểm tra nếu có hàng nào trả về
                    {
                        reader.Read();
                        string chucVu = reader["Chuc_vu"].ToString(); // Lấy giá trị Chuc_vu
                        //MessageBox.Show("Role: " + chucVu);

                        // Phân quyền dựa trên Chuc_vu
                        if (chucVu == "Admin")
                        {
                            MessageBox.Show("Welcome, Admin!");
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
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Đảm bảo đóng kết nối
                }
            }
        }

        private void loginscreen_Load(object sender, EventArgs e)
        {
            // Initialize settings or preload data if necessary.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // No additional logic needed here for now.
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // No additional logic needed here for now.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic for combo box selection changes (if applicable).
        }
    }
}