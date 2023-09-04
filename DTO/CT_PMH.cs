using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class CT_PMH
    {
        private int maCT_PMH;
        private int soPMH;
        private int maSP;
        private int soLuongSP;
        private float thanhTien;

        public int MaCT_PMH { get => maCT_PMH; set => maCT_PMH=value; }
        public int SoPMH { get => soPMH; set => soPMH=value; }
        public int MaSP { get => maSP; set => maSP=value; }
        public int SoLuongSP { get => soLuongSP; set => soLuongSP=value; }
        public float ThanhTien { get => thanhTien; set => thanhTien=value; }

        public CT_PMH(int mact_pmh, int sopmh, int masp, int soluongsp, float thanhtien)
        {
            this.MaCT_PMH = mact_pmh;
            this.SoPMH = sopmh;
            this.MaSP = masp;
            this.SoLuongSP = soluongsp;
            this.ThanhTien = thanhtien;
        }

        public CT_PMH(DataRow rows)
        {
            this.MaCT_PMH = (int)rows["MaCT_PMH"];
            this.SoPMH = (int)rows["SoPMH"];
            this.MaSP = (int)rows["MaSP"];
            this.SoLuongSP = (int)rows["SoLuongSP"];
            this.ThanhTien = (float)Convert.ToDouble(rows["ThanhTien"].ToString());
        }
    }
}
