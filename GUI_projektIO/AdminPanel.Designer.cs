
namespace GUI_projektIO
{
    partial class AdminPanel
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
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.editDataButton = new System.Windows.Forms.Button();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(677, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Zakończ sesję";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wybierz użytkownika";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 80);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(120, 13);
            this.userLabel.TabIndex = 31;
            this.userLabel.Text = "Wybierz konto do edycji";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(149, 77);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsers.TabIndex = 30;
            // 
            // deleteAccount
            // 
            this.deleteAccount.ForeColor = System.Drawing.Color.Red;
            this.deleteAccount.Location = new System.Drawing.Point(17, 415);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(141, 23);
            this.deleteAccount.TabIndex = 32;
            this.deleteAccount.Text = "Usuń konto użytkownika";
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(17, 185);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameTextBox.TabIndex = 33;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(163, 185);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(140, 20);
            this.surnameTextBox.TabIndex = 34;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(309, 185);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(140, 20);
            this.loginTextBox.TabIndex = 35;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(455, 185);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(140, 20);
            this.passwordTextBox.TabIndex = 36;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(601, 185);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 37;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.nameLabel.Location = new System.Drawing.Point(12, 156);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 26);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.surnameLabel.Location = new System.Drawing.Point(158, 156);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(106, 26);
            this.surnameLabel.TabIndex = 39;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.loginLabel.Location = new System.Drawing.Point(304, 156);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(65, 26);
            this.loginLabel.TabIndex = 40;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.passwordLabel.Location = new System.Drawing.Point(450, 156);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 26);
            this.passwordLabel.TabIndex = 41;
            this.passwordLabel.Text = "Hasło";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.balanceLabel.Location = new System.Drawing.Point(596, 156);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(68, 26);
            this.balanceLabel.TabIndex = 42;
            this.balanceLabel.Text = "Saldo";
            // 
            // editDataButton
            // 
            this.editDataButton.ForeColor = System.Drawing.Color.Green;
            this.editDataButton.Location = new System.Drawing.Point(647, 415);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(141, 23);
            this.editDataButton.TabIndex = 43;
            this.editDataButton.Text = "Edytuj dane użytkownika";
            this.editDataButton.UseVisualStyleBackColor = true;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.confirmationLabel.ForeColor = System.Drawing.Color.Green;
            this.confirmationLabel.Location = new System.Drawing.Point(222, 258);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(356, 31);
            this.confirmationLabel.TabIndex = 44;
            this.confirmationLabel.Text = "Pomyślnie zaaktualizowano!";
            this.confirmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(268, 227);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(264, 31);
            this.errorLabel.TabIndex = 45;
            this.errorLabel.Text = "Błąd zmiany danych!";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(285, 77);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(111, 23);
            this.loadDataButton.TabIndex = 46;
            this.loadDataButton.Text = "Załaduj dane";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.editDataButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Name = "AdminPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loadDataButton;
    }
}