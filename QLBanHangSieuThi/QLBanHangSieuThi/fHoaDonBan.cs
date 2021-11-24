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
    public partial class fHoaDonBan : Form
    {
        SqlConnection con;
        public fHoaDonBan()
        {
            InitializeComponent();
        }

        private void fHoaDonBan_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThiHDB();
            HienThiChiTietHDB();
        }
        public void HienThiHDB()
        {
            string sqlSELECT = "select * from HoaDonBan ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDB.DataSource = dt;
        }
        public void HienThiChiTietHDB()
        {
            string sqlSELECT = "select * from ChiTietHDB ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCTHDB.DataSource = dt;
        }

        private void btnThemHDB_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO HoaDonBan VALUES(@SoHDB,@MaNV,@NgayBan,@MaKhach,@TongTien)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB1.Text);
                cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
                cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
                cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
                cmd.Parameters.AddWithValue("@TongTien", tbTongTien.Text);
                cmd.ExecuteNonQuery();
                HienThiHDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số HDB đã có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE HoaDonBan SET MaNV = @MaNV , NgayBan = @NgayBan, MaKhach = @MaKhach,TongTien = @TongTien WHERE SoHDB = @SoHDB";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB1.Text);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TongTien", tbTongTien.Text);
            cmd.ExecuteNonQuery();
            HienThiHDB();
        }

        private void btnXoaHDB_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM HoaDonBan WHERE SoHDB = @SoHDB";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB1.Text);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TongTien", tbTongTien.Text);
            cmd.ExecuteNonQuery();
            HienThiHDB();
        }

        private void btnLamMoiHDB_Click(object sender, EventArgs e)
        {
            HienThiHDB();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fBanHang banhang = new fBanHang();
            banhang.ShowDialog();
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

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
            hoadon.ShowDialog();
        }
        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {

        }

        private void btnThemCTHDB_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO ChiTietHDB VALUES(@SoHDB,@MaVach,@SoLuong,@GiamGia,@ThanhTien)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB2.Text);
                cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
                cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
                cmd.ExecuteNonQuery();
                HienThiChiTietHDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số HDB đã có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSuaCTHDB_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE ChiTietHDB SET MaVach = @MaVach , SoLuong = @SoLuong , GiamGia = @GiamGia , ThanhTien = @ThanhTien WHERE SoHDB = @SoHDB";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            HienThiChiTietHDB();
        }

        private void btnXoaCTHDB_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM ChiTietHDB WHERE SoHDB = @SoHDB";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            HienThiChiTietHDB();
        }

        private void btnLamMoiCTHDB_Click(object sender, EventArgs e)
        {
            HienThiChiTietHDB();
        }

        private void btnTimKiemHDB_Click(object sender, EventArgs e)
        {
            var table = tbTimKiemHDB.Text;
            string sqlFIND = $"SELECT * FROM HoaDonBan WHERE SoHDB = N'{table}'";
            SqlCommand cmd = new SqlCommand(sqlFIND, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB1.Text);
            cmd.Parameters.AddWithValue("@MaNV", tbMaNV.Text);
            cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
            cmd.Parameters.AddWithValue("@MaKhach", tbMaKhach.Text);
            cmd.Parameters.AddWithValue("@TongTien", tbTongTien.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDB.DataSource = dt;
        }

        private void btnTimKiemCTHDB_Click(object sender, EventArgs e)
        {
            var table = tbTimKiemCTHDB.Text;
            string sqlFIND = $"SELECT * FROM ChiTietHDB WHERE SoHDB = N'{table}'";
            SqlCommand cmd = new SqlCommand(sqlFIND, con);
            cmd.Parameters.AddWithValue("@SoHDB", tbSoHDB2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCTHDB.DataSource = dt;
        }

        private void btnInHDB_Click(object sender, EventArgs e)
        {
            fReport formReport = new fReport();
            formReport.ShowDialog();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            fQLNguoiDung quanly = new fQLNguoiDung();
            quanly.ShowDialog();
        }

        private void dgvHDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbSoHDB1.Text = dgvHDB[0, e.RowIndex].Value.ToString();
                tbMaNV.Text = dgvHDB[1, e.RowIndex].Value.ToString();
                dtpNgayBan.Value = (DateTime)dgvHDB[2, e.RowIndex].Value;
                tbMaKhach.Text = dgvHDB[3, e.RowIndex].Value.ToString();
                tbTongTien.Text = dgvHDB[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvCTHDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbSoHDB2.Text = dgvCTHDB[0, e.RowIndex].Value.ToString();
                tbMaVach.Text = dgvCTHDB[1, e.RowIndex].Value.ToString();
                tbSoLuong.Text = dgvCTHDB[2, e.RowIndex].Value.ToString();
                tbGiamGia.Text = dgvCTHDB[3, e.RowIndex].Value.ToString();
                tbThanhTien.Text = dgvCTHDB[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void tbTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbMaVach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
