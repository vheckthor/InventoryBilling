namespace InventoryAndBillingSystem.UI
{
    partial class InventoryForm
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
            this.showallButton = new System.Windows.Forms.Button();
            this.inventorycomboBox = new System.Windows.Forms.ComboBox();
            this.categorylabel = new System.Windows.Forms.Label();
            this.inventorydataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showallButton
            // 
            this.showallButton.BackColor = System.Drawing.Color.LightCyan;
            this.showallButton.FlatAppearance.BorderSize = 0;
            this.showallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.showallButton.Location = new System.Drawing.Point(1022, 79);
            this.showallButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(287, 60);
            this.showallButton.TabIndex = 8;
            this.showallButton.Text = "Show All";
            this.showallButton.UseVisualStyleBackColor = false;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // inventorycomboBox
            // 
            this.inventorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inventorycomboBox.FormattingEnabled = true;
            this.inventorycomboBox.Location = new System.Drawing.Point(198, 97);
            this.inventorycomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventorycomboBox.Name = "inventorycomboBox";
            this.inventorycomboBox.Size = new System.Drawing.Size(634, 33);
            this.inventorycomboBox.TabIndex = 7;
            this.inventorycomboBox.Text = "Choose Category";
            this.inventorycomboBox.SelectedIndexChanged += new System.EventHandler(this.inventorycomboBox_SelectedIndexChanged);
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel.Location = new System.Drawing.Point(42, 100);
            this.categorylabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(92, 25);
            this.categorylabel.TabIndex = 6;
            this.categorylabel.Text = "Category";
            this.categorylabel.Click += new System.EventHandler(this.TransctionTypelabel_Click);
            // 
            // inventorydataGridView
            // 
            this.inventorydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorydataGridView.Location = new System.Drawing.Point(15, 211);
            this.inventorydataGridView.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.inventorydataGridView.Name = "inventorydataGridView";
            this.inventorydataGridView.RowHeadersWidth = 51;
            this.inventorydataGridView.RowTemplate.Height = 24;
            this.inventorydataGridView.Size = new System.Drawing.Size(1409, 526);
            this.inventorydataGridView.TabIndex = 5;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 754);
            this.Controls.Add(this.showallButton);
            this.Controls.Add(this.inventorycomboBox);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.inventorydataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showallButton;
        private System.Windows.Forms.ComboBox inventorycomboBox;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.DataGridView inventorydataGridView;
    }
}