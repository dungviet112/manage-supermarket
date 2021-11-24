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
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void fDangKy_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO Login VALUES(@TaiKhoan,@MatKhau)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
