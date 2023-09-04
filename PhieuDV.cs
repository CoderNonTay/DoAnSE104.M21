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
    public partial class PhieuDV : Form
    {
        int clicked_row = -1;
        private int current_Rows_In_Table = -1;
        public PhieuDV()
        {
            InitializeComponent();

            LoadLoaiDV();

            txtTongTien.Text = "0";
            txtTongTienTraTruoc.Text = "0";
            txtTongTienConLai.Text = "0";
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Console.WriteLine("Xác nhận.");
            }
        }

        //quan trong

        void LoadLoaiDV()
        {
            List<LOAIDICHVU> listLoaiDV = LOAIDICHVUDAO.Instance.GetListLoaiDV();
            cbLoaiDV.DataSource = listLoaiDV;
            cbLoaiDV.DisplayMember = "TenLoaiDV";
        }

        void input_clear()
        {
            txtChiPhiRieng.Clear();
            txtDonGiaDuocTinh.Clear();
            txtThanhTien.Clear();
            txtTraTruoc.Clear();
            nmSL.Value = 0;
            cbTinhTrang.Text = "";
            return;
        }
        private void cbLoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            DTO.LOAIDICHVU selected = cb.SelectedItem as LOAIDICHVU;
            txtDonGiaDV.Text = selected.DonGiaDV.ToString();
            input_clear();
        }

        private void txtChiPhiRieng_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.Text == "")
                return;

            txtDonGiaDuocTinh.Text = (Convert.ToInt64(txt.Text) + Convert.ToInt64(txtDonGiaDV.Text)).ToString();
        }

        private void nmSL_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nm = sender as NumericUpDown;

            if (nm.Value == 0)
                return;

            txtThanhTien.Text = (Convert.ToInt64(nm.Value) * Convert.ToInt64(txtDonGiaDuocTinh.Text)).ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận làm mới?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                dgvPhieuDichVu.Rows.Clear();
                txtTongTien.Clear();
                txtTongTienTraTruoc.Clear();
                txtTongTienConLai.Clear();
                Console.WriteLine("Làm mới.");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float PTTraTruoc = THAMSODAO.Instance.GetPhanTramTraTruoc();
            float tempTraTruoc = (float)Convert.ToDouble(txtTraTruoc.Text);
            float tempThanhTien = (float)Convert.ToDouble(txtThanhTien.Text);
            float tempTraTruocHopLe = tempThanhTien * PTTraTruoc / 100;

            float ConLai = Convert.ToInt32(txtThanhTien.Text) - Convert.ToInt32(txtTraTruoc.Text);

            if (tempTraTruoc < tempTraTruocHopLe)
            {
                MessageBox.Show("Số tiền trả trước phải lớn hơn hoặc bằng " + tempTraTruocHopLe, "Cảnh báo!");
                return;
            }
            if (tempTraTruoc > tempThanhTien)
            {
                MessageBox.Show("Trả trước dư " + (tempTraTruoc - tempThanhTien), "Cảnh báo!");
                ConLai = 0;
                tempTraTruoc = tempThanhTien;
            }
            for (int i = 0; i < dgvPhieuDichVu.Rows.Count - 1; i++)
            {
                //if (current_MaSP == 0)
                //{ MessageBox.Show("Không có sản phẩm!", "Cảnh báo!", MessageBoxButtons.OKCancel); return; }

                if (dgvPhieuDichVu[0, i].Value.ToString() == cbLoaiDV.Text && dgvPhieuDichVu[2, i].Value.ToString() == txtChiPhiRieng.Text)
                {
                    //Cong them so luong
                    int tempSL = Convert.ToInt32(dgvPhieuDichVu[4, i].Value);
                    dgvPhieuDichVu[4, i].Value = (tempSL + Convert.ToInt32(nmSL.Value)).ToString();
                    //Tang thanh tien
                    float tempTT = (float)Convert.ToDouble(dgvPhieuDichVu[5, i].Value);
                    dgvPhieuDichVu[5, i].Value = (tempTT + (Convert.ToInt32(nmSL.Value) * (float)Convert.ToDouble(txtDonGiaDuocTinh.Text))).ToString();
                    //Tang thanh toan tra truoc
                    float temp1 = (float)Convert.ToDouble(dgvPhieuDichVu[6, i].Value);
                    dgvPhieuDichVu[6, i].Value = (temp1 + tempTraTruoc).ToString();
                    //Tang thanh toan con lai

                    dgvPhieuDichVu[7, i].Value = ((float)Convert.ToDouble(dgvPhieuDichVu[5, i].Value) - (float)Convert.ToDouble(dgvPhieuDichVu[6, i].Value)).ToString();

                    //SANPHAMDAO.Instance.ThayDoiDonGiaMua(txtDonGiaMua.Text, current_MaSP);

                    float TongTmp = (float)Convert.ToDouble(txtTongTien.Text);
                    TongTmp += (float)Convert.ToDouble(txtThanhTien.Text);
                    txtTongTien.Text = TongTmp.ToString();

                    //Xuat Tong tien tra truoc
                    float TongTraTruocTmp = (float)Convert.ToDouble(txtTongTienTraTruoc.Text);
                    TongTraTruocTmp += tempTraTruoc;
                    txtTongTienTraTruoc.Text = TongTraTruocTmp.ToString();

                    //Xuat tong tien con lai
                    float TongConLaiTmp = (float)Convert.ToDouble(txtTongTienConLai.Text);
                    TongConLaiTmp = TongTmp - TongTraTruocTmp;
                    txtTongTienConLai.Text = TongConLaiTmp.ToString();

                    input_clear();

                    return;
                }
            }
            //Them vao bang hien thi

            dgvPhieuDichVu.Rows.Add(cbLoaiDV.Text, txtDonGiaDV.Text, txtChiPhiRieng.Text, txtDonGiaDuocTinh.Text, nmSL.Value, txtThanhTien.Text, tempTraTruoc.ToString(), ConLai.ToString(), dtpNgayGiao.Text, cbTinhTrang.Text);
            current_Rows_In_Table++;

            //Xuat Tong tien
            float TongTienTmp = (float)Convert.ToDouble(txtTongTien.Text);
            TongTienTmp += (float)Convert.ToDouble(txtThanhTien.Text);
            txtTongTien.Text = TongTienTmp.ToString();

            //Xuat Tong tien tra truoc
            float TongTienTraTruocTmp = (float)Convert.ToDouble(txtTongTienTraTruoc.Text);
            TongTienTraTruocTmp += tempTraTruoc;
            txtTongTienTraTruoc.Text = TongTienTraTruocTmp.ToString();

            //Xuat tong tien con lai

            float TongTienConLaiTmp = TongTienTmp - TongTienTraTruocTmp;
            txtTongTienConLai.Text = TongTienConLaiTmp.ToString();

            input_clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (current_Rows_In_Table == -1)
            {
                MessageBox.Show("Không có dịch vụ để lưu!", "Cảnh báo!", MessageBoxButtons.OKCancel);
                return;
            }

            DialogResult dlr = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                int current_MaKH = KHACHHANGDAO.Instance.GetMaKHByTenKH(txtKhachHang.Text);
                PHIEUDICHVUDAO.Instance.InsertPhieuDVtoDatabase(current_MaKH, (float)Convert.ToDouble(txtTongTien.Text), (float)Convert.ToDouble(txtTongTienTraTruoc.Text), (float)Convert.ToDouble(txtTongTienConLai.Text));

                int currentSoPDV = PHIEUDICHVUDAO.Instance.GetCurrentSoPDV();

                for (int i = 0; i < dgvPhieuDichVu.Rows.Count - 1; i++)
                {
                    int MaLoaiDV = LOAIDICHVUDAO.Instance.GetMaLoaiDVByTenLoaiDV(dgvPhieuDichVu[0, i].Value.ToString());
                    float ChiPhiRieng = (float)Convert.ToDouble(dgvPhieuDichVu[2, i].Value);
                    float DonGiaDuocTinh = (float)Convert.ToDouble(dgvPhieuDichVu[3, i].Value);
                    int SoLuong = Convert.ToInt32(dgvPhieuDichVu[4, i].Value);
                    float ThanhTien = (float)Convert.ToDouble(dgvPhieuDichVu[5, i].Value);
                    float Truoc = (float)Convert.ToDouble(dgvPhieuDichVu[6, i].Value);
                    float Sau = (float)Convert.ToDouble(dgvPhieuDichVu[7, i].Value);
                    string NgayGiao = dgvPhieuDichVu[8, i].Value.ToString();
                    string TinhTrang = Convert.ToString(dgvPhieuDichVu[9, i].Value);
                    CT_PDVDAO.Instance.InsertCT_PDVToDataBase(currentSoPDV, MaLoaiDV, ChiPhiRieng, DonGiaDuocTinh, SoLuong, ThanhTien, Truoc, Sau, NgayGiao, TinhTrang);
                }

                dgvPhieuDichVu.Rows.Clear();
                txtTongTien.Text = "0";
                txtTongTienTraTruoc.Text = "0";
                txtTongTienConLai.Text = "0";
                txtKhachHang.Clear();
                Console.WriteLine("Lưu.");
            }
        }

        private void txtKhachHang_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt.Text == "")
                return;

            string SDT = KHACHHANGDAO.Instance.GetSDT_KHByTenKH(txt.Text);
            txtSDT.Text = SDT;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (current_Rows_In_Table == -1)
            { MessageBox.Show("Không có sản phẩm nào trong phiếu mua!", "Cảnh báo!"); return; }
            DialogResult dlr = MessageBox.Show("Xác nhận xóa sản phẩm được chọn?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                float TongTienTmp = (float)Convert.ToDouble(txtTongTien.Text);
                TongTienTmp -= (float)Convert.ToDouble(dgvPhieuDichVu[5, clicked_row].Value);
                txtTongTien.Text = TongTienTmp.ToString();

                //Xuat Tong tien tra truoc
                float TongTienTraTruocTmp = (float)Convert.ToDouble(txtTongTienTraTruoc.Text);
                TongTienTraTruocTmp -= (float)Convert.ToDouble(dgvPhieuDichVu[6, clicked_row].Value);
                txtTongTienTraTruoc.Text = TongTienTraTruocTmp.ToString();

                //Xuat tong tien con lai

                float TongTienConLaiTmp = TongTienTmp - TongTienTraTruocTmp;
                txtTongTienConLai.Text = TongTienConLaiTmp.ToString();


                dgvPhieuDichVu.Rows.RemoveAt(clicked_row);

                Console.WriteLine("Xóa sản phẩm được chọn thành công!");

                current_Rows_In_Table--;

                clicked_row = -1;
            }

        }

        private void dgvPhieuDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clicked_row = e.RowIndex;
        }

        private void dgvPhieuDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicked_row = e.RowIndex;
        }

        private void dgvPhieuDichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clicked_row = e.RowIndex;
        }

        private void dgvPhieuDichVu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clicked_row = e.RowIndex;
        }
    }
}
