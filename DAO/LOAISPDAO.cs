using WindowsFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class LOAISPDAO
    {
        private static LOAISPDAO instance;

        public static LOAISPDAO Instance
        {
            get { if (instance == null) instance = new LOAISPDAO(); return LOAISPDAO.instance; }
            private set { LOAISPDAO.instance = value; }
        }

        public LOAISPDAO()
        {

        }


        public List<LOAISP> GetListLoaiSanPham()
        {
            List<LOAISP> list = new List<LOAISP>();

            string query = "select * from LOAISP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LOAISP LoaiSP = new LOAISP(item);
                list.Add(LoaiSP);
            }

            return list;
        }

    

  
        public List<LOAISP> SearchLoaiSPByName(string name)
        {
            List<LOAISP> list = new List<LOAISP>();

            string query = string.Format("SELECT * FROM LOAISP WHERE dbo.fuConvertToUnsign1(TenLoaiSP) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LOAISP LoaiSP = new LOAISP(item);
                list.Add(LoaiSP);
            }

            return list;
        }

        public void insertloaisp(string name, string dvt, float loiNhuan)
        {
            string query = string.Format("NhapLoaiSP N'{0}', {1}, {2}", name, DVTDAO.Instance.GetDVTByName(dvt).MaDVT, loiNhuan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }


        public LOAISP GetLoaiSPByID(int id)
        {
            LOAISP LoaiSP = null;

            string query = "select * from LoaiSP where MaLoaiSP = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSP = new LOAISP(item);
                return LoaiSP;
            }

            return LoaiSP;
        }


        public string GetTenLoaiSPByTenSanPham(string TenSanPham)
        {
            List<SANPHAM> temp = SANPHAMDAO.Instance.SearchSanPhamByName(TenSanPham);
            int Ma = 0;
            foreach (SANPHAM t in temp)
                Ma = t.MaLoaiSP;

            LOAISP loaisp = LOAISPDAO.Instance.GetLoaiSPByID(Ma);
            return loaisp.TenLoaiSP;
        }

        public int GetIdLoaiSPByTen(string TenLoaiSP)
        {
            int id = 0;
            List<LOAISP> tmp = SearchLoaiSPByName(TenLoaiSP);
            foreach (LOAISP loaisp in tmp)
                id = loaisp.MaLoaiSP;
            return id;
        }

    }
}
