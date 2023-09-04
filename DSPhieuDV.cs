using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class DSPhieuDV : Form
    {
        public DSPhieuDV()
        {
            InitializeComponent();
        }

        int clicked_row_DS = -1;
        int clicked_row_CT = -1;
        private void btnIN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang bảo trì.", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            dgvDanhSach.Rows.Clear();
            //int current_MaKH = KHACHHANGDAO.Instance.GetMaKHByTenKH(txtKhachHang.Text);
            //string MaKH = current_MaKH.ToString();
            DataTable data = PHIEUDICHVUDAO.Instance.GetListPhieuDV(txtSoPhieu.Text.ToString(), txtKhachHang.Text.ToString(), txtSDT.Text.ToString(), txtNgayLap.Text.ToString(), txtTinhTrang.Text.ToString());
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu dịch vụ!", "Cảnh báo!");
                return;
            }

            foreach (DataRow item in data.Rows)
            {
                string a = item[0].ToString();
                string b = item[1].ToString();
                DateTime Ngay = Convert.ToDateTime(b);
                string b1 = Ngay.ToString("dd/MM/yyyy");
                string c = item[2].ToString();
                string d = item[3].ToString();
                string f = item[4].ToString();
                string g = item[5].ToString();
                string h = item[6].ToString();
                dgvDanhSach.Rows.Add(a, b1, c, d, f, g, h);
            }
        }

        private void dgvDanhSach_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvChiTiet.Rows.Clear();
            clicked_row_DS = e.RowIndex;
            DataTable data = CT_PDVDAO.Instance.GetCT_PDVFromPDV(Convert.ToInt32(dgvDanhSach[0, clicked_row_DS].Value));
            foreach (DataRow item in data.Rows)
            {
                string a = item[0].ToString();
                string b = item[1].ToString();
                string c = item[2].ToString();
                string d = item[3].ToString();
                string f = item[4].ToString();
                string g = item[5].ToString();
                string h = item[6].ToString();
                string i = item[7].ToString();
                string j = item[8].ToString();
                DateTime Ngay = Convert.ToDateTime(j);
                string j1 = Ngay.ToString("dd/MM/yyyy");
                string k = item[9].ToString();
                dgvChiTiet.Rows.Add(a, b, c, d, f, g, h, i, j1, k);
            }
        }

        private void dgvChiTiet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //cbTinhTrangDV.Text = "";
            clicked_row_CT = e.RowIndex;
            DataTable data = CT_PDVDAO.Instance.GetMaCT_PDV(Convert.ToInt32(dgvDanhSach[0, clicked_row_DS].Value));
            DataRow item = data.Rows[clicked_row_CT];
            int MaCT = Convert.ToInt32(item[0]);

            DataTable data1 = CT_PDVDAO.Instance.GetTinhTrangDV(MaCT);
            DataRow item1 = data1.Rows[0];
            cbTinhTrangDV.Text = item1[0].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable data = CT_PDVDAO.Instance.GetMaCT_PDV(Convert.ToInt32(dgvDanhSach[0, clicked_row_DS].Value));
            DataRow item = data.Rows[clicked_row_CT];
            int MaCT = Convert.ToInt32(item[0]);
            CT_PDVDAO.Instance.UpdateTinhTrangDV(MaCT, cbTinhTrangDV.Text);
            PHIEUDICHVUDAO.Instance.Update_TinhTrangPDV(Convert.ToInt32(dgvDanhSach[0, clicked_row_DS].Value));

            //Hiển thị tình trạng dịch vụ sau cập nhật
            dgvChiTiet[9, clicked_row_CT].Value = cbTinhTrangDV.Text;

            //Hiển thị tình trạng phiếu sau cập nhật
            DataTable data1 = PHIEUDICHVUDAO.Instance.GetTinhTrangPhieuDV(Convert.ToInt32(dgvDanhSach[0, clicked_row_DS].Value));
            DataRow item1 = data1.Rows[0];
            dgvDanhSach[6, clicked_row_DS].Value = item1[0].ToString();

            if (txtNgayGiao.Text != "")
            {
                DateTime ngaySua = Convert.ToDateTime(txtNgayGiao.Text);
                DateTime ngayDaCo = Convert.ToDateTime(CT_PDVDAO.Instance.GetNgayGiao(MaCT));
                if (ngaySua < ngayDaCo)
                {
                    MessageBox.Show("Ngày giao không hợp lệ !", "Cảnh báo !");
                    return;
                }
                CT_PDVDAO.Instance.UpdateNgayGiao(MaCT, txtNgayGiao.Text);
                string Ngay = CT_PDVDAO.Instance.GetNgayGiao(MaCT);
                DateTime Ngay1 = Convert.ToDateTime(Ngay);
                dgvChiTiet[8, clicked_row_CT].Value = Ngay1.ToString("dd/MM/yyyy");

                txtNgayGiao.Clear();
            }
        }
    }
}
