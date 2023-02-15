using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PerfumeShop
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost; Port=5432;User Id=postgres;Password=d8ebad343;Database=PerfumeShop;");
        }
        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "" || TxtPassword.Text == "" || TxtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match","Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegisterUser();
            }
            
        }

        private void BtnGoLogin_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPassword.Checked)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtConfirmPassword.PasswordChar = '*';
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEmail.Text = "";
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";
        }
        private void RegisterUser()
        {
            try
            {
                string email = TxtEmail.Text;
                string password = TxtPassword.Text;

                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO users(email, password) VALUES(@email, @password)", conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("You will be redirected to the login page", "Registration successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
