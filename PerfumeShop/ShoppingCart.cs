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
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void BtnBackToMenuWindow_Click(object sender, EventArgs e)
        {
            Hide();
            MenuWindow menuWindow= new MenuWindow();
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

       

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
