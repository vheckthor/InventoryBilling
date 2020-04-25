using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
    public partial class DealerandCustomerForm : Form
    {
        public int UserID { get; set; }
        public DealerandCustomerForm()
        {
            InitializeComponent();
        }

        private void DealerandCustomerForm_Load(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                dataUser.DataSource = db.DealCustomers.ToList().ToDataTable();
                boxEmail.Clear();
                boxAddress.Clear();
                boxContact.Clear();
                namebox.Clear();
                boxUserID.Clear();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var idstring = boxUserID.Text;
                if (string.IsNullOrWhiteSpace(idstring))
                {
                    MessageBox.Show("No Values has been selected for deleting");

                    return;
                }
                var id = int.Parse(idstring);
                var category = db.DealCustomers.FirstOrDefault(x => x.id == id);

                db.DealCustomers.Remove(category);
                var sol = db.SaveChanges() > 0;
                if (sol)
                {
                    MessageBox.Show("Deleted successfully");
                    boxEmail.Clear();
                    boxAddress.Clear();
                    boxContact.Clear();
                    namebox.Clear();
                    boxUserID.Clear();

                    //code to refresh the data table

                    var found = db.DealCustomers.ToList();

                    dataUser.DataSource = found.ToDataTable();
                }
            }
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<DealCustomerDTO, DealCustomer>();
            DealCustomerDTO dealer = new DealCustomerDTO();
            try
            {
                dealer.Name = namebox.Text;
                dealer.Email = boxEmail.Text;
                dealer.Contact = boxContact.Text;
                dealer.Address = boxAddress.Text;
                dealer.AddedDate=DateTime.Now;
                dealer.AddedBy = UserID;
                dealer.Type = comboboxUserType.SelectedItem.ToString();
                if (string.IsNullOrWhiteSpace(dealer.Name) ||
                    string.IsNullOrWhiteSpace(dealer.Email) ||
                    string.IsNullOrWhiteSpace(dealer.Contact) ||
                    string.IsNullOrWhiteSpace(dealer.Address) ||
                    string.IsNullOrWhiteSpace(dealer.Type)

                )
                {
                    MessageBox.Show("One or more inputs is incorrect");
                    return;
                }

            }
            catch (Exception exception)
            {
                //log the exception later
                MessageBox.Show("An error occured please try again");
                return;
            }

            using (var db = new Model1())
            {
                var dealed =Mapper.Map<DealCustomerDTO, DealCustomer>(dealer);
                var val = db.DealCustomers.FirstOrDefault(c => c.Name.ToLower() == dealed.Name.ToLower()&& c.Email==dealed.Email);

                if (val != null)
                {
                    MessageBox.Show("User already exist");
                    return;
                }
                

                db.DealCustomers.Add(dealed);
                var result = db.SaveChanges()>0;
                if (result)
                {
                    MessageBox.Show("Input added successfully");
                    dataUser.DataSource = db.DealCustomers.ToList().ToDataTable();
                    boxEmail.Clear();
                    boxAddress.Clear();
                    boxContact.Clear();
                    namebox.Clear();
                    boxUserID.Clear();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<DealCustomerDTO, DealCustomer>();
            DealCustomerDTO dealer = new DealCustomerDTO();
            try
            {
                dealer.Name = namebox.Text;
                dealer.Email = boxEmail.Text;
                dealer.Contact = boxContact.Text;
                dealer.Address = boxAddress.Text;
                dealer.AddedDate = DateTime.Now;
                dealer.AddedBy = UserID;
                dealer.Type = comboboxUserType.SelectedItem.ToString();
                if (string.IsNullOrWhiteSpace(dealer.Name) ||
                    string.IsNullOrWhiteSpace(dealer.Email) ||
                    string.IsNullOrWhiteSpace(dealer.Contact) ||
                    string.IsNullOrWhiteSpace(dealer.Address) ||
                    string.IsNullOrWhiteSpace(dealer.Type)

                )
                {
                    MessageBox.Show("One or more inputs is incorrect");
                    return;
                }

            }
            catch (Exception exception)
            {
                //log the exception later
                MessageBox.Show("An error occured please try again");
                return;
            }

            using (var db = new Model1())
            {
                var dealed = Mapper.Map<DealCustomerDTO, DealCustomer>(dealer);
                var id = boxUserID.Text;
                
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("ID cannot be null or empty");
                    return;
                }

                var ids = 0;

                     int.TryParse(id, out ids);

                dealed.id = ids;


                db.DealCustomers.AddOrUpdate(dealed);

                var result = db.SaveChanges() > 0;
                if (result)
                {
                    MessageBox.Show("Input added successfully");
                    dataUser.DataSource = db.DealCustomers.ToList().ToDataTable();
                    boxEmail.Clear();
                    boxAddress.Clear();
                    boxContact.Clear();
                    namebox.Clear();
                    boxUserID.Clear();
                }
            }
        }

        private void boxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var content = boxSearch.Text;
                var returner = (from x in db.DealCustomers
                    where x.Name.Contains(content) 
                          || x.Type.Contains(content)
                          ||x.Email.Contains(content)
                          ||x.id.ToString().Contains(content)
                    select x).ToList().ToDataTable();

                dataUser.DataSource = returner;
            }
        }

        private void boxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            DealerandCustomerForm_Load(sender, e);
        }



        private void dataUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            boxUserID.Text = dataUser.Rows[rowIndex].Cells[0].Value.ToString();
            namebox.Text = dataUser.Rows[rowIndex].Cells[2].Value.ToString();
            boxEmail.Text = dataUser.Rows[rowIndex].Cells[3].Value.ToString();
            boxContact.Text = dataUser.Rows[rowIndex].Cells[4].Value.ToString();
            boxAddress.Text = dataUser.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DealerandCustomerForm_MouseClick(object sender, MouseEventArgs e)
        {
            DealerandCustomerForm_Load(sender, e);
        }
    }
}
