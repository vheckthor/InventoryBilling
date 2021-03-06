﻿using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using DataMangement.EF;
using InventoryAndBillingSystem.BusinessLogic;

namespace InventoryAndBillingSystem.UI
{
    public partial class PurchaseAndSalesForm : Form
    {
        public DataTable dataForTable;
        public int counter = 0;
        private decimal aCummulator = decimal.Zero;
        private bool tracker =false;
        private int CustomerId;

        public PurchaseAndSalesForm()
        {
            InitializeComponent();
            dataForTable = new DataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void productdetailshead_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchaseAndSalesForm_Load(object sender, EventArgs e)
        {
            //Action occurrence when the page loads
            purchasesalesLabel.Text = UserDashBoard.clickedValue;
            var columnKey = new DataColumn();
            var keys = new DataColumn[1];
            //columnKey.DataType = Type.GetType("System.int");
            columnKey.ColumnName = "S/N";
            dataForTable.Columns.Add(columnKey);
            keys[0] = columnKey;
            dataForTable.Columns.Add("Product Name");
            dataForTable.Columns.Add("Rate");
            dataForTable.Columns.Add("Quantity");
            dataForTable.Columns.Add("Total");
            dataForTable.PrimaryKey = keys;
            

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            string keyword = searchBox.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                nameBox.Clear();
                emailBox.Clear();
                addressBox.Clear();
                contactBox.Clear();
                return;
            }
            using (var db = new Model1())
            {
                var found = db.DealCustomers.FirstOrDefault(x =>
                    x.id.ToString().Contains(keyword) || x.Name.Contains(keyword)|| x.Email.Contains(keyword));



                if (found != null)
                {
                    nameBox.Text = found.Name;
                    emailBox.Text = found.Email;
                    addressBox.Text = found.Address;
                    contactBox.Text = found.Contact;
                    CustomerId = found.id;
                }


            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productName.Text))
            {
                MessageBox.Show("Product cannot be empty!!");
                return;
            }

            var product = productName.Text;
            
            var rate = decimal.Parse(productRate.Text);
            int quantity=0;
            if (int.TryParse(productQuantity.Text, out int value))
            {
                quantity = value;
            }

            var total = rate * quantity;

            
               var subTotal = total + decimal.Parse(subtotalbox.Text);
                subtotalbox.Text = subTotal.ToString();
            counter += 1;

            var entity = new
            {
                id=counter,
                product = product,
                rate = rate,
                quantity = quantity,
                total = total
            };

            dataForTable.Rows.Add(entity.id,
                entity.product,entity.rate,entity.quantity,entity.total);
            

            productadded.DataSource = dataForTable; 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = productSearchBpx.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                productName.Clear();
                productRate.Clear();
                productQuantity.Clear();
                productInventory.Clear();
                return;
            }

            using (var db = new Model1())
            {
                var found = db.Products.FirstOrDefault(x => x.id.ToString().Contains(keyword) ||
                                                            x.Name.Contains(keyword)  || x.Category.Contains(keyword) ||
                                                            x.Description.Contains(keyword));

                if (found != null)
                {
                    productName.Text = found.Name;
                    productInventory.Text = found.Quantity.ToString();
                    productRate.Text = found.Rate.ToString();

                }
            }

        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            dataForTable.Rows.Clear();
            aCummulator = Decimal.Zero;
            counter = 0;
            subtotalbox.Text="0.00";
            discountbox.Text = "0.00";
            vatbox.Text = "0.00";
            grandtotalbox.Text = "0.00";
            paidamountbox.Text = "0.00";
            returnamountbox.Text = "";
            tracker = false;


        }

        private void discountbox_TextChanged(object sender, EventArgs e)
        {
            string value = discountbox.Text;
            if (string.IsNullOrWhiteSpace(value))
            {
                discountbox.Text = "0.00";

            }
            else
            {
                var discount = decimal.TryParse(value, out decimal result);
                if (!discount)
                {
                    MessageBox.Show("the value of discount is incorrect");
                    return;
                }

                if (result > 100)
                {
                    MessageBox.Show("discount cannot be greater than 100%");
                    return;
                }

                var grandTotal = decimal.Parse(subtotalbox.Text);

                var discountPrice = (result/100) * grandTotal;

                var answer = grandTotal - discountPrice;
                aCummulator = answer;

                grandtotalbox.Text = answer.ToString("##.00");
                tracker = true;

            }
        }

        private void vatbox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(vatbox.Text))
            {
                vatbox.Text = "0.00";

            }
            var grand = grandtotalbox.Text;
            if (!tracker)
            {
                MessageBox.Show("Please Calculate discount first");
                return;
            }

            var vatValueChecker = decimal.TryParse(vatbox.Text, out decimal result);
            if (!vatValueChecker)
            {
                MessageBox.Show("Please enter a valid value for VAT");
                return;
            }

            if (result > 100)
            {
                MessageBox.Show("VAT cannot be greater than 100%");
                return;
            }


            var grandTotal = aCummulator;

            var vatValue = (result / 100) * grandTotal;
            var answer = grandTotal + vatValue;
            grandtotalbox.Text = answer.ToString("##.00");
            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            Mapper.CreateMap<TransactionDTO, Transaction>();
            Mapper.CreateMap<TransactionDetailDTO, TransactionDetail>();
            Mapper.CreateMap<PaymentDetailsDTO, PaymentDetail>();
            TransactionDTO transactionVales = new TransactionDTO();

            transactionVales.DealCustomerId = CustomerId;
            transactionVales.Type = purchasesalesLabel.Text;
            transactionVales.GrandTotal = decimal.Parse(grandtotalbox.Text);
            transactionVales.Discount = decimal.Parse(discountbox.Text);
            transactionVales.Tax =decimal.Parse(vatbox.Text);
            transactionVales.TransactionDate = billDatetimePicker.Value;
            var user = new UserDashBoard();

            var productIdentifier = 0;
           
            using (var db = new Model1())
            { 
                transactionVales.AddedBy = db.Users.FirstOrDefault(
                                            x => x.UserName == user.currentUser).id;
                

            }

            var mapped = Mapper.Map<Transaction>(transactionVales);

            var payments = new PaymentDetailsDTO();
            var saved = false;
            var transactionType = purchasesalesLabel.Text;



            using (var db = new Model1())
            {
                db.Transactions.Add(mapped);

                var transcationdetailsVales = new TransactionDetailDTO();
                for(int i=0; i< dataForTable.Rows.Count; i++)
                {
                    var name = dataForTable.Rows[i][1].ToString();
                    productIdentifier = db.Products.FirstOrDefault(
                        x => x.Name == name).id;

                    transcationdetailsVales.ProductId = productIdentifier;
                    transcationdetailsVales.AddedDate=DateTime.Now;
                    transcationdetailsVales.DealCustomerId = CustomerId;
                    transcationdetailsVales.Rate = decimal.Parse(dataForTable.Rows[i][2].ToString());
                    transcationdetailsVales.Quantity = decimal.Parse(dataForTable.Rows[i][3].ToString());
                    transcationdetailsVales.Total = decimal.Parse(dataForTable.Rows[i][4].ToString());

                    var mapping = Mapper.Map<TransactionDetail>(transcationdetailsVales);
                    db.TransactionDetails.Add(mapping);


                    var answer = db.Products.FirstOrDefault(x => x.id == productIdentifier);
                    if (transactionType.ToLower() == "sales")
                    {
                        answer.Quantity = answer.Quantity - transcationdetailsVales.Quantity;
                        db.Products.AddOrUpdate(answer);
                    }
                    else if(transactionType.ToLower()=="purchase")
                    {
                        answer.Quantity = answer.Quantity + transcationdetailsVales.Quantity;
                        db.Products.AddOrUpdate(answer);
                    }

                }

                var saving =db.SaveChanges()>0;
                if (!saving)
                {
                    MessageBox.Show("An error occured cannot ");
                }
                var collector = db.Transactions.ToList().Last();
                payments.TransactionId = collector.Id;
                payments.AmountPaid = decimal.Parse(paidamountbox.Text);
                payments.BalanceorChange = decimal.Parse(returnamountbox.Text);
               // payments.Transaction = mapped;

                var paymentIntoDb = Mapper.Map<PaymentDetail>(payments);
                db.PaymentDetails.Add(paymentIntoDb);

                saved = db.SaveChanges() > 0;
            }

            if (saved)
            {
                MessageBox.Show("Transaction saved successfully");
                //printing the transaction.
                PrintTransaction();
            }
            else
            {
                MessageBox.Show("Error saving transactions");
            }
            clearTable_Click(sender,e);
            cleaner();

        }
        /// <summary>
        /// This method can be moved to its own class and cofigured that the values like company name email, phone number
        /// can be created from admin dash board
        /// </summary>
        private void PrintTransaction()
        {
            var printRecord = new DGVPrinter();
            printRecord.Title = "\r\n\r\n Better Store Nigeria Limited";
            printRecord.SubTitle = "\r\n No 32 Obange street Lekki Lagos \r\n 08135466998\r\n\r\n" 
                                   + "Discount: " + discountbox.Text + "% \r\n" + "VAT: " + vatbox.Text + "% \r\n"
                                   + "Grand Total: " + decimal.Parse(grandtotalbox.Text).ToString("C") + "\r\n"
                                   + "Paid Amount: " + decimal.Parse(paidamountbox.Text).ToString("C")
                                   + "\r\n"
                                   + "Return Change: " + decimal.Parse(returnamountbox.Text).ToString("C")
                                   + "\r\n\r\r\n";
            printRecord.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printRecord.PageNumbers = true;
            printRecord.PageNumberInHeader = false;
            printRecord.PorportionalColumns = true;
            printRecord.HeaderCellAlignment = StringAlignment.Near;
            printRecord.Footer = "Thank you for doing business with us.";
            printRecord.FooterSpacing = 250;

            printRecord.PrintPreviewDataGridView(productadded);
           // printRecord.PrintDataGridView(productadded);
        }

        private void purchasesalesLabel_Click(object sender, EventArgs e)
        {
            var randomColor = new Random();
            var randomize1 = randomColor.Next(0, 255);
            var randomize2 = randomColor.Next(0, 255);
            var randomize3 = randomColor.Next(0, 255);
            var genColor=Color.FromArgb(randomize1,randomize2,randomize3);
            purchasesalesLabel.ForeColor = genColor;



        }

        private void paidamountbox_TextChanged(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(paidamountbox.Text))
            {
                paidamountbox.Text = "0.00";

            }
            var converter = decimal.TryParse(paidamountbox.Text,out decimal result);
            if (!converter || (result<0))
            {
                MessageBox.Show("Please enter a valid amount paid");
            }
            var amountPaid = result;

            returnamountbox.Text = (amountPaid - decimal.Parse(grandtotalbox.Text)).ToString("##.000");
        }


        private void cleaner()
        {
            productQuantity.Clear();
            productName.Clear();
            productRate.Clear();
            productInventory.Clear();
            productSearchBpx.Clear();
            nameBox.Clear();
            emailBox.Clear();
            contactBox.Clear();
            addressBox.Clear();
            searchBox.Clear();

        }

        private void productQuantity_TextChanged(object sender, EventArgs e)
        {
            if (productQuantity.Text == "")
            {
                productQuantity.Text = "";
                return;
            }
            var converter = decimal.TryParse(productQuantity.Text,out decimal quantity);
            if (!converter)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            var transactionType = purchasesalesLabel;
            if (transactionType.Text == "sales")
            {
                if (decimal.Parse(productInventory.Text) < quantity)
                {
                    MessageBox.Show("Quantity cannot be greater than the amount in stock");
                    productQuantity.Clear();
                }
            }
        }
    }
}
