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
    public partial class BaoCaoKho : Form
    {
        public BaoCaoKho()
        {
            InitializeComponent();
        }
        private void check_month_year(object sender, EventArgs e)
        {
            labelMonth.Text = Convert.ToString(nmMonth.Value);
            labelYear.Text = Convert.ToString(nmYear.Value);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang bảo trì.", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            dgvBCKho.ClearSelection();
            dgvBCKho.DataSource = BAOCAODAO.Instance.Display(nmMonth.Value.ToString(), nmYear.Value.ToString());
        }

        private void BaoCaoKho_Load(object sender, EventArgs e)
        {

        }
    }

}
