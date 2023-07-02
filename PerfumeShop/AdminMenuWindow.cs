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
    public partial class AdminMenuWindow : Form
    {
        public AdminMenuWindow()
        {
            InitializeComponent();
        }

        private void AddPerfume_Click(object sender, EventArgs e)
        {
            Hide();
            AddPerfume addPerfume = new AddPerfume();
            addPerfume.Show();
        }

        private void UserListBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminUsersList adminUsersList = new AdminUsersList();
            adminUsersList.Show();

        }

        private void PerfumeListBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPerfumesList adminPerfumeList = new AdminPerfumesList();
            adminPerfumeList.Show();

        }

        private void BtnBackToFirstWindow_Click(object sender, EventArgs e)
        {
            Hide();
            FirstWindow firstWindow = new FirstWindow();
            firstWindow.Show();
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
           FrmRegister registerUser = new FrmRegister();
           registerUser.Show();
        }
    }
}
