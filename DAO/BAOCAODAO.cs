using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class BAOCAODAO
    {
        private static BAOCAODAO instance;

        public static BAOCAODAO Instance
        {
            get { if (instance == null) instance = new BAOCAODAO(); return BAOCAODAO.instance; }
            private set { BAOCAODAO.instance = value; }
        }

        public BAOCAODAO()
        {

        }

        public void KiemTra_BC()
        {
            string query = "KT_BC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable Display(string Thang, string Nam)
        {
            string query = "HienThiBaoCaoTonKho " + Thang.ToString() + ", "  + Nam.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
