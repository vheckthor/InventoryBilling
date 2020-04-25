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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<ProductDTO, Product>();
            ProductDTO createProductDto = new ProductDTO();
            try
            {
                
                decimal value = 0.0M;
                var rest = decimal.TryParse(quantitybox.Text, out value);
                if (!rest)
                {
                    MessageBox.Show("Quantity value is incorrect");
                    return;
                }

                int result = 0;
                var sol = int.TryParse(RateBox.Text,out result);
               
                if (!sol)
                {
                    MessageBox.Show("Rate value is incorrect");
                    return;
                }

                createProductDto.Description = descriptionbox.Text;
                createProductDto.Name = Namebox.Text;
                createProductDto.Quantity = value;
                createProductDto.Addedby = userID;
                createProductDto.AddedDate=DateTime.Now;
                createProductDto.Rate = result;
                createProductDto.Category = CategorycomboBox.Text;

                if
                (
                    string.IsNullOrWhiteSpace(createProductDto.Description) ||
                    string.IsNullOrWhiteSpace(createProductDto.Name) ||
                    string.IsNullOrWhiteSpace(createProductDto.Category)
                )
                {
                    MessageBox.Show("Input value cannot be empty or whitespaces");
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured please try again");
            }


            var product = Mapper.Map<ProductDTO, Product>(createProductDto);
            using (var db = new Model1())
            {
                var val = db.Products.FirstOrDefault(c => c.Name.ToLower() == product.Name.ToLower());

                if (val != null)
                {
                    MessageBox.Show("Product already exist");
                    return;
                }
                db.Products.Add(product);
                var added = db.SaveChanges()>0;
                if (added)
                {
                    MessageBox.Show("Product added successfully");
                    descriptionbox.Clear();
                    RateBox.Clear();
                    quantitybox.Clear();
                    Namebox.Clear();
                    var prod =  db.Products.ToList();
                      

                    productdataGridView.DataSource = prod.ToDataTable();

                }
            }
        }

        //private void ProductFormcs_Load(object sender, EventArgs e)
        //{
        //    using (var db = new Model1())
        //    {
        //        var category = db.Categories.ToList();


        //        CategorycomboBox.DataSource = category.ToDataTable();
        //        CategorycomboBox.DisplayMember = "Title";
        //        CategorycomboBox.ValueMember = "Title";


        //        var product = db.Products.ToList();

        //        productdataGridView.DataSource = product.ToDataTable();
        //    }
        //}

        private void updatebutton_Click(object sender, EventArgs e)
        {
            Mapper.CreateMap<ProductDTO, Product>();
            ProductDTO createProductDto = new ProductDTO();
            try
            {

                decimal value = 0.0M;
                var rest = decimal.TryParse(quantitybox.Text, out value);
                if (!rest)
                {
                    MessageBox.Show("Quantity value is incorrect");
                    return;
                }

                int result = 0;
                var sol = int.TryParse(RateBox.Text, out result);

                if (!sol)
                {
                    MessageBox.Show("Rate value is incorrect");
                    return;
                }

                createProductDto.Description = descriptionbox.Text;
                createProductDto.Name = Namebox.Text;
                createProductDto.Quantity = value;
                createProductDto.Addedby = userID;
                createProductDto.AddedDate = DateTime.Now;
                createProductDto.Rate = result;
                createProductDto.Category = CategorycomboBox.Text;

                if
                (
                    string.IsNullOrWhiteSpace(createProductDto.Description) ||
                    string.IsNullOrWhiteSpace(createProductDto.Name) ||
                    string.IsNullOrWhiteSpace(createProductDto.Category)
                )
                {
                    MessageBox.Show("Input value cannot be empty or whitespaces");
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured please try again");
            }


            var product = Mapper.Map<ProductDTO, Product>(createProductDto);

            var id = productIDbox.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID cannot be empty");
                return;
            }
            product.id = int.Parse(id);

            using (var db = new Model1())
            {
                db.Products.AddOrUpdate(product);
                var added = db.SaveChanges() > 0;
                if (added)
                {
                    MessageBox.Show("Product Updated successfully");
                    descriptionbox.Clear();
                    RateBox.Clear();
                    productIDbox.Clear();
                    quantitybox.Clear();
                    Namebox.Clear();
                    var prod = db.Products.ToList();


                    productdataGridView.DataSource = prod.ToDataTable();

                }
            }
        }

        private void ProductFormcs_Load(object sender, EventArgs e)
        {

            using (var db = new Model1())
            {
                var category = db.Categories.ToList();


                CategorycomboBox.DataSource = category.ToDataTable();
                CategorycomboBox.DisplayMember = "Title";
                CategorycomboBox.ValueMember = "Title";


                var product = db.Products.ToList();

                productdataGridView.DataSource = product.ToDataTable();
                searchbox.Clear();
                productIDbox.Clear();
                Namebox.Clear();
                descriptionbox.Clear();
                quantitybox.Clear();
                RateBox.Clear();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var idstring = productIDbox.Text;
                if (string.IsNullOrWhiteSpace(idstring))
                {
                    MessageBox.Show("No Values has been selected for deleting");

                    return;
                }
                var id = int.Parse(idstring);
                var category = db.Products.FirstOrDefault(x => x.id == id);

                db.Products.Remove(category);
                var sol = db.SaveChanges() > 0;
                if (sol)
                {
                    MessageBox.Show("Deleted successfully");
                    RateBox.Clear();
                    descriptionbox.Clear();
                    productIDbox.Clear();
                    quantitybox.Clear();
                    Namebox.Clear();
                    
                    //code to refresh the data table

                    var found = db.Products.ToList();

                    productdataGridView.DataSource = found.ToDataTable();
                }
            }
        }

        private void productdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowIndex = e.RowIndex;
            productIDbox.Text=productdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Namebox.Text = productdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            descriptionbox.Text = productdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            RateBox.Text = productdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            quantitybox.Text = productdataGridView.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                var content = searchbox.Text;
                var returner = from x in db.Products
                    where x.Name.Contains(content) || x.Description.Contains(content)
                    select x;

                productdataGridView.DataSource = returner.ToList().ToDataTable();
            }
        }

        private void ProductFormcs_MouseClick(object sender, MouseEventArgs e)
        {
            ProductFormcs_Load(sender,e);
        }
    }
}
