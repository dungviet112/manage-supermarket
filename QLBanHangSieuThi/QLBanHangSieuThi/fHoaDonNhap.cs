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
    public partial class fHoaDonNhap : Form
    {
        public fHoaDonNhap()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void fHoaDonNhap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThiHDN();
            HienThiChiTietHDN();
        }
        public void HienThiHDN()
        {
            string sqlSELECT = "select * from HoaDonNhap ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHDN.DataSource = dt;
        }
        public void HienThiChiTietHDN()
        {
            string sqlSELECT = "select * from ChiTietHDN ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCTHDN.DataSource = dt;
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO HoaDonNhap VALUES(@SoHDN,@MaNV,@NgayNhap,@MaNCC,@TongTien)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN1.Text);
                cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
                cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
                cmd.ExecuteNonQuery();
                HienThiHDN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số HDN đã có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHDN_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE HoaDonNhap SET MaNV = @MaNV , NgayNhap = @NgayNhap , MaNCC=@MaNCC , TongTien = @TongTien WHERE SoHDN = @SoHDN";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN1.Text);
            cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
            cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
            cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
            cmd.ExecuteNonQuery();
            HienThiHDN();
        }

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM HoaDonNhap WHERE SoHDN = @SoHDN";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN1.Text);
            cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
            cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
            cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
            cmd.ExecuteNonQuery();
            HienThiHDN();
        }

        private void btnLamMoiHDN_Click(object sender, EventArgs e)
        {
            HienThiHDN();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Mã Hàng")
            {
                string sqlSELECT = "select * from ChiTietHDN ";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHDN.DataSource = dt;
            }
            if (comboBox2.SelectedItem.ToString() == "Ngày Nhập")
            {
                string sqlSELECT = "select * from HoaDonNhap ";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHDN.DataSource = dt;
            }
            if (comboBox2.SelectedItem.ToString() == "NCC")
            {
                string sqlSELECT = "select * from NhaCungCap ";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHDN.DataSource = dt;
            }
        }

        private void btnTimKiemHDN_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Mã Hàng")
            {
                try
                {
                    var table = tbTimKiemHDN.Text;
                    string sqlFIND = $"SELECT * FROM HoaDonNhap join ChiTietHDN on ChiTietHDN.SoHDN = HoaDonNhap.SoHDN WHERE MaVach = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sqlFIND, con);
                    cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN1.Text);
                    cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
                    cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                    cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
                    cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvHDN.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
                if (comboBox2.SelectedItem.ToString() == "Ngày Nhập")
                {
                    try
                    {
                        var table = tbTimKiemHDN.Text;
                        string sqlFIND = $"SELECT * FROM HoaDonNhap WHERE NgayNhap = N'{table}'";
                        SqlCommand cmd = new SqlCommand(sqlFIND, con);
                        cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
                        cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
                        cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                        cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
                        cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvHDN.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                if (comboBox2.SelectedItem.ToString() == "NCC")
                {
                    try
                    {
                        var table = tbTimKiemHDN.Text;
                        string sqlFIND = $"SELECT * FROM HoaDonNhap join NhaCungCap on NhaCungCap.MaNCC = HoaDonNhap.MaNCC WHERE TenNCC = N'{table}'";
                        SqlCommand cmd = new SqlCommand(sqlFIND, con);
                        cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
                        cmd.Parameters.AddWithValue("@MaNV", tbMaVach.Text);
                        cmd.Parameters.AddWithValue("@NgayNhap", dtpNgayNhap.Value);
                        cmd.Parameters.AddWithValue("@MaNCC", tbDonGia.Text);
                        cmd.Parameters.AddWithValue("@TongTien", tbGiamGia.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvHDN.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fBanHang banhang = new fBanHang();
            banhang.ShowDialog();
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            fHoaDonBan hoadon = new fHoaDonBan();
            hoadon.ShowDialog();
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fThongKe thongke = new fThongKe();
            thongke.ShowDialog();
        }

        private void btnThemCTHDN_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlINSERT = " INSERT INTO ChiTietHDN VALUES(@SoHDB,@MaVach,@SoLuong,@DonGia,@GiamGia,@ThanhTien)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
                cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
                cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
                cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
                cmd.ExecuteNonQuery();
                HienThiChiTietHDN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số HDN đã có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSuaCTHDN_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE ChiTietHDN SET MaVach = @MaVach , SoLuong = @SoLuong , DonGia = @DonGia , GiamGia = @GiamGia, ThanhTien = @ThanhTien WHERE SoHDN = @SoHDN";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            HienThiChiTietHDN();
        }

        private void btnXoaCTHDN_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM ChiTietHDN WHERE SoHDN = @SoHDN";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            HienThiChiTietHDN();
        }

        private void btnLamMoiCTHDN_Click(object sender, EventArgs e)
        {
            HienThiChiTietHDN();
        }

        private void btnTimKiemCTHDN_Click(object sender, EventArgs e)
        {
            var table = tbTimKiemCTHDN.Text;
            string sqlFIND = $"SELECT * FROM ChiTietHDN WHERE SoHDN = N'{table}'";
            SqlCommand cmd = new SqlCommand(sqlFIND, con);
            cmd.Parameters.AddWithValue("@SoHDN", tbSoHDN2.Text);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", tbDonGia.Text);
            cmd.Parameters.AddWithValue("@GiamGia", tbGiamGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", tbThanhTien.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvCTHDN.DataSource = dt;
        }

        private void btnInHDN_Click(object sender, EventArgs e)
        {
            fReportHDN report = new fReportHDN();
            report.ShowDialog();
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            fQLNguoiDung quanly = new fQLNguoiDung();
            quanly.ShowDialog();
        }

        private void dgvHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbSoHDN1.Text = dgvHDN[0, e.RowIndex].Value.ToString();
                tbMaNV.Text = dgvHDN[1, e.RowIndex].Value.ToString();
                dtpNgayNhap.Value = (DateTime)dgvHDN[2, e.RowIndex].Value;
                tbMaNCC.Text = dgvHDN[3, e.RowIndex].Value.ToString();
                tbTongTien.Text = dgvHDN[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvCTHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbSoHDN2.Text = dgvCTHDN[0, e.RowIndex].Value.ToString();
                tbMaVach.Text = dgvCTHDN[1, e.RowIndex].Value.ToString();
                tbSoLuong.Text = dgvCTHDN[2, e.RowIndex].Value.ToString();
                tbDonGia.Text = dgvCTHDN[3, e.RowIndex].Value.ToString();
                tbGiamGia.Text = dgvCTHDN[4, e.RowIndex].Value.ToString();
                tbThanhTien.Text = dgvCTHDN[5, e.RowIndex].Value.ToString();
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

        private void tbDonGia_KeyPress(object sender, KeyPressEventArgs e)
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
