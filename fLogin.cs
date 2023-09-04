using System;
using System.Collections.Generic;
using System.ComponentModel;
using WindowsFormsApp1.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            BAOCAODAO.Instance.KiemTra_BC();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool Login(string username, string password)
        {
           return AccountDAO.Instance.Login(username, password);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;

            if (Login(username, password))
            {
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void bShowPass_Click(object sender, EventArgs e)
        {
            if (txbPassWord.PasswordChar=='*')
            {
                bHidePass.BringToFront();
                txbPassWord.PasswordChar = '\0';
            }
        }

            private void bHidePass_Click(object sender, EventArgs e)
        {
            if (txbPassWord.PasswordChar == '\0')
            {
                bShowPass.BringToFront();
                txbPassWord.PasswordChar = '*';
            }
        }
    }
}
