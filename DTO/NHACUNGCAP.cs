using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{

    public class NHACUNGCAP
    {
        private int maNCC;
        private string nhaCungCap;
        private string diaChiNCC;
        private string sdt_NCC;

        public int MaNCC { get => maNCC; set => maNCC=value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap=value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC=value; }
        public string Sdt_NCC { get => sdt_NCC; set => sdt_NCC=value; }

        public NHACUNGCAP(int mancc, string ncc, string dcncc, string sdtncc)
        {
            this.MaNCC = mancc;
            this.NhaCungCap = ncc;
            this.DiaChiNCC = dcncc;
            this.Sdt_NCC = sdtncc;
        }

        public NHACUNGCAP(DataRow row)
        {
            this.MaNCC = (int)row["MaNCC"];
            this.NhaCungCap = row["NhaCungCap"].ToString();
            this.DiaChiNCC = row["DiaChiNCC"].ToString();
            this.Sdt_NCC = row["SDT_NCC"].ToString();
        }

    }

}
