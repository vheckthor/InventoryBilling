using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMangement.EF;
using InventoryAndBillingSystem.BusinessLogic;

namespace InventoryAndBillingSystem.UI
{
    public partial class LoginForm : Form
    {
        private readonly LoginFormDTO _loginForm;

        public LoginForm()
        {
            InitializeComponent();
            _loginForm = new LoginFormDTO();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _loginForm.Username = usernametextbox.Text.ToLower().Trim();
                _loginForm.Password = passwordtextbox.Text.Trim();
                _loginForm.UserType = usertypecombobox.SelectedItem.ToString().ToLower();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured please make sure all input field are filled");
            }


            using (var db = new Model1())
            {
                var user = db.Users.FirstOrDefault(x => x.UserName.ToLower() == _loginForm.Username);
                if (user == null)
                {
                    MessageBox.Show("Your login details is incorrect please check them and try again");
                    return;
                }

                var check = user.UserType.ToLower().Trim();
                var passwordchecker = user.Password.Trim();

                if ((passwordchecker==_loginForm.Password) && (check==_loginForm.UserType))
                {
                    MessageBox.Show("Login successful");
                    switch (check)
                    {
                        case
                            "admin":
                        {
                            FormAdminDashBoard admin = new FormAdminDashBoard();
                            admin.user = _loginForm.Username.Trim();
                            admin.userId = user.id;
                            admin.Show();
                            Hide();
                            break;

                        }
                        case 
                            "normal users":
                        { 
                            UserDashBoard users = new UserDashBoard();
                            users.currentUser = _loginForm.Username.Trim();
                            users.Show();
                            Hide();
                            break;
                        }

                        default:
                            MessageBox.Show("Cannot Identify User");
                            break;
                    }
                }
                else
                {

                    MessageBox.Show("Your login details is incorrect please check them and try again");
                }
            }
        }

        private void usertypecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
