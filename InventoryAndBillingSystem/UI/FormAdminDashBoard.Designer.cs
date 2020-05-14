namespace InventoryAndBillingSystem
{
    partial class FormAdminDashBoard
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
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerAndCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStore = new System.Windows.Forms.Label();
            this.labelStore1 = new System.Windows.Forms.Label();
            this.labelBilling = new System.Windows.Forms.Label();
            this.Adminlbl = new System.Windows.Forms.Label();
            this.adminuser = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 564);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1542, 43);
            this.panelFooter.TabIndex = 0;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFooter.Location = new System.Drawing.Point(663, 17);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(278, 25);
            this.labelFooter.TabIndex = 1;
            this.labelFooter.Text = "Developed by Vheckthor-Drey";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.dealerAndCustomerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1542, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(66, 30);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(94, 30);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(93, 30);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // dealerAndCustomerToolStripMenuItem
            // 
            this.dealerAndCustomerToolStripMenuItem.Name = "dealerAndCustomerToolStripMenuItem";
            this.dealerAndCustomerToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.dealerAndCustomerToolStripMenuItem.Text = "Dealer and Customer";
            this.dealerAndCustomerToolStripMenuItem.Click += new System.EventHandler(this.dealerAndCustomerToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(99, 30);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.ForeColor = System.Drawing.Color.Red;
            this.labelStore.Location = new System.Drawing.Point(745, 340);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(207, 45);
            this.labelStore.TabIndex = 2;
            this.labelStore.Text = "BETTER ";
            // 
            // labelStore1
            // 
            this.labelStore1.AutoSize = true;
            this.labelStore1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore1.Location = new System.Drawing.Point(946, 364);
            this.labelStore1.Name = "labelStore1";
            this.labelStore1.Size = new System.Drawing.Size(119, 44);
            this.labelStore1.TabIndex = 3;
            this.labelStore1.Text = "Store";
            // 
            // labelBilling
            // 
            this.labelBilling.AutoSize = true;
            this.labelBilling.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelBilling.Location = new System.Drawing.Point(747, 408);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(362, 36);
            this.labelBilling.TabIndex = 4;
            this.labelBilling.Text = "Billing and Inventory System";
            this.labelBilling.Click += new System.EventHandler(this.labelBilling_Click);
            // 
            // Adminlbl
            // 
            this.Adminlbl.AutoSize = true;
            this.Adminlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminlbl.Location = new System.Drawing.Point(13, 85);
            this.Adminlbl.Name = "Adminlbl";
            this.Adminlbl.Size = new System.Drawing.Size(88, 25);
            this.Adminlbl.TabIndex = 5;
            this.Adminlbl.Text = "ADMIN:";
            // 
            // adminuser
            // 
            this.adminuser.AutoSize = true;
            this.adminuser.Location = new System.Drawing.Point(119, 92);
            this.adminuser.Name = "adminuser";
            this.adminuser.Size = new System.Drawing.Size(51, 17);
            this.adminuser.TabIndex = 6;
            this.adminuser.Text = "ADMIN";
            this.adminuser.Click += new System.EventHandler(this.adminuser_Click);
            // 
            // FormAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 607);
            this.Controls.Add(this.adminuser);
            this.Controls.Add(this.Adminlbl);
            this.Controls.Add(this.labelBilling);
            this.Controls.Add(this.labelStore1);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.FormAdminDashBoard_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labelStore1;
        private System.Windows.Forms.Label labelBilling;
        private System.Windows.Forms.Label Adminlbl;
        private System.Windows.Forms.Label adminuser;
        private System.Windows.Forms.ToolStripMenuItem dealerAndCustomerToolStripMenuItem;
    }
}

