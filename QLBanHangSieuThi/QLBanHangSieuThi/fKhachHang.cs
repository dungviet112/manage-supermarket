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
    public partial class fKhachHang : Form
    {
        SqlConnection con;
        public fKhachHang()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            string sqlSELECT = "select * from KhachHang ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            { 
            string sqlINSERT = "INSERT INTO KhachHang VALUES(@MaKhach,@TenKhach,@DiaChi,@DienThoai)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TenKhach", tbTenKhach.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.ExecuteNonQuery();
            HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã khách hàng đã có", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
}

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE KhachHang SET TenKhach = @TenKhach, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE MaKhach = @MaKhach";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TenKhach", tbTenKhach.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM KhachHang where MaKhach = @MaKhach";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TenKhach", tbTenKhach.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReportKH formreport = new FormReportKH();
            formreport.ShowDialog();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string sqlFIND = "SELECT * FROM KhachHang WHERE MaKhach = @MaKhach";
            SqlCommand cmd = new SqlCommand(sqlFIND, con);
            cmd.Parameters.AddWithValue("@MaKhach", tbTimKiem.Text);
            cmd.Parameters.AddWithValue("@TenKhach", tbTenKhach.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
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

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
            hoadon.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien nhanvien = new fNhanVien();
            nhanvien.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fThongKe thongke = new fThongKe();
            thongke.ShowDialog();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            fHoaDonBan hoadon = new fHoaDonBan();
            hoadon.ShowDialog();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            fQLNguoiDung quanly = new fQLNguoiDung();
            quanly.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbMaKhach.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                tbTenKhach.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                tbDiaChi.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                tbDienThoai.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void tbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
