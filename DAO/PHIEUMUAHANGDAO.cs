using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class PHIEUMUAHANGDAO
    {
        private static PHIEUMUAHANGDAO instance;

        public static PHIEUMUAHANGDAO Instance
        {
            get { if (instance == null) instance = new PHIEUMUAHANGDAO(); return PHIEUMUAHANGDAO.instance; }
            private set { PHIEUMUAHANGDAO.instance = value; }
        }

        public PHIEUMUAHANGDAO()
        {

        }

        public void InsertPMHToDataBase(int MaNCC)
        {
            string query = "NhapPMH " + MaNCC;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetCurrentSoPMH()
        {
            string query = "select SoPMH from PHIEUMUAHANG where PHIEUMUAHANG.SoPMH = (Select Max(SoPMH) From PHIEUMUAHANG)";
            int temp;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            temp = (int)data.Rows[0][0];

            return temp;
        }
    }

}
