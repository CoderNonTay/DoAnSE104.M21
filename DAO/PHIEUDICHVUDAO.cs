using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class PHIEUDICHVUDAO
    {
        private static PHIEUDICHVUDAO instance;

        public static PHIEUDICHVUDAO Instance
        {
            get { if (instance == null) instance = new PHIEUDICHVUDAO(); return PHIEUDICHVUDAO.instance; }
            private set { PHIEUDICHVUDAO.instance = value; }
        }

        private PHIEUDICHVUDAO() { }

        public int GetCurrentSoPDV()
        {
            string query = "select SoPDV from PHIEUDICHVU where PHIEUDICHVU.SoPDV = (Select Max(SoPDV) From PHIEUDICHVU)";
            int temp;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            temp = (int)data.Rows[0][0];

            return temp;
        }

        public void InsertPhieuDVtoDatabase(int MaKH, float TongTien, float TraTruoc, float TraSau)
        {
            string query = "Nhap_PhieuDV " + MaKH + "," + TongTien + "," + TraTruoc + "," + TraSau;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetListPhieuDV(string SoPhieu, string name, string Sdt, string NgayLap, string TinhTrang)
        {
            if (SoPhieu == "")
                SoPhieu = "'' or 1 = 1";
            else
                SoPhieu = "'" + SoPhieu + "'";

            if (name == "")
                name = "'' or 1 = 1";
            else
                name = "N'" + name + "'";

            if (Sdt == "")
                Sdt = "'' or 1 = 1";
            else
                Sdt = "'" + Sdt + "'";

            if (NgayLap == "")
                NgayLap = "'' or 1 = 1";
            else
                NgayLap = "'" + NgayLap + "'";

            if (TinhTrang == "")
                TinhTrang = "'' or 1 = 1";
            else
                TinhTrang = "N'" + TinhTrang + "'";

            //string query = "HienThiDanhSachPhieuDichVu " + "'" + SoPhieu + "', '" + MaKH + "', '" + Sdt + "', '" + NgayLap + "', '" + TinhTrang + "'";

            string query = String.Format("SELECT SoPDV, NgayLapPDV, KHACHHANG, TongTien, TraTruoc, TraSau, TinhTrangPDV From PHIEUDICHVU, KHACHHANG WHERE "
               + "(SoPDV = {0}) and (KHACHHANG.KhachHang = {1}) and (SDT_KhachHang = {2}) and (NgayLapPDV = {3}) and (TinhTrangPDV = {4}) "
               + "and (PHIEUDICHVU.MaKH = KHACHHANG.MaKH)", SoPhieu, name, Sdt, NgayLap, TinhTrang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            return data;
        }

        public void Update_TinhTrangPDV(int SoPDV)
        {
            string query = "Update_TinhTrangPDV " + SoPDV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetTinhTrangPhieuDV(int SoPDV)
        {
            string query = "Select TinhTrangPDV From PHIEUDICHVU Where SoPDV = " + SoPDV;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
