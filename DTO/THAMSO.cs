using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class THAMSO
    {
        private float phanTramTraTruoc;

        public float PhanTramTraTruoc { get => phanTramTraTruoc; set => phanTramTraTruoc = value; }

        public THAMSO(float PhanTramTraTruoc)
        {
            this.PhanTramTraTruoc = PhanTramTraTruoc;
        }

        public THAMSO(DataRow row)
        {
            this.PhanTramTraTruoc = (float)Convert.ToDouble(row["PhanTramTraTruoc"].ToString());
        }
    }
}
