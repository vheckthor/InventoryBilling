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
    public partial class InventoryForm : Form
    {
        private DataTable datatableCategory;

        public InventoryForm()
        {
            InitializeComponent();
            datatableCategory = new DataTable();

        }

        private void TransctionTypelabel_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            Mapper.CreateMap<Product, InventoryDTO>();
            using (var db = new Model1())
            {
                var getCategoryName = db.Categories.Select(x => x.Title);
                inventorycomboBox.DataSource = getCategoryName.ToList();


                var categoryValues = db.Products.ToList();
                var mappedcategoryValues = Mapper.Map<List<InventoryDTO>>(categoryValues);
                var counter = 1;
                mappedcategoryValues.ForEach(
                    
                    x=>x.SerialNumber=counter++);

                datatableCategory = mappedcategoryValues.ToDataTable();
                inventorydataGridView.DataSource = datatableCategory;

            }
        }

        private void inventorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mapper.CreateMap<Product, InventoryDTO>();
            var selection = inventorycomboBox.SelectedItem.ToString();
            using (var db = new Model1())
            {
                var sorted = db.Products.Where(x => x.Category == selection).ToList();
                var mappedsorted = Mapper.Map<List<InventoryDTO>>(sorted);

                
                mappedsorted.ForEach(

                    x => x.SerialNumber = mappedsorted.IndexOf(x)+1);

                datatableCategory = mappedsorted.ToDataTable();
                inventorydataGridView.DataSource = datatableCategory;
            }

        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            InventoryForm_Load(sender,e);
        }
    }
}
