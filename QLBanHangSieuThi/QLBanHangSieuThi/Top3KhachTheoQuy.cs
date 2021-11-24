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
    public partial class Top3KhachTheoQuy : Form
    {
        SqlConnection con;
        public Top3KhachTheoQuy()
        {
            InitializeComponent();
        }

        private void Top3KhachTheoQuy_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            string sql;

            sql = $"exec TopKhachHang '10','11','12'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            con.Close();

            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBanHangSieuThi.ReportKhachTheoQuy.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
