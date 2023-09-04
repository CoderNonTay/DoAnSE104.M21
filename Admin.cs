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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadLoaiSanPham();
        }


        bool Flag_SanPham = false;//De cho biet san pham dang muon thao tac la lay tu csdl hay la them moi vao csdl
        string currentTenSanPham;

        #region methods


        void LoadLoaiSanPham()
        {
            List<LOAISP> listLoaiSP = LOAISPDAO.Instance.GetListLoaiSanPham();
            cbLoaiSP_SP.DataSource = listLoaiSP;
            cbLoaiSP_SP.DisplayMember = "TenLoaiSP";
        }
        #endregion

        #region Events
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận thay đổi?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Console.WriteLine("Xác nhận.");
            }
        }
        private void btnAdjust_SP_Click(object sender, EventArgs e)
        {
            if (Flag_SanPham == false)
            {
                MessageBox.Show("Bạn đang thao tác với một sản phẩm chưa có trên csdl, vui lòng bấm nút thêm!", "Cảnh báo!", MessageBoxButtons.OK);
                return;
            }

            DialogResult dlr = MessageBox.Show("Xác nhận thay đổi?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                SANPHAMDAO.Instance.UpdateSanPham(SANPHAMDAO.Instance.GetMaSanPhamByTenSP(currentTenSanPham), txtTenSP_SP.Text, LOAISPDAO.Instance.GetIdLoaiSPByTen(cbLoaiSP_SP.Text));
                Flag_SanPham = false;
                dgvSanPham.Rows.Clear();
                txtTenSP_SP.Text = "";
                Console.WriteLine("Xác nhận.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Xác nhận thêm?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Console.WriteLine("Xác nhận.");
            }
        }

        private void btnAdd_SP_Click(object sender, EventArgs e)
        {
            if (Flag_SanPham == true)
            {
                MessageBox.Show("Bạn đang thao tác với một sản phẩm hiện có trên csdl, vui lòng bấm nút điều chỉnh!", "Cảnh báo!", MessageBoxButtons.OK);
                return;
            }
            DialogResult dlr = MessageBox.Show("Xác nhận thêm?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                SANPHAMDAO.Instance.ThemSP(LOAISPDAO.Instance.GetIdLoaiSPByTen(cbLoaiSP_SP.Text), txtTenSP_SP.Text);
                CT_BAOCAODAO.Instance.NhapCTBC(SANPHAMDAO.Instance.GetMaSanPhamByTenSP(txtTenSP_SP.Text));
                Console.WriteLine("Xác nhận.");
            }
        }

        #endregion

        private void btnFind_SP_Click(object sender, EventArgs e)
        {
            dgvSanPham.Rows.Clear();
            List<SANPHAM> SP = SANPHAMDAO.Instance.SearchSanPhamByName(txtSearch_SP.Text);
            foreach (SANPHAM temp in SP)
            {
                LOAISP loaisp = LOAISPDAO.Instance.GetLoaiSPByID(temp.MaLoaiSP);
                dgvSanPham.Rows.Add(temp.TenSP, loaisp.TenLoaiSP, DVTDAO.Instance.GetDVTByID(loaisp.MaDVT).TenDVT, loaisp.LoiNhuan, temp.DonGiaMuaVao, temp.DonGiaBanRa);
            }
        }

        private void dgvSP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            currentTenSanPham = txtTenSP_SP.Text = dgvSanPham[0, row].Value.ToString();
            Flag_SanPham = true;
            cbLoaiSP_SP.Text = LOAISPDAO.Instance.GetTenLoaiSPByTenSanPham(txtTenSP_SP.Text);
        }
    }
}
