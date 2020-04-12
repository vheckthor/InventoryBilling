using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryAndBillingSystem.UI;

namespace InventoryAndBillingSystem
{
    public partial class FormAdminDashBoard : Form
    {
        public string user { get; set; }
        public FormAdminDashBoard()
        {
            InitializeComponent();
        }

        private void labelBilling_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminDashBoard_Load(object sender, EventArgs e)
        {
            adminuser.Text = user;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers users = new FormUsers();
            users.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login = new LoginForm();
            Hide();
            login.Show();

        }

        private void adminuser_Click(object sender, EventArgs e)
        {

        }
    }
}
