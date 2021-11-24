using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace QLBanHangSieuThi
{
    public partial class SPBanChay : Form
    {
        SqlConnection con;
        
        
        public SPBanChay()
        {
            InitializeComponent();
        }
        fThongKe thongke = new fThongKe();
        private void SPBanChay_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            string sql;
            var month = thongke.TimKiem;
            sql = $"exec SPBanChay '11'";  //11 = {month}
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangSieuThi.rptSPBanChay.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
