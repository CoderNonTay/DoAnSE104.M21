using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class CT_PMHDAO
    {
        private static CT_PMHDAO instance;

        public static CT_PMHDAO Instance
        {
            get { if (instance == null) instance = new CT_PMHDAO(); return CT_PMHDAO.instance; }
            private set { CT_PMHDAO.instance = value; }
        }

        public CT_PMHDAO()
        {

        }

        public void InsertCTPMHToDataBase(int SoPMH, int MaSP, int SoLuongSP, float ThanhTien)
        {
            string query = "insert into CT_PMH VALUES (" + SoPMH + ", " + MaSP +  ", " + SoLuongSP + ", " + ThanhTien + ")";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
