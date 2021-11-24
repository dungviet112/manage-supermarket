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
    public partial class fThongKe : Form
    {
        SqlConnection con;
        public fThongKe()
        {
            InitializeComponent();
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
        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            fQLNguoiDung quanly = new fQLNguoiDung();
            quanly.ShowDialog();
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (rdo1.Checked == true)
            {
                var table = tbTimKiem.Text;
                string sqlFIND = $"exec SPBanChay '{table}'";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);          
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                
            }
            if (rdo2.Checked == true)
            {
                var table = tbTimKiem.Text;
                string sqlFIND = $"exec HDNhieuNhatNam '{table}'";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                
            }
            if (rdo3.Checked == true)
            {
                var table = tbTimKiem.Text;
                string sqlFIND = $"exec HD_NV '{table}'";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            
        }
        

        private void fThongKe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConnectionString.conString);
            con.Open();
            cbbQuy.Visible = false;
            
        }
        
        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            dataGridView1.DataSource = null;
            cbbQuy.Visible = false;
            tbTimKiem.Visible = true;
            btTimKiem.Visible = true;
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            dataGridView1.DataSource = null;
            cbbQuy.Visible = false;
            tbTimKiem.Visible = true;
            btTimKiem.Visible = true;
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            dataGridView1.DataSource = null;
            cbbQuy.Visible = false;
            tbTimKiem.Visible = true;
            btTimKiem.Visible = true;
        }

        private void rdo4_CheckedChanged(object sender, EventArgs e)
        {
            tbTimKiem.Text = "";
            dataGridView1.DataSource = null;
            cbbQuy.Visible = true;
            tbTimKiem.Visible = false;
            btTimKiem.Visible = false;
        }

        private void cbbQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbQuy.SelectedItem == "Quý 1")
            {
                string sqlFIND = "select top 3 KhachHang.MaKhach, TenKhach,DiaChi,DienThoai,count(SoHDB) as SoLuongMua from KhachHang join HoaDonBan on KhachHang.MaKhach = HoaDonBan.MaKhach where MONTH(NgayBan) = '1' or MONTH(NgayBan) = '2' or MONTH(NgayBan) = '3' group by KhachHang.MaKhach, TenKhach,DiaChi,DienThoai order by SoLuongMua asc";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (cbbQuy.SelectedItem == "Quý 2")
            {
                string sqlFIND = "select top 3 KhachHang.MaKhach, TenKhach,DiaChi,DienThoai,count(SoHDB) as SoLuongMua from KhachHang join HoaDonBan on KhachHang.MaKhach = HoaDonBan.MaKhach where MONTH(NgayBan) = '4' or MONTH(NgayBan) = '5' or MONTH(NgayBan) = '6' group by KhachHang.MaKhach, TenKhach,DiaChi,DienThoai order by SoLuongMua asc";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (cbbQuy.SelectedItem == "Quý 3")
            {
                string sqlFIND = "select top 3 KhachHang.MaKhach, TenKhach,DiaChi,DienThoai,count(SoHDB) as SoLuongMua from KhachHang join HoaDonBan on KhachHang.MaKhach = HoaDonBan.MaKhach where MONTH(NgayBan) = '7' or MONTH(NgayBan) = '8' or MONTH(NgayBan) = '9' group by KhachHang.MaKhach, TenKhach,DiaChi,DienThoai order by SoLuongMua asc";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            if (cbbQuy.SelectedItem == "Quý 4")
            {
                string sqlFIND = "select top 3 KhachHang.MaKhach, TenKhach,DiaChi,DienThoai,count(SoHDB) as SoLuongMua from KhachHang join HoaDonBan on KhachHang.MaKhach = HoaDonBan.MaKhach where MONTH(NgayBan) = '10' or MONTH(NgayBan) = '11' or MONTH(NgayBan) = '12' group by KhachHang.MaKhach, TenKhach,DiaChi,DienThoai order by SoLuongMua asc";
                SqlCommand cmd = new SqlCommand(sqlFIND, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (rdo1.Checked == true)
            {
                SPBanChay formReport = new SPBanChay();
                formReport.ShowDialog();
            }

            if (rdo2.Checked == true)
            {
                HDNhieuNhatNam formReport = new HDNhieuNhatNam();
                formReport.ShowDialog();
            }

            if (rdo3.Checked == true)
            {
                HDBoiNV formReport = new HDBoiNV();
                formReport.ShowDialog();
            }

            if (rdo4.Checked == true)
            {
                Top3KhachTheoQuy formReport = new Top3KhachTheoQuy();
                formReport.ShowDialog();
            }
        }

        public string TimKiem
        {
             get { return tbTimKiem.SelectedText; } 
        }

    }
}
