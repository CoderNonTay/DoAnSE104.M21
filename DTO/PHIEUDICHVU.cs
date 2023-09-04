using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class PHIEUDICHVU
    {
        private int soPDV;
        private DateTime ngayLapPDV;
        private int maKH;
        private float tongTien;
        private float traTruoc;
        private float traSau;
        private string tinhTrangPDV;

        public int SoPDV { get => soPDV; set => soPDV = value; }
        public DateTime NgayLapPDV { get => ngayLapPDV; set => ngayLapPDV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float TraTruoc { get => traTruoc; set => traTruoc = value; }
        public float TraSau { get => traSau; set => traSau = value; }
        public string TinhTrangPDV { get => tinhTrangPDV; set => tinhTrangPDV = value; }

        public PHIEUDICHVU(int SoPDV, DateTime NgayLapPDV, int MaKH, float TongTien, float TraTruoc, float TraSau, string TinhTrangPDV)
        {
            this.SoPDV = SoPDV;
            this.NgayLapPDV = NgayLapPDV;
            this.MaKH = MaKH;
            this.TongTien = TongTien;
            this.TraTruoc = TraTruoc;
            this.TraSau = TraSau;
            this.TinhTrangPDV = TinhTrangPDV;
        }

        public PHIEUDICHVU(DataRow row)
        {
            this.SoPDV = (int)row["SoPDV"];
            this.NgayLapPDV = Convert.ToDateTime(row["NgayLapPDV"]);
            this.MaKH = (int)row["MaKH"];
            this.TongTien = (float)Convert.ToDouble(row["TongTien"].ToString());
            this.TraTruoc = (float)Convert.ToDouble(row["TraTruoc"].ToString());
            this.TraSau = (float)Convert.ToDouble(row["TraSau"].ToString());
            this.TinhTrangPDV = row["TinhTrangPDV"].ToString();
        }
    }
}
