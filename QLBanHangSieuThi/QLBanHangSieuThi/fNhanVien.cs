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
    public partial class fNhanVien : Form
    {
        SqlConnection con;
        public fNhanVien()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            string sqlSELECT = "select * from NhanVien ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            { 

            string sqlINSERT = "INSERT INTO NhanVien VALUES(@MaNV,@TenNV,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi,@MaCV,@MaCa,@MaNhom)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@MaCV", tbMaCV.Text);
            cmd.Parameters.AddWithValue("@MaCa", tbMaCa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);          
            cmd.ExecuteNonQuery();
            HienThi();
            }
                catch (Exception ex)
                {
                MessageBox.Show("Mã nhân viên đã có", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
}

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE NhanVien SET  TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai, DiaChi = @DiaChi, MaCV = @MaCV, MaCa = @MaCa, MaNhom = @MaNhom where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@MaCV", tbMaCV.Text);
            cmd.Parameters.AddWithValue("@MaCa", tbMaCa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM NhanVien where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@MaCV", tbMaCV.Text);
            cmd.Parameters.AddWithValue("@MaCa", tbMaCa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReportNV formreport = new FormReportNV();
            formreport.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlFIND = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlFIND, con);
            cmd.Parameters.AddWithValue("@MaNV", tbTimKiem.Text);
            cmd.Parameters.AddWithValue("@TenNV", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", tbTenNV.Text);
            cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@DienThoai", tbDienThoai.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tbDiaChi.Text);
            cmd.Parameters.AddWithValue("@MaCV", tbMaCV.Text);
            cmd.Parameters.AddWithValue("@MaCa", tbMaCa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fBanHang banhang = new fBanHang();
            banhang.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            fKhachHang khachhang = new fKhachHang();
            khachhang.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

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

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
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
                tbMaNV.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                tbTenNV.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                tbGioiTinh.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dataGridView1[3, e.RowIndex].Value;
                tbDienThoai.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                tbDiaChi.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                tbMaCV.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                tbMaCa.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                tbMaNhom.Text = dataGridView1[8, e.RowIndex].Value.ToString();
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
