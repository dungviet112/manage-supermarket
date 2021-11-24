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

namespace QLBanHangSieuThi
{
    public partial class FormReportKH : Form
    {
        public FormReportKH()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void FormReportKH_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            string sql;
            sql = $"select * from KhachHang";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangSieuThi.ReportKH.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
