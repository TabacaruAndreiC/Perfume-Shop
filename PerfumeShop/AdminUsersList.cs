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
    public partial class AdminUsersList : Form
    {
        public AdminUsersList()
        {
            InitializeComponent();
            ShowUsers();
        }

        private void BtnBackMenuWindow_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMenuWindow adminMenuWindow = new AdminMenuWindow();
            adminMenuWindow.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void ShowUsers()
        {
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM users ", conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DGVUsers.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if(DGVUsers.SelectedRows.Count > 0)
            {
                try
                {
                    string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                    using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();

                        using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM users WHERE id = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", DGVUsers.SelectedRows[0].Cells[0].Value);
                            cmd.ExecuteNonQuery();
                            ShowUsers();
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
}
