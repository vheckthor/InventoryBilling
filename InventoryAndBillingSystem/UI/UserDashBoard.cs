﻿using System;
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
    public partial class UserDashBoard : Form
    {
        public string currentUser { get; set; }
        public static string clickedValue;
        public UserDashBoard()
        {
            InitializeComponent();
        }


        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            presentuser.Text = currentUser;
        }

        private void UserDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login=new LoginForm();
            Hide();
            login.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseAndSalesForm openPurchaseAndSalesForm = new PurchaseAndSalesForm();
            openPurchaseAndSalesForm.Show();
            clickedValue = "purchase";
        }

        private void salesFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseAndSalesForm openPurchaseAndSalesForm = new PurchaseAndSalesForm();
            openPurchaseAndSalesForm.Show();
            clickedValue = "sales";
        }
    }
}
