using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using DataMangement.EF;
using InventoryAndBillingSystem.BusinessLogic;
using InventoryAndBillingSystem.Extensions;

namespace InventoryAndBillingSystem.UI
{
    public partial class PurchaseAndSalesForm : Form
    {
        public PurchaseAndSalesForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void productdetailshead_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseAndSalesForm_Load(object sender, EventArgs e)
        {
            //Action occurrence when the page loads
            purchasesalesLabel.Text = UserDashBoard.clickedValue;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            string keyword = searchBox.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                nameBox.Clear();
                emailBox.Clear();
                addressBox.Clear();
                contactBox.Clear();
                return;
            }
            using (var db = new Model1())
            {
                var found = db.DealCustomers.FirstOrDefault(x =>
                    x.id.ToString().Contains(keyword) || x.Name.Contains(keyword)|| x.Email.Contains(keyword));

                
                if (found != null)
                {
                    nameBox.Text = found.Name;
                    emailBox.Text = found.Email;
                    addressBox.Text = found.Address;
                    contactBox.Text = found.Contact;
                }


            }
        }
    }
}
