using Npgsql;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginUser();
            }
        }
        private void BtnGoRegister_Click(object sender, EventArgs e)
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEmail.Text = "";
            TxtPassword.Text = "";
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
            }
        }
        private void LoginUser()
        {
            try
            {
                string email = TxtEmail.Text;
                string password = TxtPassword.Text;

                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE email = @email AND password = @password", conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MenuWindow menuWindow = new MenuWindow();
                            menuWindow.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login failed! Please check your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
