namespace InventoryAndBillingSystem
{
    partial class UserDashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBilling = new System.Windows.Forms.Label();
            this.labelStore1 = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesFormsToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1544, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(94, 30);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesFormsToolStripMenuItem
            // 
            this.salesFormsToolStripMenuItem.Name = "salesFormsToolStripMenuItem";
            this.salesFormsToolStripMenuItem.Size = new System.Drawing.Size(63, 30);
            this.salesFormsToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(99, 30);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // labelBilling
            // 
            this.labelBilling.AutoSize = true;
            this.labelBilling.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelBilling.Location = new System.Drawing.Point(891, 451);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(362, 36);
            this.labelBilling.TabIndex = 8;
            this.labelBilling.Text = "Billing and Inventory System";
            // 
            // labelStore1
            // 
            this.labelStore1.AutoSize = true;
            this.labelStore1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore1.Location = new System.Drawing.Point(1090, 407);
            this.labelStore1.Name = "labelStore1";
            this.labelStore1.Size = new System.Drawing.Size(119, 44);
            this.labelStore1.TabIndex = 7;
            this.labelStore1.Text = "Store";
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStore.ForeColor = System.Drawing.Color.Red;
            this.labelStore.Location = new System.Drawing.Point(889, 383);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(207, 45);
            this.labelStore.TabIndex = 6;
            this.labelStore.Text = "BETTER ";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 676);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1544, 43);
            this.panelFooter.TabIndex = 5;
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
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(26, 86);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(52, 23);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(84, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 17);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Victor";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 719);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelBilling);
            this.Controls.Add(this.labelStore1);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label labelBilling;
        private System.Windows.Forms.Label labelStore1;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelName;
    }
}