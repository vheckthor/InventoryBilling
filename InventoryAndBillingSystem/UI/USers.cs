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
using AutoMapper;
using DataMangement.EF;
using DataMangement.Repository;
using InventoryAndBillingSystem.BusinessLogic;
using InventoryAndBillingSystem.Extensions;

namespace InventoryAndBillingSystem.UI
{
    public partial class FormUsers : Form
    {
        private DataTable Binder { get; set; }
        public int userId { get; set; }
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            boxSearch.Clear();
            var search = "";
            using (var db = new Model1())
            {

                var query =
                    from x in db.Users
                    where (x.FirstName.Contains(search) || x.LastName.Contains(search) || x.UserName.Contains(search))
                    select x;
                var bind = query.ToListAsync()
                    .Result;

                dataUser.DataSource = bind.ToDataTable();


            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //create mapper
            Mapper.CreateMap<UserDTO, User>();

            var users = new UserDTO();
            bool tracker = false;

            try
            {
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
                users.AddedBy = userId;

                if 
                (
                    String.IsNullOrWhiteSpace(users.FirstName)||
                    String.IsNullOrWhiteSpace(users.LastName)||
                    String.IsNullOrWhiteSpace(users.Password)||
                    String.IsNullOrWhiteSpace(users.UserName)||
                    String.IsNullOrWhiteSpace(users.Email)||
                    String.IsNullOrWhiteSpace(users.Address)||
                    String.IsNullOrWhiteSpace(users.Contact)||
                    String.IsNullOrWhiteSpace(users.UserType)

                )
                {
                    MessageBox.Show("The input field cannot be empty or whitespaces");
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("One or more errors occured please check your entries and retry");
                return;
            }


;
            using (var db = new Model1())
            {
                //mapped entities
                var userStored = Mapper.Map<User>(users);

                db.Users.Add(userStored);
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


        private void boxSearch_TextChanged_1(object sender, EventArgs e)
        {
            var search = boxSearch.Text;
            using (var db = new Model1())
            {

                var query =
                    from x in db.Users
                    where (x.FirstName.Contains(search) || x.LastName.Contains(search) || x.UserName.Contains(search))
                    select x;
               var bind = query.ToListAsync()
                    .Result;
                Binder=bind.ToDataTable();

                  dataUser.DataSource = Binder;


            }

        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
