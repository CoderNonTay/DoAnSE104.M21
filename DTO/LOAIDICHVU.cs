using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class LOAIDICHVU
    {
        private int maLoaiDV;
        private string tenLoaiDV;
        private float donGiaDV;

        public int MaLoaiDV { get => maLoaiDV; set => maLoaiDV = value; }
        public string TenLoaiDV { get => tenLoaiDV; set => tenLoaiDV = value; }
        public float DonGiaDV { get => donGiaDV; set => donGiaDV = value; }

        public LOAIDICHVU(int MaLoaiDV, string TenLoaiDV, float DonGiaDV)
        {
            this.MaLoaiDV = MaLoaiDV;
            this.TenLoaiDV = TenLoaiDV;
            this.DonGiaDV = DonGiaDV;
        }

        public LOAIDICHVU(DataRow row)
        {
            this.MaLoaiDV = (int)row["MaLoaiDV"];
            this.TenLoaiDV = row["TenLoaiDV"].ToString();
            this.DonGiaDV = (float)Convert.ToDouble(row["DonGiaDV".ToString()]);
        }
    }
}
