using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class ThongTinDonVi
    {
        private int maDonVi;
        private string tenDonVi;
        private string maSoThue;
        private string diaChi;
        private string sDT;
        private string email;
        private string nguoiLienHe;
        private string nguoiDaiDien;
        private string soTaiKhoan;
        private string chuTaiKhoan;
        private string tenNganHang;
        private string moTa;

        public int MaDonVi { get => maDonVi; set => maDonVi = value; }
        public string TenDonVi { get => tenDonVi; set => tenDonVi = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string NguoiLienHe { get => nguoiLienHe; set => nguoiLienHe = value; }
        public string NguoiDaiDien { get => nguoiDaiDien; set => nguoiDaiDien = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public string ChuTaiKhoan { get => chuTaiKhoan; set => chuTaiKhoan = value; }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
