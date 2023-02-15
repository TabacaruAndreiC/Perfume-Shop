using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfumeShop
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            FrmRegister register = new FrmRegister();
            register.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddPerfume_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPasswordWindow adminPasswordWindow = new AdminPasswordWindow();
            adminPasswordWindow.Show();
        }
    }
}
