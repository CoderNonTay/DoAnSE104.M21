using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class KHACHHANG
    {
        private int maKH;
        private string khachHang;
        private string sDT_KhachHang;

        public int MaKH { get => maKH; set => maKH = value; }
        public string KhachHang { get => khachHang; set => khachHang = value; }
        public string SDT_KhachHang { get => sDT_KhachHang; set => sDT_KhachHang = value; }

        public KHACHHANG(int MaKH, string KhachHang, string SDT_KhachHang)
        {
            this.MaKH = MaKH;
            this.KhachHang = KhachHang;
            this.SDT_KhachHang = SDT_KhachHang;
        }

        public KHACHHANG(DataRow rows)
        {
            this.MaKH = (int)rows["MaKH"];
            this.KhachHang = rows["KhachHang"].ToString();
            this.SDT_KhachHang = rows["SDT_KhachHang"].ToString();
        }
    }
}
