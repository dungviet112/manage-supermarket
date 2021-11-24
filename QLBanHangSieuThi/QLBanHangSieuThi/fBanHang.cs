using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    public partial class fBanHang : Form
    {
        SqlConnection con; 
        public fBanHang()
        {
            InitializeComponent();

        }
        public void HienThi()
        {
            string sqlSELECT = "select * from DMHangHoa ";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void fBanHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            HienThi();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(picHinhAnh.Image);
                //byte[] b = PathToByteArray(this.Text);
                string sqlINSERT = " INSERT INTO DMHangHoa VALUES(@MaVach,@TenHangHoa,@MaNhom,@MaLoai,@NhapKhau,@MaDonVi,@MaChatLieu,@MaCongDung,@MaNoiSX,@SoLuong,@DonGiaNhap,@DonGiaBan,@Anh,@GhiChu)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
                cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
                cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
                cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
                cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
                cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
                cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
                cmd.Parameters.AddWithValue("@Anh", b);
                cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã vạch đã có", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        byte[] PathToByteArray(String path)
        {
            MemoryStream m = new MemoryStream();
            //Image img = Image.FromFile(path);
            //img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            //return m.ToArray();
            return File.ReadAllBytes(path);
        }
        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picHinhAnh.Image);
            string sqlEDIT = "UPDATE DMHangHoa SET TenHangHoa = @TenHangHoa , MaNhom = @MaNhom, MaLoai = @MaLoai,NhapKhau = @NhapKhau, MaDonVi = @MaDonVi,MaChatLieu = @MaChatLieu, MaCongDung = @MaCongDung,MaNoiSX = @MaNoiSX, SoLuong = @SoLuong,DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan,Anh=@Anh,GhiChu = @GhiChu WHERE MaVach = @MaVach";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
            cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
            cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
            cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
            cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
            cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
            cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
            cmd.Parameters.AddWithValue("@Anh", b);
            cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picHinhAnh.Image);
            string sqlDELETE = "DELETE FROM DMHangHoa WHERE MaVach = @MaVach"; 
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
            cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
            cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
            cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
            cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
            cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
            cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
            cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
            cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
            cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
            cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
            cmd.Parameters.AddWithValue("@Anh", b);
            cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            /**
                //byte[] b = ImageToByteArray(picHinhAnh.Image);
                string sqlFIND = $"SELECT * FROM DMHangHoa WHERE MaVach = @MaVach";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.Parameters.AddWithValue("@MaVach", tbTimKiem.Text);
                cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
                cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
                cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
                cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
                cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
                cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
                cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
                cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
                //cmd.Parameters.AddWithValue("@Anh", b);
                cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
        **/
            if(comboBox1.SelectedItem.ToString()=="Nhóm")
            {
                try
                {
                    var table = tbTimKiem.Text;
                    string sqlFIND = $"SELECT * FROM DMHangHoa join NhomHang on NhomHang.MaNhom = DMHangHoa.MaNhom WHERE TenNhom = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sqlFIND, con);
                    cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                    cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
                    cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
                    cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
                    cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
                    cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
                    cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
                    cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
                    //cmd.Parameters.AddWithValue("@Anh", b);
                    cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Vui long nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Chất Liệu")
            {
                try
                {
                    var table = tbTimKiem.Text;
                    string sqlFIND = $"SELECT * FROM DMHangHoa join ChatLieu on ChatLieu.MaChatLieu = DMHangHoa.MaChatLieu WHERE TenChatLieu = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sqlFIND, con);
                    cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                    cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
                    cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
                    cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
                    cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
                    cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
                    cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
                    cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
                    //cmd.Parameters.AddWithValue("@Anh", b);
                    cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui long nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Công Dụng")
            {
                try
                {
                    var table = tbTimKiem.Text;
                    string sqlFIND = $"SELECT * FROM DMHangHoa join CongDung on CongDung.MaCongDung = DMHangHoa.MaCongDung WHERE TenCongDung = N'{table}'";
                    SqlCommand cmd = new SqlCommand(sqlFIND, con);
                    cmd.Parameters.AddWithValue("@MaVach", tbMaVach.Text);
                    cmd.Parameters.AddWithValue("@TenHangHoa", tbTenHangHoa.Text);
                    cmd.Parameters.AddWithValue("@MaNhom", tbMaNhom.Text);
                    cmd.Parameters.AddWithValue("@MaLoai", tbMaLoai.Text);
                    cmd.Parameters.AddWithValue("@NhapKhau", tbNhapKhau.Text);
                    cmd.Parameters.AddWithValue("@MaDonVi", tbMaDonVi.Text);
                    cmd.Parameters.AddWithValue("@MaChatLieu", tbMaChatLieu.Text);
                    cmd.Parameters.AddWithValue("@MaCongDung", tbMaCongDung.Text);
                    cmd.Parameters.AddWithValue("@MaNoiSX", tbMaNoiSX.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
                    cmd.Parameters.AddWithValue("@DonGiaNhap", tbDonGiaNhap.Text);
                    cmd.Parameters.AddWithValue("@DonGiaBan", tbDonGiaBan.Text);
                    //cmd.Parameters.AddWithValue("@Anh", b);
                    cmd.Parameters.AddWithValue("@GhiChu", tbGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập lại !!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Nhóm")
            {
                string sqlSELECT = "select * from NhomHang";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.SelectedItem.ToString() == "Chất Liệu")
            {
                string sqlSELECT = "select * from ChatLieu";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.SelectedItem.ToString() == "Công Dụng")
            {
                string sqlSELECT = "select * from CongDung";
                SqlCommand cmd = new SqlCommand(sqlSELECT, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReportHangHoa report = new FormReportHangHoa();
            report.ShowDialog();
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
                tbMaVach.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                tbTenHangHoa.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                tbMaNhom.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                tbMaLoai.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                tbNhapKhau.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                tbMaDonVi.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                tbMaChatLieu.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                tbMaCongDung.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                tbMaNoiSX.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                tbSoLuong.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                tbDonGiaNhap.Text = dataGridView1[10, e.RowIndex].Value.ToString();
                tbDonGiaBan.Text = dataGridView1[11, e.RowIndex].Value.ToString();
                tbGhiChu.Text = dataGridView1[12, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
            }
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

        private void tbDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
