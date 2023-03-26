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
    public partial class ShoppingCart : Form
    {
        public User user { get; set; }
        public ShoppingCart(User user)
        {
            InitializeComponent();
            this.user = user;
            ShowShoppingCart();
            
        }

        private void BtnBackToMenuWindow_Click(object sender, EventArgs e)
        {
            Hide();
            MenuWindow menuWindow = new MenuWindow(user);
            menuWindow.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowShoppingCart()
        {
            try
            {
                
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    int userId = user.GetId();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT perfumes.name AS PerfumeName, perfumes.company AS Company, perfumes.price AS Price FROM shopping_cart INNER JOIN perfumes ON shopping_cart.perfume_id = perfumes.id WHERE shopping_cart.user_id = @user_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvShoppingCart.DataSource = dt;
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
            if (dgvShoppingCart.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedRowIndex = dgvShoppingCart.SelectedRows[0].Index;
                    string perfumeName = dgvShoppingCart.Rows[selectedRowIndex].Cells["PerfumeName"].Value.ToString();

                    string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                    using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                    {
                        conn.Open();
                        int userId = user.GetId();
                        using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM shopping_cart WHERE user_id = @user_id AND perfume_id = (SELECT id FROM perfumes WHERE name = @perfume_name)", conn))
                        {
                            cmd.Parameters.AddWithValue("@user_id", userId);
                            cmd.Parameters.AddWithValue("@perfume_name", perfumeName);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                ShowShoppingCart();
                                MessageBox.Show("Item removed from shopping cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to remove item from shopping cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the shopping cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void BtnDeleteItems_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    int userId = user.GetId();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM shopping_cart WHERE user_id = @user_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("All items have been removed from your shopping cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowShoppingCart();
                        }
                        else
                        {
                            MessageBox.Show("No items were found in your shopping cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
