using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class CT_BAOCAO
    {
        int maCT_BaoCao;
        int maBC;
        int maSP;
        int tonDau;
        int tonCuoi;
        int soLuongMuaVao;
        int soLuongBanRa;

        public int MaCT_BaoCao { get => maCT_BaoCao; set => maCT_BaoCao=value; }
        public int MaBC { get => maBC; set => maBC=value; }
        public int MaSP { get => maSP; set => maSP=value; }
        public int TonDau { get => tonDau; set => tonDau=value; }
        public int TonCuoi { get => tonCuoi; set => tonCuoi=value; }
        public int SoLuongMuaVao { get => soLuongMuaVao; set => soLuongMuaVao=value; }
        public int SoLuongBanRa { get => soLuongBanRa; set => soLuongBanRa=value; }

        public CT_BAOCAO(int mactbc, int mabc, int masp, int tondau, int toncuoi, int slmv, int slbr)
        {
            this.MaCT_BaoCao = mactbc;
            this.MaBC = mabc;
            this.MaSP = masp;
            this.TonDau = tondau;
            this.TonCuoi = toncuoi;
            this.SoLuongMuaVao = slmv;
            this.SoLuongBanRa = slbr;
        }

        public CT_BAOCAO(DataRow rows)
        {
            this.MaCT_BaoCao = (int)rows["MaCT_BaoCao"];
            this.MaBC = (int)rows["MaBC"];
            this.MaSP = (int)rows["MaSP"];
            this.TonDau = (int)rows["TonDau"];
            this.TonCuoi = (int)rows["TonCuoi"];
            this.SoLuongMuaVao = (int)rows["SoLuongMuaVao"];
            this.SoLuongBanRa = (int)rows["SoLuongBanRa"];
        }
    }
    
}
