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
        string sql, constr, para2, maloai;
        int comboboxprev;

        private void rptStock_Load(object sender, EventArgs e)
        {

        }

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
            if (!string.IsNullOrEmpty(comboBox1.Text))
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
                string sql = "SELECT   dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT, dm.Ma_Loai, " +
             "SUM(ISNULL(ctdn.So_Luong, 0)) AS TongSLNhap, " +
             "SUM(ISNULL(ctpx.So_Luong, 0)) AS TongSLXuat, " +
             "SUM(ISNULL(ctdn.So_Luong, 0)) - SUM(ISNULL(ctpx.So_Luong, 0)) AS TonKho " +
             "FROM DanhMucThuoc dm " +
             "LEFT JOIN CTHoaDonNhap ctdn ON dm.Ma_Thuoc = ctdn.Ma_Thuoc " +
             "LEFT JOIN CTPhieuXuat ctpx ON dm.Ma_Thuoc = ctpx.Ma_Thuoc " +
             "WHERE dm.Ma_Loai = '"+ maloai +"' " +
             "GROUP BY dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT, dm.Ma_Loai;";
            }
            else
            {
                sql = "SELECT   dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT, SUM(ISNULL(ctdn.So_Luong, 0)) AS TongSLNhap,    " +
                "SUM(ISNULL(ctpx.So_Luong, 0)) AS TongSLXuat, SUM(ISNULL(ctdn.So_Luong, 0)) - SUM(ISNULL(ctpx.So_Luong, 0)) AS TonKho " +
                "FROM  DanhMucThuoc dm " +
                "LEFT JOIN CTHoaDonNhap ctdn ON dm.Ma_Thuoc = ctdn.Ma_Thuoc " +
               "LEFT JOIN CTPhieuXuat ctpx ON dm.Ma_Thuoc = ctpx.Ma_Thuoc " +
                "GROUP BY dm.Ma_Thuoc, dm.Ten_Thuoc, dm.DVT;";
            }
               

            adapter = new SqlDataAdapter(sql, conn);
            dt.Clear(); adapter.Fill(dt);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
            rptStock.LocalReport.DataSources.Clear();
            rptStock.LocalReport.DataSources.Add(reportDataSource);
            //báo cáo được tích hợp, nhúng
            rptStock.LocalReport.ReportEmbeddedResource = "Pharmacy.rptStock.rdlc";
            para2 = "Quản lý";
            ReportParameter[] reportparameters = new ReportParameter[]
            {
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
            constr = "Data Source=LAPTOP-I5KR571R\\DUY;Initial Catalog=Pharmacy;Encrypt=False;User id=Pharmacy;Password = 1234";
            conn.ConnectionString = constr;
            conn.Open();

        }
    }
}