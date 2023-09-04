using WindowsFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class SANPHAMDAO
    {
        private static SANPHAMDAO instance;

        public static SANPHAMDAO Instance
        {
            get { if (instance == null) instance = new SANPHAMDAO(); return SANPHAMDAO.instance; }
            private set { SANPHAMDAO.instance = value; }
        }

        private SANPHAMDAO()
        {

        }
        public List<SANPHAM> GetSanPhamByLoaiSanPham(int MaLoaiSanPham)
        {
            List<SANPHAM> list = new List<SANPHAM>();

            string query = "select * from SANPHAM where MaLoaiSP = " + MaLoaiSanPham;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SANPHAM SanPham = new SANPHAM(item);
                list.Add(SanPham);
            }

            return list;
        }

        public void ThayDoiDonGiaMua(string DonGiaMuaVao, int MaSP)
        {
            string query = "DonGiaMua " + MaSP + ", " + DonGiaMuaVao;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetMaSanPhamByTenSP(string TenSP)
        {
            string query = "select * from SANPHAM where TenSP = N'" + TenSP + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                SANPHAM SP = new SANPHAM(item);
                int MaSP = SP.MaSP;
                return MaSP;
            }
            return 0;
        }

        public List<SANPHAM> GetListSanPham()
        {
            List<SANPHAM> list = new List<SANPHAM>();

            string query = "select * from SANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SANPHAM SanPham = new SANPHAM(item);
                list.Add(SanPham);
            }

            return list;
        }

        public SANPHAM GetSanPhamByID(int id)
        {
            SANPHAM SanPham = null;

            string query = "select * from SANPHAM where MaSP = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham = new SANPHAM(item);
                return SanPham;
            }

            return SanPham;
        }

    
        public List<SANPHAM> SearchSanPhamByName(string name)
        {
            List<SANPHAM> list = new List<SANPHAM>();

            string query = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TenSP) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SANPHAM SanPham = new SANPHAM(item);
                list.Add(SanPham);
            }

            return list;
        }

        public void UpdateSanPham(int MaSP, string TenSP, int MaLoaiSP)
        {
            string query = "UpdateSanPham " + MaSP.ToString() + ", N'" + TenSP.ToString() + "', " + MaLoaiSP.ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public void ThemSP(int MaLoaiSP, string TenSanPham)
        {
            string query = "NhapSP " + MaLoaiSP.ToString() + ", N'" + TenSanPham.ToString() + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
