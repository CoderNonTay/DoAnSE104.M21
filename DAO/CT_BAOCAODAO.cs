using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.DAO
{
    public class CT_BAOCAODAO
    {
        private static CT_BAOCAODAO instance;

        public static CT_BAOCAODAO Instance
        {
            get { if (instance == null) instance = new CT_BAOCAODAO(); return CT_BAOCAODAO.instance; }
            private set { CT_BAOCAODAO.instance = value; }
        }

        public CT_BAOCAODAO()
        {

        }

        public void ThemSoLuongSanPhamVaoKho(string TenSP, int SoLuong)
        {
            string query = "Update_CTBCforNhap N'" + TenSP + "', " + SoLuong.ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public void NhapCTBC(int MaSP)//Khi ta them 1 san pham moi vo thi co them 1 CTBC tuong ung
        {
            string query = "Nhap_CTBC " + MaSP.ToString();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
