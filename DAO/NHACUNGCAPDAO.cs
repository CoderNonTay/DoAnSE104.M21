using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DAO
{
    public class NHACUNGCAPDAO
    {
        private static NHACUNGCAPDAO instance;

        public static NHACUNGCAPDAO Instance
        {
            get { if (instance == null) instance = new NHACUNGCAPDAO(); return NHACUNGCAPDAO.instance; }
            private set { NHACUNGCAPDAO.instance = value; }
        }

        public NHACUNGCAPDAO()
        {

        }

        public List<NHACUNGCAP> GetListNCC()
        {
            List<NHACUNGCAP> list = new List<NHACUNGCAP>();

            string query = "select * from NHACUNGCAP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NHACUNGCAP LoaiSP = new NHACUNGCAP(item);
                list.Add(LoaiSP);
            }

            return list;
        }
    }
}
