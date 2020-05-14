using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class TransactionForm : Form
    {
        private DataTable dataTableTranscation;

        public TransactionForm()
        {
            InitializeComponent();
            dataTableTranscation = new DataTable(); 
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            Mapper.CreateMap<Transaction, TransactionDataDTO>();
            using (var db = new Model1())
            {
                var transactionData = db.Transactions.ToList();
               var transactionDataDTO = Mapper.Map<List<TransactionDataDTO>>(transactionData);


                dataTableTranscation = transactionDataDTO.ToDataTable();
                transactiondataGridView.DataSource = dataTableTranscation;

            }
        }

        private void transactioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mapper.CreateMap<Transaction, TransactionDataDTO>();
            var valueType = transactioncomboBox.SelectedItem.ToString().ToLower();
            using (var db = new Model1())
            {
                var dataSortList = db.Transactions.Where(x => x.Type.ToLower() == valueType).ToList();
                var mappedDataSortList = Mapper.Map<List<TransactionDataDTO>>(dataSortList);

                dataTableTranscation = mappedDataSortList.ToDataTable();
                transactiondataGridView.DataSource = dataTableTranscation;
            }
        }

        private void showallButton_Click(object sender, EventArgs e)
        {
            TransactionForm_Load(sender,e);
        }
    }
}
