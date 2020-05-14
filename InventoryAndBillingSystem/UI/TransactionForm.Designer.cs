namespace InventoryAndBillingSystem.UI
{
    partial class TransactionForm
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
            this.transactiondataGridView = new System.Windows.Forms.DataGridView();
            this.TransctionTypelabel = new System.Windows.Forms.Label();
            this.transactioncomboBox = new System.Windows.Forms.ComboBox();
            this.showallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactiondataGridView
            // 
            this.transactiondataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiondataGridView.Location = new System.Drawing.Point(13, 119);
            this.transactiondataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transactiondataGridView.Name = "transactiondataGridView";
            this.transactiondataGridView.RowHeadersWidth = 51;
            this.transactiondataGridView.RowTemplate.Height = 24;
            this.transactiondataGridView.Size = new System.Drawing.Size(1377, 580);
            this.transactiondataGridView.TabIndex = 0;
            // 
            // TransctionTypelabel
            // 
            this.TransctionTypelabel.AutoSize = true;
            this.TransctionTypelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransctionTypelabel.Location = new System.Drawing.Point(35, 38);
            this.TransctionTypelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransctionTypelabel.Name = "TransctionTypelabel";
            this.TransctionTypelabel.Size = new System.Drawing.Size(165, 25);
            this.TransctionTypelabel.TabIndex = 1;
            this.TransctionTypelabel.Text = "Transaction Type";
            // 
            // transactioncomboBox
            // 
            this.transactioncomboBox.FormattingEnabled = true;
            this.transactioncomboBox.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.transactioncomboBox.Location = new System.Drawing.Point(221, 30);
            this.transactioncomboBox.Name = "transactioncomboBox";
            this.transactioncomboBox.Size = new System.Drawing.Size(424, 33);
            this.transactioncomboBox.TabIndex = 3;
            this.transactioncomboBox.Text = "Choose Transaction Type";
            this.transactioncomboBox.SelectedIndexChanged += new System.EventHandler(this.transactioncomboBox_SelectedIndexChanged);
            // 
            // showallButton
            // 
            this.showallButton.BackColor = System.Drawing.Color.LightCyan;
            this.showallButton.FlatAppearance.BorderSize = 0;
            this.showallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showallButton.Location = new System.Drawing.Point(820, 29);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(194, 43);
            this.showallButton.TabIndex = 4;
            this.showallButton.Text = "Show All";
            this.showallButton.UseVisualStyleBackColor = false;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1403, 713);
            this.Controls.Add(this.showallButton);
            this.Controls.Add(this.transactioncomboBox);
            this.Controls.Add(this.TransctionTypelabel);
            this.Controls.Add(this.transactiondataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactiondataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactiondataGridView;
        private System.Windows.Forms.Label TransctionTypelabel;
        private System.Windows.Forms.ComboBox transactioncomboBox;
        private System.Windows.Forms.Button showallButton;
    }
}