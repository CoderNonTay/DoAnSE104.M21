using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp1.DTO
{
    public class BAOCAO
    {
        private int maBC;
        private int thang;
        private int nam;

        public int MaBC { get => maBC; set => maBC=value; }
        public int Thang { get => thang; set => thang=value; }
        public int Nam { get => nam; set => nam=value; }

        public BAOCAO(int mabc, int thang, int nam)
        {
            this.MaBC = mabc;
            this.Thang = thang;
            this.Nam = nam;
        }

        public BAOCAO(DataRow rows)
        {
            this.MaBC = (int)rows["MaBC"];
            this.Thang = (int)rows["Thang"];
            this.Nam = (int)rows["Nam"];
        }
    }
}
