namespace InventoryAndBillingSystem.UI
{
    partial class ProductFormcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFormcs));
            this.productdataGridView = new System.Windows.Forms.DataGridView();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.productIDbox = new System.Windows.Forms.TextBox();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.ratelbl = new System.Windows.Forms.Label();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.quantitylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productdataGridView
            // 
            this.productdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdataGridView.Location = new System.Drawing.Point(485, 130);
            this.productdataGridView.Name = "productdataGridView";
            this.productdataGridView.RowHeadersWidth = 51;
            this.productdataGridView.RowTemplate.Height = 24;
            this.productdataGridView.Size = new System.Drawing.Size(523, 357);
            this.productdataGridView.TabIndex = 26;
            this.productdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productdataGridView_RowHeaderMouseClick);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(559, 82);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(347, 31);
            this.searchbox.TabIndex = 25;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlbl.Location = new System.Drawing.Point(480, 87);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(73, 26);
            this.searchlbl.TabIndex = 24;
            this.searchlbl.Text = "Search";
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Crimson;
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.deletebutton.Location = new System.Drawing.Point(689, 512);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(148, 54);
            this.deletebutton.TabIndex = 23;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.CadetBlue;
            this.updatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatebutton.Location = new System.Drawing.Point(448, 512);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(148, 54);
            this.updatebutton.TabIndex = 22;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.OliveDrab;
            this.Addbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.Cornsilk;
            this.Addbutton.Location = new System.Drawing.Point(207, 512);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(148, 54);
            this.Addbutton.TabIndex = 21;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // productIDbox
            // 
            this.productIDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDbox.Location = new System.Drawing.Point(204, 105);
            this.productIDbox.Name = "productIDbox";
            this.productIDbox.ReadOnly = true;
            this.productIDbox.Size = new System.Drawing.Size(218, 30);
            this.productIDbox.TabIndex = 20;
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(23, 101);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(105, 26);
            this.Categorylbl.TabIndex = 19;
            this.Categorylbl.Text = "Product ID";
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(204, 338);
            this.descriptionbox.Multiline = true;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(218, 79);
            this.descriptionbox.TabIndex = 18;
            // 
            // Namebox
            // 
            this.Namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namebox.Location = new System.Drawing.Point(204, 170);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(218, 30);
            this.Namebox.TabIndex = 17;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlbl.Location = new System.Drawing.Point(23, 338);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(114, 26);
            this.descriptionlbl.TabIndex = 16;
            this.descriptionlbl.Text = "Description";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(23, 170);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(64, 26);
            this.namelbl.TabIndex = 15;
            this.namelbl.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.productlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 48);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(979, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1264, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // productlbl
            // 
            this.productlbl.AutoSize = true;
            this.productlbl.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.productlbl.Location = new System.Drawing.Point(451, 9);
            this.productlbl.Name = "productlbl";
            this.productlbl.Size = new System.Drawing.Size(102, 29);
            this.productlbl.TabIndex = 1;
            this.productlbl.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category";
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorycomboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(204, 230);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(218, 33);
            this.CategorycomboBox.TabIndex = 29;
            this.CategorycomboBox.Text = "Select Category";
            // 
            // RateBox
            // 
            this.RateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateBox.Location = new System.Drawing.Point(204, 455);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(218, 30);
            this.RateBox.TabIndex = 31;
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratelbl.Location = new System.Drawing.Point(23, 455);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(54, 26);
            this.ratelbl.TabIndex = 30;
            this.ratelbl.Text = "Rate";
            this.ratelbl.Click += new System.EventHandler(this.ratelbl_Click);
            // 
            // quantitybox
            // 
            this.quantitybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitybox.Location = new System.Drawing.Point(207, 288);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(218, 30);
            this.quantitybox.TabIndex = 33;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.Location = new System.Drawing.Point(26, 288);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(91, 26);
            this.quantitylbl.TabIndex = 32;
            this.quantitylbl.Text = "Quantity";
            // 
            // ProductFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1030, 594);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.quantitylbl);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.ratelbl);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productdataGridView);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.productIDbox);
            this.Controls.Add(this.Categorylbl);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductFormcs_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductFormcs_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.productdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productdataGridView;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox productIDbox;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.Label ratelbl;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label quantitylbl;
    }
}