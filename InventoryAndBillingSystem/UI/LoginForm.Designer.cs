namespace InventoryAndBillingSystem.UI
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginbutton = new System.Windows.Forms.Button();
            this.usertypecombobox = new System.Windows.Forms.ComboBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.usertypelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.usertypecombobox);
            this.panel1.Controls.Add(this.passwordtextbox);
            this.panel1.Controls.Add(this.usernametextbox);
            this.panel1.Controls.Add(this.usertypelbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(69, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 655);
            this.panel1.TabIndex = 0;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.Salmon;
            this.loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(153, 482);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(164, 57);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // usertypecombobox
            // 
            this.usertypecombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usertypecombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypecombobox.FormattingEnabled = true;
            this.usertypecombobox.ItemHeight = 25;
            this.usertypecombobox.Items.AddRange(new object[] {
            "Admin",
            "Normal Users"});
            this.usertypecombobox.Location = new System.Drawing.Point(57, 417);
            this.usertypecombobox.Name = "usertypecombobox";
            this.usertypecombobox.Size = new System.Drawing.Size(397, 33);
            this.usertypecombobox.TabIndex = 7;
            this.usertypecombobox.Text = "Choose user type";
            this.usertypecombobox.SelectedIndexChanged += new System.EventHandler(this.usertypecombobox_SelectedIndexChanged);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextbox.Location = new System.Drawing.Point(57, 274);
            this.passwordtextbox.Multiline = true;
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(397, 36);
            this.passwordtextbox.TabIndex = 6;
            this.passwordtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextbox.Location = new System.Drawing.Point(57, 156);
            this.usernametextbox.Multiline = true;
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(397, 34);
            this.usernametextbox.TabIndex = 5;
            this.usernametextbox.TextChanged += new System.EventHandler(this.usernametextbox_TextChanged);
            // 
            // usertypelbl
            // 
            this.usertypelbl.AutoSize = true;
            this.usertypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypelbl.Location = new System.Drawing.Point(52, 372);
            this.usertypelbl.Name = "usertypelbl";
            this.usertypelbl.Size = new System.Drawing.Size(103, 25);
            this.usertypelbl.TabIndex = 3;
            this.usertypelbl.Text = "User Type";
            this.usertypelbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(52, 114);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(102, 25);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "Username";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(207, 36);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(96, 36);
            this.login.TabIndex = 0;
            this.login.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(665, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usertypelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.ComboBox usertypecombobox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Button loginbutton;
    }
}