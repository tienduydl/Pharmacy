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
using Microsoft.Reporting.WinForms;

namespace Pharmacy
{
    public partial class frmReportRevenue : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2,maloai;
        int comboboxprev;

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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {   
            if(!string.IsNullOrEmpty(comboBox1.Text))
            {
                switch (comboBox1.SelectedIndex)
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
                sql = "SELECT HoaDonBan.Ma_CT, HoaDonBan.Ngay_CT, DanhMucThuoc.Ma_Thuoc, DanhMucThuoc.Ma_Loai, DanhMucThuoc.Ten_Thuoc, DanhMucThuoc.DVT, " +
                "CTHoaDonBan.So_Luong, DanhMucThuoc.DonGia " +
                "FROM   HoaDonBan INNER JOIN " +
                "CTHoaDonBan ON HoaDonBan.Ma_CT = CTHoaDonBan.Ma_HDB INNER JOIN " +
                "DanhMucThuoc ON CTHoaDonBan.Ma_Thuoc = DanhMucThuoc.Ma_Thuoc " +
                "WHERE DanhMucThuoc.Ma_Loai = '"+ maloai +"' and Ngay_CT BETWEEN CONVERT (date, '" + dtFrom.Text + "', 103) AND CONVERT(date, '" + dtTo.Text + "', 103) " +
                "Order by HoaDonBan.Ma_CT";
            }
            else
            {
                sql = "SELECT HoaDonBan.Ma_CT, HoaDonBan.Ngay_CT, DanhMucThuoc.Ma_Thuoc, DanhMucThuoc.Ten_Thuoc, DanhMucThuoc.DVT, " +
                "CTHoaDonBan.So_Luong, DanhMucThuoc.DonGia " +
                "FROM   HoaDonBan INNER JOIN " +
                "CTHoaDonBan ON HoaDonBan.Ma_CT = CTHoaDonBan.Ma_HDB INNER JOIN " +
                "DanhMucThuoc ON CTHoaDonBan.Ma_Thuoc = DanhMucThuoc.Ma_Thuoc " +
                "WHERE Ngay_CT BETWEEN CONVERT (date, '" + dtFrom.Text + "', 103) AND CONVERT(date, '" + dtTo.Text + "', 103) " +
                "Order by HoaDonBan.Ma_CT";
            }
            

            adapter = new SqlDataAdapter(sql, conn);
            dt.Clear(); adapter.Fill(dt);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
            rptRevenue.LocalReport.DataSources.Clear();
            rptRevenue.LocalReport.DataSources.Add(reportDataSource);
            //báo cáo được tích hợp, nhúng
            rptRevenue.LocalReport.ReportEmbeddedResource = "Pharmacy.rptRevenue.rdlc";
            para1 = "Từ ngày: " + dtFrom.Text + " Đến ngày: " + dtTo.Text;
            para2 = "Quản lý";
            ReportParameter[] reportparameters = new ReportParameter[]
            {
                new ReportParameter("prTime",para1),
                new ReportParameter("prCreator", para2)
            };


            rptRevenue.LocalReport.SetParameters(reportparameters);
           

            rptRevenue.RefreshReport();
        }
        
        public frmReportRevenue()
        {
            InitializeComponent();
        }

        private void frmReportRevenue_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            conn.ConnectionString = constr;
            conn.Open();
           
        }
    }
}
