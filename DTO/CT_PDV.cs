using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class CT_PDV
    {
        private int maCT_PDV;
        private int soPDV;
        private int maLoaiDV;
        private float chiPhiRieng;
        private float donGiaDuocTinh;
        private int soLuong;
        private float thanhTien;
        private float thanhToanTruoc;
        private float thanhToanSau;
        private string ngayGiao;
        private string tinhTrang;

        public int MaCT_PDV { get => maCT_PDV; set => maCT_PDV = value; }
        public int SoPDV { get => soPDV; set => soPDV = value; }
        public int MaLoaiDV { get => maLoaiDV; set => maLoaiDV = value; }
        public float ChiPhiRieng { get => chiPhiRieng; set => chiPhiRieng = value; }
        public float DonGiaDuocTinh { get => donGiaDuocTinh; set => donGiaDuocTinh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public float ThanhToanTruoc { get => thanhToanTruoc; set => thanhToanTruoc = value; }
        public float ThanhToanSau { get => thanhToanSau; set => thanhToanSau = value; }
        public string NgayGiao { get => ngayGiao; set => ngayGiao = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public CT_PDV(int MaCT_PDV, int SoPDV, int MaLoaiDV, float ChiPhiRieng, float DonGiaDuocTinh, int SoLuong, float ThanhTien, float ThanhToanTruoc, float ThanhToanSau, string NgayGiao, string TinhTrang)
        {
            this.MaCT_PDV = MaCT_PDV;
            this.SoPDV = SoPDV;
            this.MaLoaiDV = MaLoaiDV;
            this.ChiPhiRieng = ChiPhiRieng;
            this.DonGiaDuocTinh = DonGiaDuocTinh;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
            this.ThanhToanTruoc = ThanhToanTruoc;
            this.ThanhToanSau = ThanhToanSau;
            this.NgayGiao = NgayGiao;
            this.TinhTrang = TinhTrang;
        }

        public CT_PDV(DataRow row)
        {
            this.MaCT_PDV = (int)row["MaCT_PDV"];
            this.SoPDV = (int)row["SoPDV"];
            this.MaLoaiDV = (int)row["MaLoaiDV"];
            this.ChiPhiRieng = (float)Convert.ToDouble(row["ChiPhiRieng".ToString()]);
            this.DonGiaDuocTinh = (float)Convert.ToDouble(row["DonGiaDuocTinh".ToString()]);
            this.SoLuong = (int)row["SoLuong"];
            this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien".ToString()]);
            this.ThanhToanTruoc = (float)Convert.ToDouble(row["ThanhToanTruoc".ToString()]);
            this.ThanhToanSau = (float)Convert.ToDouble(row["ThanhToanSau".ToString()]);
            this.NgayGiao = row["NgayGiao"].ToString();
            this.TinhTrang = row["TinhTrang"].ToString();
        }
    }
}
