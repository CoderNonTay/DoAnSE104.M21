using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1.DTO
{
    public class LOAISP
    {
        private int maLoaiSP;

        private string tenLoaiSP;

        private int maDVT;

        private float loiNhuan;

        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP=value; }
        public string TenLoaiSP { get => tenLoaiSP; set => tenLoaiSP=value; }
        public int MaDVT { get => maDVT; set => maDVT=value; }
        public float LoiNhuan { get => loiNhuan; set => loiNhuan=value; }

        public LOAISP(int MaLoaiSP, string TenLoaiSP, int MaDVT, float LoiNhuan)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
            this.MaDVT = MaDVT;
            this.LoiNhuan = LoiNhuan;
        }

        public LOAISP(DataRow row)
        {
            this.MaLoaiSP = (int)row["MaLoaiSP"];
            this.TenLoaiSP = row["TenLoaiSP"].ToString();
            this.MaDVT = (int)row["MaDVT"];
            this.LoiNhuan = (float)Convert.ToDouble(row["LoiNhuan"].ToString());
        }
    }
}
