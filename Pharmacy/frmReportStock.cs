using Microsoft.Reporting.WinForms;
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
    public partial class frmReportStock : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, constr, para1, para2;

        private void btnCreate_Click(object sender, EventArgs e)
        {

            sql = "SELECT   dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT, SUM(ISNULL(ctdn.So_Luong, 0)) AS TongSLNhap,    " +
                "SUM(ISNULL(ctbn.So_Luong, 0)) AS TongSLXuat, SUM(ISNULL(ctdn.So_Luong, 0)) - SUM(ISNULL(ctbn.So_Luong, 0)) AS TonKho " +
                "FROM  DanhMucThuoc dm " +
                "LEFT JOIN CTHoaDonNhap ctdn ON dm.Ma_Thuoc = ctdn.Ma_Thuoc " +
                "LEFT JOIN CTHoaDonBan ctbn ON dm.Ma_Thuoc = ctbn.Ma_Thuoc " +
                "GROUP BY dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT;";

            adapter = new SqlDataAdapter(sql, conn);
            dt.Clear(); adapter.Fill(dt);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
            rptStock.LocalReport.DataSources.Clear();
            rptStock.LocalReport.DataSources.Add(reportDataSource);
            //báo cáo được tích hợp, nhúng
            rptStock.LocalReport.ReportEmbeddedResource = "Pharmacy.rptStock.rdlc";
            //para1 = "Từ ngày: " + dtFrom.Text + " Đến ngày: " + dtTo.Text;
            para2 = "Quản lý";
            ReportParameter[] reportparameters = new ReportParameter[]
            {
                //new ReportParameter("prTime",para1),
                new ReportParameter("prCreator", para2)
            };


            rptStock.LocalReport.SetParameters(reportparameters);


            rptStock.RefreshReport();
        }

        public frmReportStock()
        {
            InitializeComponent();
        }

        private void frmReportStock_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-ILTU31H\\GIOS;Initial Catalog=Pharmacy;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();

        }
    }
}