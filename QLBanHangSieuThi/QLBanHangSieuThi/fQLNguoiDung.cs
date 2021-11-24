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
    public partial class fQLNguoiDung : Form
    {
        public fQLNguoiDung()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void fQLNguoiDung_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSELECT = "select * from Login ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataLogin.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO Login VALUES(@TaiKhoan,@MatKhau)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string sqlEDIT = "UPDATE Login SET MatKhau = @MatKhau WHERE TaiKhoan = @TaiKhoan";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            string sqlDELETE = "DELETE FROM Login WHERE TaiKhoan = @TaiKhoan";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@TaiKhoan", tbTaiKhoan.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tbMatKhau.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fBanHang banhang = new fBanHang();
            banhang.ShowDialog();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
            hoadon.ShowDialog();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            fHoaDonBan hoadon = new fHoaDonBan();
            hoadon.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fThongKe thongke = new fThongKe();
            thongke.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang khachhang = new fKhachHang();
            khachhang.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien nhanvien = new fNhanVien();
            nhanvien.ShowDialog();
        }
    }
}
