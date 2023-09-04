using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DTO
{
    public class DVT
    {
        private int maDVT;
        private string tenDVT;

        public int MaDVT { get => maDVT; set => maDVT=value; }
        public string TenDVT { get => tenDVT; set => tenDVT=value; }

        public DVT(int madvt, string tendvt)
        {
            this.MaDVT = madvt;
            this.TenDVT = tendvt;
        }

        public DVT(DataRow row)
        {
            this.MaDVT = (int)row["MaDVT"];
            this.TenDVT = row["TenDVT"].ToString();
        }
    }
}
