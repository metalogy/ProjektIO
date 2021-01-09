
namespace GUI_projektIO
{
    partial class AdminLoginForm
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
            this.loginText = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.failedLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(108, 56);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(100, 20);
            this.loginText.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(121, 136);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Zakończ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(66, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Hasło";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(67, 59);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(121, 107);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(108, 82);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 9;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(306, 20);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Logowanie do panelu administracyjnego";
            // 
            // failedLogin
            // 
            this.failedLogin.AutoSize = true;
            this.failedLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.failedLogin.ForeColor = System.Drawing.Color.Red;
            this.failedLogin.Location = new System.Drawing.Point(65, 33);
            this.failedLogin.Name = "failedLogin";
            this.failedLogin.Size = new System.Drawing.Size(177, 20);
            this.failedLogin.TabIndex = 16;
            this.failedLogin.Text = "Błęde dane logowania!";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(303, 163);
            this.Controls.Add(this.failedLogin);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Name = "AdminLoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label failedLogin;
    }
}