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
        string sql, constr, para1, para2;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sql = "SELECT HoaDonBan.Ma_CT, HoaDonBan.Ngay_CT, DanhMucThuoc.Ma_Thuoc, DanhMucThuoc.Ten_Thuoc, DanhMucThuoc.DVT, " +
                "CTHoaDonBan.So_Luong, DanhMucThuoc.DonGia " +
                "FROM   HoaDonBan INNER JOIN " +
                "CTHoaDonBan ON HoaDonBan.Ma_CT = CTHoaDonBan.Ma_HDB INNER JOIN " +
                "DanhMucThuoc ON CTHoaDonBan.Ma_Thuoc = DanhMucThuoc.Ma_Thuoc " +
                "WHERE Ngay_CT BETWEEN CONVERT (date, '" + dtFrom.Text + "', 103) AND CONVERT(date, '" + dtTo.Text + "', 103) " +
                "Order by HoaDonBan.Ma_CT";

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
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();
           
        }
    }
}
