using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class PHIEUMUAHANG
    {
        private int soPMH;
        private DateTime ngayLapPMH;
        private int maNCC;

        public int SoPMH { get => soPMH; set => soPMH=value; }
        public DateTime NgayLapPMH { get => ngayLapPMH; set => ngayLapPMH=value; }
        public int MaNCC { get => maNCC; set => maNCC=value; }

        public PHIEUMUAHANG(int sopmh, DateTime ngaylappmh, int mancc)
        {
            this.SoPMH=sopmh;
            this.NgayLapPMH=ngaylappmh;
            this.MaNCC=mancc;
        }

        public PHIEUMUAHANG(DataRow rows)
        {
            this.SoPMH = (int)rows["SoPMH"];
            this.NgayLapPMH = (DateTime)rows["NgayLapPMH"];
            this.MaNCC = (int)rows["MaNCC"];
        }
    }
}
