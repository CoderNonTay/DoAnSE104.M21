using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class CT_PDVDAO
    {
        private static CT_PDVDAO instance;

        public static CT_PDVDAO Instance
        {
            get { if (instance == null) instance = new CT_PDVDAO(); return CT_PDVDAO.instance; }
            private set { CT_PDVDAO.instance = value; }
        }

        private CT_PDVDAO() { }

        public void InsertCT_PDVToDataBase(int SoPDV, int MaLoaiDV, float ChiPhiRieng, float DonGiaDuocTinh, int SL, float ThanhTien, float Truoc, float Sau, string NgayGiao, string TinhTrang)
        {
            string query1 = "SET DATEFORMAT DMY";
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            string query = "Nhap_CTPDV " + SoPDV + "," + MaLoaiDV + "," + ChiPhiRieng + "," + DonGiaDuocTinh + "," + SL + "," + ThanhTien + "," + Truoc + "," + Sau + ",'" + NgayGiao + "', N'" + TinhTrang + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCT_PDVFromPDV(int SoPDV)
        {
            string query = "GetCTPDVFromPDV " + SoPDV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetMaCT_PDV(int SoPDV)
        {
            string query = "Select MaCT_PDV From CT_PDV, PHIEUDICHVU Where CT_PDV.SoPDV = PHIEUDICHVU.SoPDV and CT_PDV.SoPDV = " + SoPDV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetTinhTrangDV(int MaCT_PDV)
        {
            string query = "Select TinhTrang From CT_PDV Where MaCT_PDV = " + MaCT_PDV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public void UpdateTinhTrangDV(int MaCT_PDV, string TinhTrang)
        {
            string query = "UpdateTinhTrangDV " + MaCT_PDV + ", N'" + TinhTrang + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateNgayGiao(int MaCT, string NgayGiao)
        {
            string query = "UpdateNgayGiao '" + NgayGiao + "', " + MaCT;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public string GetNgayGiao(int MaCT)
        {
            string query = "SELECT NgayGiao FROM dbo.CT_PDV WHERE MaCT_PDV = " + MaCT;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            DataRow item = data.Rows[0];
            return item[0].ToString();
        }
    }
}
