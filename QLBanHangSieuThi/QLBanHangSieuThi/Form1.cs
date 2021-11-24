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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        fHome home = new fHome();
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                var tk = tbTaiKhoan.Text;
                var mk = tbMatKhau.Text;
                string sql = $"SELECT * FROM Login WHERE TaiKhoan =N'{tk}' and MatKhau =N'{mk}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi");
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fDangKy dangky = new fDangKy();
            dangky.ShowDialog();
        }
    }
}
