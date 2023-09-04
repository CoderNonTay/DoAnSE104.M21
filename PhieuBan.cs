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
    public partial class PhieuBan : Form
    {
        public PhieuBan()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận làm mới?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Console.WriteLine("Làm mới.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dlr == DialogResult.OK)
            {
                Console.WriteLine("Lưu.");
            }
        }
    }
}
