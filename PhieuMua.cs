using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class PhieuMua : Form
    {
        int clicked_row = -1;
        private int current_MaSP;
        private int current_Rows_In_Table = -1;
        private int current_MaNCC = -1;

        public PhieuMua()
        {
            InitializeComponent();

            LoadLoaiSanPham();

            LoadNCC();
        }


        void LoadNCC()
        {
            List<NHACUNGCAP> listNCC = NHACUNGCAPDAO.Instance.GetListNCC();
            cbNhaCungCap.DataSource = listNCC;
            cbNhaCungCap.DisplayMember = "NhaCungCap";
        }
        void LoadLoaiSanPham()
        {
            List<LOAISP> listLoaiSP = LOAISPDAO.Instance.GetListLoaiSanPham();
            cbLoaiSP.DataSource = listLoaiSP;
            cbLoaiSP.DisplayMember = "TenLoaiSP";
        }

        void LoadDVTByLoaiSanPham(LOAISP loaisp)
        {
            DVT dvt = DVTDAO.Instance.GetDVTByLoaiSP(loaisp);
            txtDonViTinh.Text = dvt.TenDVT;
        }
        void LoadSanPhamByLoaiSP(int MaLoaiSP)
        {
            List<SANPHAM> listSanPham = SANPHAMDAO.Instance.GetSanPhamByLoaiSanPham(MaLoaiSP);
            if (listSanPham.Count == 0)
            {
                cbSP.Text = "";
                current_MaSP = 0;
                txtDonGiaMua.Text = "";
                return;
            }
            cbSP.DataSource = listSanPham;
            cbSP.DisplayMember = "TenSP";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận làm mới?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                dgvPhieuMua.Rows.Clear();
                txtTongTien.Text = "0";
                Console.WriteLine("Làm mới.");
            }
        }

        public int GetMaSP(string TenSP)
        {
            int i = SANPHAMDAO.Instance.GetMaSanPhamByTenSP(TenSP);
            return i;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (current_Rows_In_Table == -1)
            {
                MessageBox.Show("Không có sản phẩm để lưu!", "Cảnh báo!", MessageBoxButtons.OKCancel);
                return;
            }

            DialogResult dlr = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {

                PHIEUMUAHANGDAO.Instance.InsertPMHToDataBase(current_MaNCC);

                int currentSoPMH = PHIEUMUAHANGDAO.Instance.GetCurrentSoPMH();

                for (int i = 0; i < dgvPhieuMua.Rows.Count - 1; i++)
                {
                    string tmp = dgvPhieuMua[0, i].Value.ToString();
                    int MaSp = GetMaSP(tmp);
                    float ThanhTien = Convert.ToInt64(dgvPhieuMua[3, i].Value) * Convert.ToInt64(dgvPhieuMua[2, i].Value);
                    int SoLuong = Convert.ToInt32(dgvPhieuMua[3, i].Value);
                    CT_PMHDAO.Instance.InsertCTPMHToDataBase(currentSoPMH, MaSp, SoLuong, ThanhTien);
                    CT_BAOCAODAO.Instance.ThemSoLuongSanPhamVaoKho(tmp, SoLuong);
                }

                dgvPhieuMua.Rows.Clear();
                Console.WriteLine("Lưu.");
            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;


            LOAISP selected = cb.SelectedItem as LOAISP;
            id = selected.MaLoaiSP;
            LoadSanPhamByLoaiSP(id);
            LoadDVTByLoaiSanPham(selected);
        }

        private void cbNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            NHACUNGCAP selected = cb.SelectedItem as NHACUNGCAP;
            current_MaNCC = selected.MaNCC;
            txtDiaChi.Text = selected.DiaChiNCC;
            txtSDT.Text = selected.Sdt_NCC;
        }

        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            nmSL.Value = 1;
            SANPHAM selected = cb.SelectedItem as SANPHAM;
            txtDonGiaMua.Text = selected.DonGiaMuaVao.ToString();
            current_MaSP = selected.MaSP;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (current_MaSP == 0)
            { MessageBox.Show("Không có sản phẩm!", "Cảnh báo!", MessageBoxButtons.OKCancel); return; }

            Int64 TongTienTmp = Convert.ToInt64(txtTongTien.Text);

            for (int i = 0; i < dgvPhieuMua.Rows.Count - 1; i++)
            {
                if (dgvPhieuMua[0, i].Value.ToString() == cbSP.Text)
                {
                    int temp = Convert.ToInt32(dgvPhieuMua[3, i].Value) + Convert.ToInt32(nmSL.Value);
                    dgvPhieuMua[2, i].Value = txtDonGiaMua.Text;
                    dgvPhieuMua[3, i].Value = temp;
                    SANPHAMDAO.Instance.ThayDoiDonGiaMua(txtDonGiaMua.Text, current_MaSP);

                    TongTienTmp += Convert.ToInt64(nmSL.Value) * Convert.ToInt64(txtDonGiaMua.Text);
                    txtTongTien.Text = TongTienTmp.ToString();
                    nmSL.Value = 1;
                    return;
                }
            }

            SANPHAMDAO.Instance.ThayDoiDonGiaMua(txtDonGiaMua.Text, current_MaSP);
            dgvPhieuMua.Rows.Add(cbSP.Text, cbLoaiSP.Text, txtDonGiaMua.Text, nmSL.Value, txtDonViTinh.Text);
            current_Rows_In_Table++;


            TongTienTmp += Convert.ToInt64(nmSL.Value) * Convert.ToInt64(txtDonGiaMua.Text);
            txtTongTien.Text = TongTienTmp.ToString();
            nmSL.Value = 1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (current_Rows_In_Table == -1)
            { MessageBox.Show("Không có sản phẩm nào trong phiếu mua!", "Cảnh báo!", MessageBoxButtons.OKCancel); return; }

            if (clicked_row == -1)
            { MessageBox.Show("Bạn phải chọn dòng cần xóa!", "Cảnh báo!", MessageBoxButtons.OKCancel); return; }
            DialogResult dlr = MessageBox.Show("Xác nhận xóa sản phẩm được chọn?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Int64 TongTienTmp = Convert.ToInt64(txtTongTien.Text);
                TongTienTmp -= Convert.ToInt64(dgvPhieuMua[3, clicked_row].Value) * Convert.ToInt64(dgvPhieuMua[2, clicked_row].Value);
                txtTongTien.Text = TongTienTmp.ToString();

                dgvPhieuMua.Rows.RemoveAt(clicked_row);

                Console.WriteLine("Xóa sản phẩm được chọn thành công!");

                clicked_row = -1;

                current_Rows_In_Table--;
            }
        }

        private void dgvPhieuMua_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clicked_row = e.RowIndex;
        }
    }
}
