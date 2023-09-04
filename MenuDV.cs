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
    public partial class MenuDV : Form
    {
        public MenuDV()
        {
            InitializeComponent();
        }

        private void btnPhieuDV_Click(object sender, EventArgs e)
        {
            PhieuDV f = new PhieuDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDSDV_Click(object sender, EventArgs e)
        {
            DSPhieuDV f = new DSPhieuDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
