using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class THAMSODAO
    {
        private static THAMSODAO instance;

        public static THAMSODAO Instance
        {
            get { if (instance == null) instance = new THAMSODAO(); return THAMSODAO.instance; }
            private set { THAMSODAO.instance = value; }
        }

        private THAMSODAO() { }

        public float GetPhanTramTraTruoc()
        {
            string query = "select PhanTramTraTruoc from THAMSO";
            float temp;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                THAMSO TS = new THAMSO(item);
                temp = TS.PhanTramTraTruoc;
                return temp;
            }
            return 0;
        }
    }
}
