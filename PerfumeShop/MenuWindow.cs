using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PerfumeShop
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
            ShowPerfumesForHer();
            ShowPerfumesForHim();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            PerfumeSelected();
        }

        private void BtnGoToCart_Click(object sender, EventArgs e)
        {
            Hide();
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Show();
        }
        public void ShowPerfumesForHim()
        {
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM perfumes WHERE gender = 'Male' OR gender = 'unisex'", conn))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            DGVHim.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void ShowPerfumesForHer()
        {
             try
             {
                 string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                 using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                 {
                     conn.Open();

                     using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM perfumes WHERE gender = 'Female' OR gender = 'unisex'", conn))
                     {
                         using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                         {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                DGVHer.DataSource = dataTable;
                          }
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void BtnBackToFirstWindow_Click(object sender, EventArgs e)
        {
            Hide();
            FirstWindow firstWindow = new FirstWindow();
            firstWindow.Show();
        }
        private int GetUserId(string email)
        {
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id FROM users WHERE email = @email", conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);
                            return userId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return -1; // Return -1 if the user is not found or an error occurred
        }

        private void PerfumeSelected()
        {
            if (DGVHim.CurrentRow == null)
                return;

            int perfumeId = (int)DGVHim.CurrentRow.Cells["Id"].Value;
            string perfumeName = DGVHim.CurrentRow.Cells["Name"].Value.ToString();
            string perfumeCompany = DGVHim.CurrentRow.Cells["Company"].Value.ToString();
            string perfumeGender = DGVHim.CurrentRow.Cells["Gender"].Value.ToString();
            double perfumePrice = (double)DGVHim.CurrentRow.Cells["Price"].Value;

            // Insert the selected perfume into the shopping cart for the currently logged in user
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Get the currently logged in user's ID
                    User user = new User();
                    string email = user.GetEmail();
                    int userId = GetUserId(email);


                    // Insert the selected perfume into the shopping cart for the current user
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO shopping_cart(user_id, perfume_id) VALUES (@userId, @perfumeId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@perfumeId", perfumeId);
                        cmd.ExecuteNonQuery();

                        // Show a success message
                        MessageBox.Show($"Perfume '{perfumeName}' added to shopping cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

    }
}
