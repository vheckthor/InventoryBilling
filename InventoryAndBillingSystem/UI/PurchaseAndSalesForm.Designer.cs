namespace InventoryAndBillingSystem.UI
{
    partial class PurchaseAndSalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseAndSalesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchasesalesLabel = new System.Windows.Forms.Label();
            this.panelboxDealerandCustomer = new System.Windows.Forms.Panel();
            this.billDatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.billdate = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.Contactlabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.productRate = new System.Windows.Forms.TextBox();
            this.ratelbl = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.Label();
            this.productInventory = new System.Windows.Forms.TextBox();
            this.inventorylbl = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.productSearchBpx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productdetailshead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearTable = new System.Windows.Forms.Button();
            this.addedProduct = new System.Windows.Forms.Label();
            this.productadded = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.savebtn = new System.Windows.Forms.Button();
            this.returnamountbox = new System.Windows.Forms.TextBox();
            this.paidamountbox = new System.Windows.Forms.TextBox();
            this.grandtotalbox = new System.Windows.Forms.TextBox();
            this.vatbox = new System.Windows.Forms.TextBox();
            this.discountbox = new System.Windows.Forms.TextBox();
            this.subtotalbox = new System.Windows.Forms.TextBox();
            this.returnAmount = new System.Windows.Forms.Label();
            this.paidtotal = new System.Windows.Forms.Label();
            this.grandtotallbl = new System.Windows.Forms.Label();
            this.vatlbl = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.subtotallbl = new System.Windows.Forms.Label();
            this.calculateddetails = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelboxDealerandCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productadded)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.purchasesalesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 43);
            this.panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1369, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // purchasesalesLabel
            // 
            this.purchasesalesLabel.AutoSize = true;
            this.purchasesalesLabel.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasesalesLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.purchasesalesLabel.Location = new System.Drawing.Point(564, 9);
            this.purchasesalesLabel.Name = "purchasesalesLabel";
            this.purchasesalesLabel.Size = new System.Drawing.Size(227, 29);
            this.purchasesalesLabel.TabIndex = 1;
            this.purchasesalesLabel.Text = "Purchase and Sales";
            this.purchasesalesLabel.Click += new System.EventHandler(this.purchasesalesLabel_Click);
            // 
            // panelboxDealerandCustomer
            // 
            this.panelboxDealerandCustomer.Controls.Add(this.billDatetimePicker);
            this.panelboxDealerandCustomer.Controls.Add(this.addressBox);
            this.panelboxDealerandCustomer.Controls.Add(this.contactBox);
            this.panelboxDealerandCustomer.Controls.Add(this.emailBox);
            this.panelboxDealerandCustomer.Controls.Add(this.nameBox);
            this.panelboxDealerandCustomer.Controls.Add(this.searchBox);
            this.panelboxDealerandCustomer.Controls.Add(this.billdate);
            this.panelboxDealerandCustomer.Controls.Add(this.addresslabel);
            this.panelboxDealerandCustomer.Controls.Add(this.Contactlabel);
            this.panelboxDealerandCustomer.Controls.Add(this.Emaillabel);
            this.panelboxDealerandCustomer.Controls.Add(this.Namelabel);
            this.panelboxDealerandCustomer.Controls.Add(this.Searchlabel);
            this.panelboxDealerandCustomer.Controls.Add(this.label1);
            this.panelboxDealerandCustomer.Location = new System.Drawing.Point(13, 63);
            this.panelboxDealerandCustomer.Name = "panelboxDealerandCustomer";
            this.panelboxDealerandCustomer.Size = new System.Drawing.Size(1399, 145);
            this.panelboxDealerandCustomer.TabIndex = 40;
            // 
            // billDatetimePicker
            // 
            this.billDatetimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDatetimePicker.Location = new System.Drawing.Point(1072, 50);
            this.billDatetimePicker.Name = "billDatetimePicker";
            this.billDatetimePicker.Size = new System.Drawing.Size(311, 30);
            this.billDatetimePicker.TabIndex = 13;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(749, 47);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(218, 84);
            this.addressBox.TabIndex = 11;
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(413, 103);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(248, 30);
            this.contactBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(413, 47);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(248, 30);
            this.emailBox.TabIndex = 9;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(94, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(218, 30);
            this.nameBox.TabIndex = 8;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(94, 52);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(218, 30);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // billdate
            // 
            this.billdate.AutoSize = true;
            this.billdate.Location = new System.Drawing.Point(983, 50);
            this.billdate.Name = "billdate";
            this.billdate.Size = new System.Drawing.Size(83, 25);
            this.billdate.TabIndex = 6;
            this.billdate.Text = "Bill Date";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(667, 50);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(85, 25);
            this.addresslabel.TabIndex = 5;
            this.addresslabel.Text = "Address";
            // 
            // Contactlabel
            // 
            this.Contactlabel.AutoSize = true;
            this.Contactlabel.Location = new System.Drawing.Point(327, 106);
            this.Contactlabel.Name = "Contactlabel";
            this.Contactlabel.Size = new System.Drawing.Size(80, 25);
            this.Contactlabel.TabIndex = 4;
            this.Contactlabel.Text = "Contact";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(327, 52);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(60, 25);
            this.Emaillabel.TabIndex = 3;
            this.Emaillabel.Text = "Email";
            this.Emaillabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(13, 101);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(64, 25);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Location = new System.Drawing.Point(13, 53);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(75, 25);
            this.Searchlabel.TabIndex = 1;
            this.Searchlabel.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer and Customer Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.productRate);
            this.panel2.Controls.Add(this.ratelbl);
            this.panel2.Controls.Add(this.productQuantity);
            this.panel2.Controls.Add(this.Qty);
            this.panel2.Controls.Add(this.productInventory);
            this.panel2.Controls.Add(this.inventorylbl);
            this.panel2.Controls.Add(this.productName);
            this.panel2.Controls.Add(this.namelbl);
            this.panel2.Controls.Add(this.productSearchBpx);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.productdetailshead);
            this.panel2.Location = new System.Drawing.Point(13, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1399, 100);
            this.panel2.TabIndex = 41;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.CausesValidation = false;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.SeaShell;
            this.addButton.Location = new System.Drawing.Point(1235, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 56);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productRate
            // 
            this.productRate.Location = new System.Drawing.Point(520, 58);
            this.productRate.Name = "productRate";
            this.productRate.Size = new System.Drawing.Size(169, 30);
            this.productRate.TabIndex = 10;
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Location = new System.Drawing.Point(462, 63);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(52, 25);
            this.ratelbl.TabIndex = 9;
            this.ratelbl.Text = "Rate";
            // 
            // productQuantity
            // 
            this.productQuantity.Location = new System.Drawing.Point(1032, 60);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(163, 30);
            this.productQuantity.TabIndex = 8;
            this.productQuantity.TextChanged += new System.EventHandler(this.productQuantity_TextChanged);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(983, 63);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(43, 25);
            this.Qty.TabIndex = 7;
            this.Qty.Text = "Qty";
            // 
            // productInventory
            // 
            this.productInventory.Location = new System.Drawing.Point(798, 60);
            this.productInventory.Name = "productInventory";
            this.productInventory.Size = new System.Drawing.Size(169, 30);
            this.productInventory.TabIndex = 6;
            // 
            // inventorylbl
            // 
            this.inventorylbl.AutoSize = true;
            this.inventorylbl.Location = new System.Drawing.Point(700, 65);
            this.inventorylbl.Name = "inventorylbl";
            this.inventorylbl.Size = new System.Drawing.Size(92, 25);
            this.inventorylbl.TabIndex = 5;
            this.inventorylbl.Text = "Inventory";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(308, 60);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(146, 30);
            this.productName.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(238, 63);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(64, 25);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
            // 
            // productSearchBpx
            // 
            this.productSearchBpx.Location = new System.Drawing.Point(105, 60);
            this.productSearchBpx.Name = "productSearchBpx";
            this.productSearchBpx.Size = new System.Drawing.Size(125, 30);
            this.productSearchBpx.TabIndex = 2;
            this.productSearchBpx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search";
            // 
            // productdetailshead
            // 
            this.productdetailshead.AutoSize = true;
            this.productdetailshead.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productdetailshead.Location = new System.Drawing.Point(13, 9);
            this.productdetailshead.Name = "productdetailshead";
            this.productdetailshead.Size = new System.Drawing.Size(164, 28);
            this.productdetailshead.TabIndex = 0;
            this.productdetailshead.Text = "Product Details";
            this.productdetailshead.Click += new System.EventHandler(this.productdetailshead_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearTable);
            this.panel3.Controls.Add(this.addedProduct);
            this.panel3.Controls.Add(this.productadded);
            this.panel3.Location = new System.Drawing.Point(13, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 438);
            this.panel3.TabIndex = 42;
            // 
            // clearTable
            // 
            this.clearTable.BackColor = System.Drawing.Color.OrangeRed;
            this.clearTable.FlatAppearance.BorderSize = 0;
            this.clearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearTable.Location = new System.Drawing.Point(564, 3);
            this.clearTable.Name = "clearTable";
            this.clearTable.Size = new System.Drawing.Size(109, 35);
            this.clearTable.TabIndex = 44;
            this.clearTable.TabStop = false;
            this.clearTable.Text = "Clear";
            this.clearTable.UseVisualStyleBackColor = false;
            this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // addedProduct
            // 
            this.addedProduct.AutoSize = true;
            this.addedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedProduct.Location = new System.Drawing.Point(24, 9);
            this.addedProduct.Name = "addedProduct";
            this.addedProduct.Size = new System.Drawing.Size(199, 29);
            this.addedProduct.TabIndex = 1;
            this.addedProduct.Text = "Added Products";
            // 
            // productadded
            // 
            this.productadded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productadded.Location = new System.Drawing.Point(18, 47);
            this.productadded.Name = "productadded";
            this.productadded.RowHeadersWidth = 51;
            this.productadded.RowTemplate.Height = 24;
            this.productadded.Size = new System.Drawing.Size(655, 381);
            this.productadded.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.savebtn);
            this.panel4.Controls.Add(this.returnamountbox);
            this.panel4.Controls.Add(this.paidamountbox);
            this.panel4.Controls.Add(this.grandtotalbox);
            this.panel4.Controls.Add(this.vatbox);
            this.panel4.Controls.Add(this.discountbox);
            this.panel4.Controls.Add(this.subtotalbox);
            this.panel4.Controls.Add(this.returnAmount);
            this.panel4.Controls.Add(this.paidtotal);
            this.panel4.Controls.Add(this.grandtotallbl);
            this.panel4.Controls.Add(this.vatlbl);
            this.panel4.Controls.Add(this.discount);
            this.panel4.Controls.Add(this.subtotallbl);
            this.panel4.Controls.Add(this.calculateddetails);
            this.panel4.Location = new System.Drawing.Point(718, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(694, 438);
            this.panel4.TabIndex = 43;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Teal;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebtn.Location = new System.Drawing.Point(273, 383);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(270, 45);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // returnamountbox
            // 
            this.returnamountbox.Location = new System.Drawing.Point(170, 298);
            this.returnamountbox.Multiline = true;
            this.returnamountbox.Name = "returnamountbox";
            this.returnamountbox.Size = new System.Drawing.Size(479, 79);
            this.returnamountbox.TabIndex = 14;
            // 
            // paidamountbox
            // 
            this.paidamountbox.Location = new System.Drawing.Point(170, 246);
            this.paidamountbox.Name = "paidamountbox";
            this.paidamountbox.Size = new System.Drawing.Size(479, 30);
            this.paidamountbox.TabIndex = 13;
            this.paidamountbox.Text = "0.00";
            this.paidamountbox.TextChanged += new System.EventHandler(this.paidamountbox_TextChanged);
            // 
            // grandtotalbox
            // 
            this.grandtotalbox.Location = new System.Drawing.Point(170, 203);
            this.grandtotalbox.Name = "grandtotalbox";
            this.grandtotalbox.ReadOnly = true;
            this.grandtotalbox.Size = new System.Drawing.Size(479, 30);
            this.grandtotalbox.TabIndex = 12;
            this.grandtotalbox.Text = "0.00";
            // 
            // vatbox
            // 
            this.vatbox.Location = new System.Drawing.Point(170, 157);
            this.vatbox.Name = "vatbox";
            this.vatbox.Size = new System.Drawing.Size(479, 30);
            this.vatbox.TabIndex = 11;
            this.vatbox.Text = "0.00";
            this.vatbox.TextChanged += new System.EventHandler(this.vatbox_TextChanged);
            // 
            // discountbox
            // 
            this.discountbox.Location = new System.Drawing.Point(170, 108);
            this.discountbox.Name = "discountbox";
            this.discountbox.Size = new System.Drawing.Size(479, 30);
            this.discountbox.TabIndex = 10;
            this.discountbox.Text = "0.00";
            this.discountbox.TextChanged += new System.EventHandler(this.discountbox_TextChanged);
            // 
            // subtotalbox
            // 
            this.subtotalbox.Location = new System.Drawing.Point(170, 60);
            this.subtotalbox.Name = "subtotalbox";
            this.subtotalbox.ReadOnly = true;
            this.subtotalbox.Size = new System.Drawing.Size(479, 30);
            this.subtotalbox.TabIndex = 9;
            this.subtotalbox.Text = "0.00";
            // 
            // returnAmount
            // 
            this.returnAmount.AutoSize = true;
            this.returnAmount.Location = new System.Drawing.Point(12, 298);
            this.returnAmount.Name = "returnAmount";
            this.returnAmount.Size = new System.Drawing.Size(142, 25);
            this.returnAmount.TabIndex = 8;
            this.returnAmount.Text = "Return Amount";
            // 
            // paidtotal
            // 
            this.paidtotal.AutoSize = true;
            this.paidtotal.Location = new System.Drawing.Point(12, 249);
            this.paidtotal.Name = "paidtotal";
            this.paidtotal.Size = new System.Drawing.Size(124, 25);
            this.paidtotal.TabIndex = 7;
            this.paidtotal.Text = "Paid Amount";
            // 
            // grandtotallbl
            // 
            this.grandtotallbl.AutoSize = true;
            this.grandtotallbl.Location = new System.Drawing.Point(16, 203);
            this.grandtotallbl.Name = "grandtotallbl";
            this.grandtotallbl.Size = new System.Drawing.Size(115, 25);
            this.grandtotallbl.TabIndex = 6;
            this.grandtotallbl.Text = "Grand Total";
            // 
            // vatlbl
            // 
            this.vatlbl.AutoSize = true;
            this.vatlbl.Location = new System.Drawing.Point(16, 157);
            this.vatlbl.Name = "vatlbl";
            this.vatlbl.Size = new System.Drawing.Size(90, 25);
            this.vatlbl.TabIndex = 5;
            this.vatlbl.Text = "VAT (%)";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(16, 108);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(125, 25);
            this.discount.TabIndex = 4;
            this.discount.Text = "Discount (%)";
            // 
            // subtotallbl
            // 
            this.subtotallbl.AutoSize = true;
            this.subtotallbl.Location = new System.Drawing.Point(16, 60);
            this.subtotallbl.Name = "subtotallbl";
            this.subtotallbl.Size = new System.Drawing.Size(97, 25);
            this.subtotallbl.TabIndex = 3;
            this.subtotallbl.Text = "Sub Total";
            // 
            // calculateddetails
            // 
            this.calculateddetails.AutoSize = true;
            this.calculateddetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateddetails.Location = new System.Drawing.Point(12, 9);
            this.calculateddetails.Name = "calculateddetails";
            this.calculateddetails.Size = new System.Drawing.Size(225, 29);
            this.calculateddetails.TabIndex = 2;
            this.calculateddetails.Text = "Calculated Details";
            // 
            // PurchaseAndSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1424, 813);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelboxDealerandCustomer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PurchaseAndSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseAndSalesForm";
            this.Load += new System.EventHandler(this.PurchaseAndSalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelboxDealerandCustomer.ResumeLayout(false);
            this.panelboxDealerandCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productadded)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label purchasesalesLabel;
        private System.Windows.Forms.Panel panelboxDealerandCustomer;
        private System.Windows.Forms.Label billdate;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label Contactlabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker billDatetimePicker;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productdetailshead;
        private System.Windows.Forms.TextBox productRate;
        private System.Windows.Forms.Label ratelbl;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.TextBox productInventory;
        private System.Windows.Forms.Label inventorylbl;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox productSearchBpx;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label addedProduct;
        private System.Windows.Forms.DataGridView productadded;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox returnamountbox;
        private System.Windows.Forms.TextBox paidamountbox;
        private System.Windows.Forms.TextBox grandtotalbox;
        private System.Windows.Forms.TextBox vatbox;
        private System.Windows.Forms.TextBox discountbox;
        private System.Windows.Forms.TextBox subtotalbox;
        private System.Windows.Forms.Label returnAmount;
        private System.Windows.Forms.Label paidtotal;
        private System.Windows.Forms.Label grandtotallbl;
        private System.Windows.Forms.Label vatlbl;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label subtotallbl;
        private System.Windows.Forms.Label calculateddetails;
        private System.Windows.Forms.Button clearTable;
    }
}