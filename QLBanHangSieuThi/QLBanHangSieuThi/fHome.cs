using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
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
            fNhanVien nhanvien = new fNhanVien();
            nhanvien.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            fHoaDonNhap hoadon = new fHoaDonNhap();
            hoadon.ShowDialog();
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

        private void fHome_Load(object sender, EventArgs e)
        {

        }
    }
}
