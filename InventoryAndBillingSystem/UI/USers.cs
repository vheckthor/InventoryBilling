using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMangement.EF;
using DataMangement.Repository;
using InventoryAndBillingSystem.Extensions;

namespace InventoryAndBillingSystem.UI
{
    public partial class FormUsers : Form
    {
        private DataTable Binder { get; set; }
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
           // dataUser.DataSource = DbContextExtensions.DataTable(, "select * from users");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var users = new User();
            bool tracker = false;

            users.FirstName = boxFirstName.Text;
            users.LastName = boxLastName.Text;
            users.Email = boxEmail.Text;
            users.Address = boxAddress.Text;
            users.Contact = boxContact.Text;
            users.Gender = comboBoxGender.SelectedItem.ToString();
            users.Password = boxPassword.Text;
            users.UserName = boxUsername.Text;
            users.UserType = comboboxUserType.SelectedItem.ToString();
            users.AddedDate = DateTime.Now;
            users.AddedBy = 1;

;
            using (var db = new Model1())
            {
                db.Users.Add(users);
                await db.SaveChangesAsync();
                tracker = true;
            }

            if (tracker)
            {
                MessageBox.Show("User Successfully Created");
                boxContact.Clear();
                boxFirstName.Clear();
                boxLastName.Clear();
                boxEmail.Clear();
                boxAddress.Clear();
                boxPassword.Clear();
                boxUsername.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }

        }

        private void dataSet1_Initialized(object sender, EventArgs e)
        {

        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxSearch_TextChanged_1(object sender, EventArgs e)
        {
            var search = boxSearch.Text;
            using (var db = new Model1())
            {
                // DataSet ds = new DataSet();
                // ds.Locale=CultureInfo.InvariantCulture;


                //DataTable dt = ds.Tables["User"];
                var query =
                    from x in db.Users
                    where (x.FirstName.Contains(search) || x.LastName.Contains(search) || x.UserName.Contains(search))
                    select x;
               var bind = query.ToListAsync()
                    .Result;
                Binder=bind.ToDataTable();

                  dataUser.DataSource = Binder;

                //DataTable bondTable = query.CopyToDataTable<DataRow>();

                //Binder.DataSource = bondTable;


            }

        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
