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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void fReport_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();

            String sql;
            sql = "SELECT * from ReportHDB";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangSieuThi.Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetXuatHDB";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
