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
    public partial class AdminPerfumesList : Form
    {
        public AdminPerfumesList()
        {
            InitializeComponent();
            ShowPerfumes();
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
        private void ShowPerfumes()
        {
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM perfumes", conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DGVPerfumes.DataSource = dataTable;
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
            if(DGVPerfumes.SelectedRows.Count > 0)
            {
                int index = DGVPerfumes.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DGVPerfumes.Rows[index].Cells[0].Value);
                string name = DGVPerfumes.Rows[index].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {name}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                        using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();

                            using (NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM perfumes WHERE id = {id}", conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"{name} has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ShowPerfumes();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please select a perfume to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
