using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAndBillingSystem.UI
{
    public partial class ProductFormcs : Form
    {
        public int userID { get; set; }
        public ProductFormcs()
        {
            InitializeComponent();
        }

        private void ratelbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
