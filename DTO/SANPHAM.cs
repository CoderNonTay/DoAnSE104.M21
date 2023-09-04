using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1.DTO
{
    public class SANPHAM
    {
        private int maSP;

        private string tenSP;

        private int maLoaiSP;

        private float donGiaMuaVao;

        private float donGiaBanRa;


        public SANPHAM(int masp, string tensp, int maloaisp, float dongiamua, float dongiabanra)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLoaiSP = maloaisp;
            this.DonGiaMuaVao = dongiamua;
            this.DonGiaBanRa = dongiabanra;
        }

        public SANPHAM(DataRow row)
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.MaLoaiSP = (int)row["MaLoaiSp"];
            this.DonGiaMuaVao = (float)Convert.ToDouble(row["DonGiaMuaVao"].ToString());
            this.DonGiaBanRa = (float)Convert.ToDouble(row["DonGiaBanRa"].ToString());
        }
        public int MaSP { get => maSP; set => maSP=value; }
        public string TenSP { get => tenSP; set => tenSP=value; }
        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP=value; }
        public float DonGiaMuaVao { get => donGiaMuaVao; set => donGiaMuaVao=value; }
        public float DonGiaBanRa { get => donGiaBanRa; set => donGiaBanRa=value; }
    }


}
