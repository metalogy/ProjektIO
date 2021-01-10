
namespace GUI_projektIO
{
    partial class DeleteAccountWindow
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
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.confirmationLabelPassword = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.confirmationLabel.Location = new System.Drawing.Point(119, 9);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(578, 38);
            this.confirmationLabel.TabIndex = 0;
            this.confirmationLabel.Text = "Czy na pewno chcesz usunąć konto?  ";
            // 
            // confirmationLabelPassword
            // 
            this.confirmationLabelPassword.AutoSize = true;
            this.confirmationLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.confirmationLabelPassword.Location = new System.Drawing.Point(196, 98);
            this.confirmationLabelPassword.Name = "confirmationLabelPassword";
            this.confirmationLabelPassword.Size = new System.Drawing.Size(422, 38);
            this.confirmationLabelPassword.TabIndex = 1;
            this.confirmationLabelPassword.Text = "Aby potwierdzić podaj hasło";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(358, 163);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(370, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Usuń konto";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(370, 314);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.BackColor = System.Drawing.Color.Black;
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.confirmation.ForeColor = System.Drawing.Color.Lime;
            this.confirmation.Location = new System.Drawing.Point(150, 47);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(527, 51);
            this.confirmation.TabIndex = 29;
            this.confirmation.Text = "Pomyślnie usunięto konto!";
            // 
            // DeleteAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.confirmationLabelPassword);
            this.Controls.Add(this.confirmationLabel);
            this.Name = "DeleteAccountWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.Label confirmationLabelPassword;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label confirmation;
    }
}