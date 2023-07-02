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
public partial class AdminPasswordWindow : Form
    {
        public AdminPasswordWindow()
        {
            InitializeComponent();
       
        }
        private string password = "admin";
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '*';
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                FirstWindow firstWindow = new FirstWindow();
                firstWindow.Show();
            }
        }

        private void BtnVerify_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text == password)
            {
                Hide();
                AdminMenuWindow adminMenuWindow = new AdminMenuWindow();
                adminMenuWindow.Show();
            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
