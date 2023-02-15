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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PerfumeShop
{
    public partial class AddPerfume : Form
    {
        public AddPerfume()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnAddPerfume_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtPrice.Text == "" || TxtCompany.Text=="" || TxtGender.Text=="" ) 
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddPerfumeToDb();
            }
        }
        private void AddPerfumeToDb()
        {
            try
            {
                string name = TxtName.Text;
                string company = TxtCompany.Text;
                string gender = TxtGender.Text;
                double price = double.Parse(TxtPrice.Text);
                
                
                string connString = "Server=localhost;Port=5432;Database=PerfumeShop;User Id=postgres;Password=d8ebad343;";
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO perfumes(name, company,gender,price) VALUES(@name, @company,@gender,@price)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@company", company);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@price", price);
                        
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Perfume added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.Text = "";
                TxtCompany.Text = "";
                TxtGender.Text = "";
                TxtPrice.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot add perfume", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackToFirstWindow_Click(object sender, EventArgs e)
        {
            Hide();
            FirstWindow firstWindow = new FirstWindow();
            firstWindow.Show();
        }
    }
}
