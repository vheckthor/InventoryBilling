namespace InventoryAndBillingSystem.UI
{
    partial class DealerandCustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealerandCustomerForm));
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.boxUserID = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.comboboxUserType = new System.Windows.Forms.ComboBox();
            this.boxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.Typelbl = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(642, 114);
            this.boxSearch.Multiline = true;
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(629, 29);
            this.boxSearch.TabIndex = 64;
            this.boxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boxSearch_MouseClick);
            this.boxSearch.TextChanged += new System.EventHandler(this.boxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(548, 114);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 29);
            this.lblSearch.TabIndex = 63;
            this.lblSearch.Text = "Search";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(868, 661);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(178, 59);
            this.btndelete.TabIndex = 62;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(553, 661);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 59);
            this.btnUpdate.TabIndex = 61;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(266, 661);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 59);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // boxUserID
            // 
            this.boxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUserID.Location = new System.Drawing.Point(166, 150);
            this.boxUserID.Name = "boxUserID";
            this.boxUserID.ReadOnly = true;
            this.boxUserID.Size = new System.Drawing.Size(278, 30);
            this.boxUserID.TabIndex = 59;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(12, 150);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(35, 29);
            this.lblUserId.TabIndex = 58;
            this.lblUserId.Text = "ID";
            // 
            // dataUser
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataUser.Location = new System.Drawing.Point(553, 159);
            this.dataUser.Name = "dataUser";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 24;
            this.dataUser.Size = new System.Drawing.Size(718, 461);
            this.dataUser.TabIndex = 57;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            this.dataUser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataUser_RowHeaderMouseClick);
            // 
            // comboboxUserType
            // 
            this.comboboxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboboxUserType.FormattingEnabled = true;
            this.comboboxUserType.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.comboboxUserType.Location = new System.Drawing.Point(168, 207);
            this.comboboxUserType.Name = "comboboxUserType";
            this.comboboxUserType.Size = new System.Drawing.Size(278, 33);
            this.comboboxUserType.TabIndex = 56;
            this.comboboxUserType.Text = "Type";
            // 
            // boxContact
            // 
            this.boxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxContact.Location = new System.Drawing.Point(166, 381);
            this.boxContact.Name = "boxContact";
            this.boxContact.Size = new System.Drawing.Size(278, 30);
            this.boxContact.TabIndex = 53;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(12, 375);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(101, 29);
            this.lblContact.TabIndex = 52;
            this.lblContact.Text = "Contact";
            // 
            // Typelbl
            // 
            this.Typelbl.AutoSize = true;
            this.Typelbl.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typelbl.Location = new System.Drawing.Point(14, 202);
            this.Typelbl.Name = "Typelbl";
            this.Typelbl.Size = new System.Drawing.Size(67, 29);
            this.Typelbl.TabIndex = 51;
            this.Typelbl.Text = "Type";
            // 
            // boxAddress
            // 
            this.boxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxAddress.Location = new System.Drawing.Point(166, 435);
            this.boxAddress.Multiline = true;
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(278, 122);
            this.boxAddress.TabIndex = 50;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 435);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 29);
            this.lblAddress.TabIndex = 49;
            this.lblAddress.Text = "Address";
            // 
            // boxEmail
            // 
            this.boxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxEmail.Location = new System.Drawing.Point(168, 323);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(278, 30);
            this.boxEmail.TabIndex = 46;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(14, 317);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 29);
            this.Email.TabIndex = 45;
            this.Email.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 48);
            this.panel1.TabIndex = 38;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelUser.Location = new System.Drawing.Point(548, 3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(250, 29);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Dealer and Customer";
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.namebox.Location = new System.Drawing.Point(166, 262);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(278, 30);
            this.namebox.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Name";
            // 
            // DealerandCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1322, 760);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxUserID);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.comboboxUserType);
            this.Controls.Add(this.boxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.Typelbl);
            this.Controls.Add(this.boxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DealerandCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealerandCustomerForm";
            this.Load += new System.EventHandler(this.DealerandCustomerForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DealerandCustomerForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox boxUserID;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.ComboBox comboboxUserType;
        private System.Windows.Forms.TextBox boxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label Typelbl;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
    }
}