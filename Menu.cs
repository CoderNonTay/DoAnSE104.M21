using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPhieuMua_Click(object sender, EventArgs e)
        {
            PhieuMua f = new PhieuMua();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhieuBan_Click(object sender, EventArgs e)
        {
            PhieuBan f = new PhieuBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhieuDV_Click(object sender, EventArgs e)
        {
            MenuDV f = new MenuDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoKho f = new BaoCaoKho();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


    }
}
