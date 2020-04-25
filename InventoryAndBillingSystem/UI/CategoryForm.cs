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
    public partial class CategoryForm : Form
    {
        public int userID { get; set; }
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            searchbox.Clear();
            categoryidbox.Clear();
            Titlebox.Clear();
            descriptionbox.Clear();
            string searcher = "";
            using (var db = new Model1())
            {
                var found = from x in db.Categories
                    where x.Title.Contains(searcher) || x.Description.Contains(searcher)
                    select x;

                categorydataGridView.DataSource = found.ToList().ToDataTable();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            var data = new CategoriesDTO();
            //create map using automapper
            Mapper.CreateMap<CategoriesDTO, Category>();
            try
            {
                data.Title = Titlebox.Text;
                data.Description = descriptionbox.Text;
                data.DateAdded = DateTime.Now;
                data.Addedby = userID;
                if
                (
                    String.IsNullOrWhiteSpace(data.Title) ||
                    String.IsNullOrWhiteSpace(data.Description)
                )
                {
                    MessageBox.Show("Input cannot be empty or whitespace");
                    return;
                }
            }
            catch (Exception exception)
            {
                //add error logger
                MessageBox.Show("One or more errors occured please try again");
                return;
            }

            using (var db = new Model1())
            {
                var category = Mapper.Map<CategoriesDTO, Category>(data);
                var val = db.Categories.FirstOrDefault(c => c.Title.ToLower() == category.Title.ToLower());
                
                if (val != null)
                {
                    MessageBox.Show("Category already exist");
                    return;
                }

                
                db.Categories.Add(category);
                var sol= db.SaveChanges()>0;
                if (sol)
                {
                    MessageBox.Show("Input saved successfully");
                    Titlebox.Clear();
                    descriptionbox.Clear();
                    //refreshing the datatable
                    string searcher = "";

                        var found = from x in db.Categories
                            where x.Title.Contains(searcher) || x.Description.Contains(searcher)
                            select x;

                        categorydataGridView.DataSource = found.ToList().ToDataTable();
                    
                }
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            var searcher = searchbox.Text;
            using (var db = new Model1())
            {
                var found = from x in db.Categories
                    where x.Title.Contains(searcher) || x.Description.Contains(searcher)
                    select x;

                categorydataGridView.DataSource = found.ToList().ToDataTable();
            }
        }

        private void categorydataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            categoryidbox.Text = categorydataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Titlebox.Text = categorydataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            descriptionbox.Text = categorydataGridView.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            var data = new CategoriesDTO();
            //create map using automapper
            Mapper.CreateMap<CategoriesDTO, Category>();
            try
            {
                data.Title = Titlebox.Text;
                data.Description = descriptionbox.Text;
                data.DateAdded = DateTime.Now;
                data.Addedby = userID;
                if
                (
                    String.IsNullOrWhiteSpace(data.Title) ||
                    String.IsNullOrWhiteSpace(data.Description)
                )
                {
                    MessageBox.Show("Input cannot be empty or whitespace");
                    return;
                }
            }
            catch (Exception exception)
            {
                //add error logger
                MessageBox.Show("One or more errors occured please try again");
                return;
            }

            using (var db = new Model1())
            {
                var category = Mapper.Map<CategoriesDTO, Category>(data);
                var id = categoryidbox.Text;
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("ID cannot be empty");
                    return;
                }
                category.id = int.Parse(id);
                db.Categories.AddOrUpdate(category);
                var sol = db.SaveChanges() > 0;
                if (sol)
                {
                    MessageBox.Show("Input Updated successfully");
                    Titlebox.Clear();
                    descriptionbox.Clear();
                    categoryidbox.Clear();
                    //code to refresh the data table

                    var found = db.Categories.ToList();
                        

                    categorydataGridView.DataSource = found.ToDataTable();
                }
            }
        }

        private void CategoryForm_MouseClick(object sender, MouseEventArgs e)
        {
            CategoryForm_Load(sender,e);
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var idstring = categoryidbox.Text;
                if (string.IsNullOrWhiteSpace(idstring))
                {
                    MessageBox.Show("No Values has been selected for deleting");
                    
                    return;
                }
                var id = int.Parse(idstring);
                var category = db.Categories.FirstOrDefault(x => x.id == id);
                
                db.Categories.Remove(category);
                var sol = db.SaveChanges() > 0;
                if (sol)
                {
                    MessageBox.Show("Deleted successfully");
                    Titlebox.Clear();
                    descriptionbox.Clear();
                    categoryidbox.Clear();
                    //code to refresh the data table
                    string searcher = "";

                    var found = from x in db.Categories
                        where x.Title.Contains(searcher) || x.Description.Contains(searcher)
                        select x;

                    categorydataGridView.DataSource = found.ToList().ToDataTable();
                }
            }
        }

        private void descriptionbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
