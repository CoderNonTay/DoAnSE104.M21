using WindowsFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DVTDAO
    {
        private static DVTDAO instance;

        public static DVTDAO Instance
        {
            get { if (instance == null) instance = new DVTDAO(); return DVTDAO.instance; }
            private set { DVTDAO.instance = value; }
        }

        public DVTDAO()
        {

        }
        public DVT GetDVTByLoaiSP(LOAISP tmp)
        {
            string query = "SELECT * FROM DVT WHERE MaDVT = " + tmp.MaDVT;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            DVT dvt = new DVT(data.Rows[0]);

            return dvt;
        }

        public List<DVT> GetListDVT()
        {
            List<DVT> list = new List<DVT>();

            string query = "select * from DVT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DVT DVT = new DVT(item);
                list.Add(DVT);
            }

            return list;
        }

        public DVT GetDVTByID(int id)
        {
            DVT DVT = null;

            string query = "select * from DVT where MaDVT = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DVT = new DVT(item);
                return DVT;
            }

            return DVT;
        }
        public DVT GetDVTByName(string name)
        {
            DVT DVT = null;

            string query = string.Format("select * from DVT where TenDVT = '{0}'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DVT = new DVT(item);
                return DVT;
            }

            return DVT;
        }
    }
}
