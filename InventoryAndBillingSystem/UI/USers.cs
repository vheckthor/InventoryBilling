using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMangement.EF;
using DataMangement.Repository;

namespace InventoryAndBillingSystem.UI
{
    public partial class FormUsers : Form
    {
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

        private DbSet<User> dala { get; set; }
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
            var search = boxSearch.Text;
            using (var db = new Model1())
            {
                var values =
                    from x in db.Users
                    where (x.FirstName.Contains(search) || x.LastName.Contains(search) || x.UserName.Contains(search))
                    select x;

                IDbCommand cmd = System.Data.Linq.DataContext.db.Users.GetCommand(values);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = (SqlCommand)cmd;
                DataTable dt = new DataTable();

                try
                {
                    cmd.Connection.Open();
                    adapter.FillSchema(dt, SchemaType.Source);
                    adapter.Fill(dt);
                    var ase = dt;
                }
                finally
                {
                    cmd.Connection.Close();
                }
              
            }
        }
    }
}
