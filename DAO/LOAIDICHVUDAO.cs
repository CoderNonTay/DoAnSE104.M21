using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class LOAIDICHVUDAO
    {
        private static LOAIDICHVUDAO instance;

        public static LOAIDICHVUDAO Instance
        {
            get { if (instance == null) instance = new LOAIDICHVUDAO(); return LOAIDICHVUDAO.instance; }
            private set { LOAIDICHVUDAO.instance = value; }
        }

        private LOAIDICHVUDAO() { }

        public List<LOAIDICHVU> GetListLoaiDV()
        {
            List<LOAIDICHVU> list = new List<LOAIDICHVU>();

            string query = "select * from LOAIDICHVU";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LOAIDICHVU LoaiDV = new LOAIDICHVU(item);
                list.Add(LoaiDV);
            }

            return list;
        }

        public int GetMaLoaiDVByTenLoaiDV(string name)
        {
            string query = "GetMaLoaiDVByTenLoaiDV '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LOAIDICHVU LoaiDV = new LOAIDICHVU(item);
                int MaLoaiDV = LoaiDV.MaLoaiDV;
                return MaLoaiDV;
            }
            return 0;

        }
    }
}
