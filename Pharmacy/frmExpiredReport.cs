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
    public partial class frmExpiredReport : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr, para1;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sql = "SELECT CTHoaDonNhap.Ma_Lo, CTHoaDonNhap.Ma_HDN, DanhMucThuoc.Ma_Thuoc, DanhMucThuoc.Ten_Thuoc, " +
                "CTHoaDonNhap.Ma_NCC, CTHoaDonNhap.NSX, CTHoaDonNhap.HSD " +
                "FROM DanhMucThuoc INNER JOIN " +
                "CTHoaDonNhap ON DanhMucThuoc.Ma_Thuoc = CTHoaDonNhap.Ma_Thuoc INNER JOIN " +
                "HoaDonNhap ON CTHoaDonNhap.Ma_HDN = HoaDonNhap.Ma_CT";

           // CONVERT(date, '" + dtTo.Text + "', 103)

            adapter = new SqlDataAdapter(sql, conn);
            dt.Clear(); adapter.Fill(dt);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet2", dt);
            rptExpire.LocalReport.DataSources.Clear();
            rptExpire.LocalReport.DataSources.Add(reportDataSource);
            //báo cáo được tích hợp, nhúng
            rptExpire.LocalReport.ReportEmbeddedResource = "Pharmacy.rptExpire.rdlc";
           
            para1 = "Quản lý";
            ReportParameter[] reportparameters = new ReportParameter[]
            {
                new ReportParameter("prCreator",para1),
                
            };

            rptExpire.LocalReport.SetParameters(reportparameters);


            rptExpire.RefreshReport();

        }

        public frmExpiredReport()
        {
            InitializeComponent();
        }

        private void frmExpiredReport_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();


        }
    }
}
