namespace InventoryAndBillingSystem.UI
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.labelLstName = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.boxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboboxUserType = new System.Windows.Forms.ComboBox();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.boxUserID = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 48);
            this.panel1.TabIndex = 0;
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
            this.labelUser.Location = new System.Drawing.Point(613, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(75, 29);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Users";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.Location = new System.Drawing.Point(23, 145);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(135, 29);
            this.labelFirstname.TabIndex = 2;
            this.labelFirstname.Text = "First Name";
            // 
            // boxFirstName
            // 
            this.boxFirstName.Location = new System.Drawing.Point(177, 145);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(278, 22);
            this.boxFirstName.TabIndex = 3;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(177, 312);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(278, 22);
            this.boxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 306);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(117, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(23, 263);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 29);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(177, 229);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(278, 22);
            this.boxEmail.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(23, 223);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(75, 29);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email";
            // 
            // boxLastName
            // 
            this.boxLastName.Location = new System.Drawing.Point(177, 186);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(278, 22);
            this.boxLastName.TabIndex = 19;
            // 
            // labelLstName
            // 
            this.labelLstName.AutoSize = true;
            this.labelLstName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLstName.Location = new System.Drawing.Point(23, 186);
            this.labelLstName.Name = "labelLstName";
            this.labelLstName.Size = new System.Drawing.Size(130, 29);
            this.labelLstName.TabIndex = 18;
            this.labelLstName.Text = "Last Name";
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(177, 269);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(278, 22);
            this.boxUsername.TabIndex = 15;
            // 
            // boxAddress
            // 
            this.boxAddress.Location = new System.Drawing.Point(177, 478);
            this.boxAddress.Multiline = true;
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(278, 99);
            this.boxAddress.TabIndex = 21;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(23, 478);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 29);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(23, 343);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(124, 29);
            this.lblUserType.TabIndex = 22;
            this.lblUserType.Text = "User Type";
            // 
            // boxContact
            // 
            this.boxContact.Location = new System.Drawing.Point(177, 430);
            this.boxContact.Name = "boxContact";
            this.boxContact.Size = new System.Drawing.Size(278, 22);
            this.boxContact.TabIndex = 25;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(23, 424);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(101, 29);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(23, 383);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(95, 29);
            this.lblgender.TabIndex = 26;
            this.lblgender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(177, 389);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(278, 24);
            this.comboBoxGender.TabIndex = 28;
            // 
            // comboboxUserType
            // 
            this.comboboxUserType.FormattingEnabled = true;
            this.comboboxUserType.Items.AddRange(new object[] {
            "Admin",
            "Normal Users"});
            this.comboboxUserType.Location = new System.Drawing.Point(177, 348);
            this.comboboxUserType.Name = "comboboxUserType";
            this.comboboxUserType.Size = new System.Drawing.Size(278, 24);
            this.comboboxUserType.TabIndex = 29;
            // 
            // dataUser
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataUser.Location = new System.Drawing.Point(564, 116);
            this.dataUser.Name = "dataUser";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 24;
            this.dataUser.Size = new System.Drawing.Size(718, 461);
            this.dataUser.TabIndex = 30;
            // 
            // boxUserID
            // 
            this.boxUserID.Location = new System.Drawing.Point(177, 107);
            this.boxUserID.Name = "boxUserID";
            this.boxUserID.ReadOnly = true;
            this.boxUserID.Size = new System.Drawing.Size(278, 22);
            this.boxUserID.TabIndex = 32;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(23, 107);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(92, 29);
            this.lblUserId.TabIndex = 31;
            this.lblUserId.Text = "User ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(277, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 59);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(637, 618);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 59);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(892, 618);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(178, 59);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(653, 71);
            this.boxSearch.Multiline = true;
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.ReadOnly = true;
            this.boxSearch.Size = new System.Drawing.Size(629, 29);
            this.boxSearch.TabIndex = 37;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(559, 71);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(88, 29);
            this.lblSearch.TabIndex = 36;
            this.lblSearch.Text = "Search";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1319, 712);
            this.Controls.Add(this.boxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxUserID);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.comboboxUserType);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.boxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.boxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.boxLastName);
            this.Controls.Add(this.labelLstName);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.boxFirstName);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "Users ";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.Label labelLstName;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox boxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboboxUserType;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox boxUserID;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
    }
}