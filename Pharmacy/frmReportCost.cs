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
using Org.BouncyCastle.Asn1.X509;
using System.Text.RegularExpressions;

namespace Pharmacy
{
    public partial class frmReportCost : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            sql = "SELECT HoaDonNhap.Ma_CT, HoaDonNhap.Ngay_CT, CTHoaDonNhap.Ma_Thuoc, DanhMucThuoc.Ten_Thuoc, CTHoaDonNhap.So_Luong, DanhMucThuoc.DonGiaNhap" +
                " FROM   HoaDonNhap INNER JOIN CTHoaDonNhap ON HoaDonNhap.Ma_CT = CTHoaDonNhap.Ma_HDN INNER JOIN" +
                " DanhMucThuoc ON CTHoaDonNhap.Ma_Thuoc = DanhMucThuoc.Ma_Thuoc " +
                "WHERE Ngay_CT BETWEEN CONVERT(date, '" + dtFrom.Text + "', 103) AND CONVERT(date, '" + dtTo.Text + "', 103) " +
                "Order by HoaDonNhap.Ma_CT";

            adapter = new SqlDataAdapter(sql, conn);
            dt.Clear(); adapter.Fill(dt);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
            rptCost.LocalReport.DataSources.Clear();
            rptCost.LocalReport.DataSources.Add(reportDataSource);
            //báo cáo được tích hợp, nhúng
            rptCost.LocalReport.ReportEmbeddedResource = "Pharmacy.rptCost.rdlc";
            para1 = "Từ ngày: " + dtFrom.Text + " Đến ngày: " + dtTo.Text;
            para2 = "Quản lý";
            ReportParameter[] reportparameters = new ReportParameter[]
            {
                new ReportParameter("prTime",para1),
                new ReportParameter("prCreator", para2)
            };


            rptCost.LocalReport.SetParameters(reportparameters);


            rptCost.RefreshReport();
        }

        public frmReportCost()
        {
            InitializeComponent();
        }

        private void frmReportCost_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();

        }
    }
}
