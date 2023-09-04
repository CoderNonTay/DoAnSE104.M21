using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class KHACHHANGDAO
    {
        private static KHACHHANGDAO instance;

        public static KHACHHANGDAO Instance
        {
            get { if (instance == null) instance = new KHACHHANGDAO(); return KHACHHANGDAO.instance; }
            private set { KHACHHANGDAO.instance = value; }
        }

        private KHACHHANGDAO() { }

        public int GetMaKHByTenKH(string KhachHang)
        {
            string query = "GetMaKHByTenKH '" + KhachHang + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KHACHHANG KH = new KHACHHANG(item);
                int MaKH = KH.MaKH;
                return MaKH;
            }
            return 0;
        }

        public string GetSDT_KHByTenKH(string name)
        {
            string query = "GetMaKHByTenKH '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                KHACHHANG KH = new KHACHHANG(item);
                string SDT = KH.SDT_KhachHang;
                return SDT;
            }
            return "";
        }
    }
}
