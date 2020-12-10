
namespace GUI_projektIO
{
    partial class transferWindow
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
            this.back = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(371, 280);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 27;
            this.back.Text = "Cofnij";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(371, 237);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(75, 23);
            this.transferButton.TabIndex = 26;
            this.transferButton.Text = "Wpłać";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.confirmation.ForeColor = System.Drawing.Color.DarkOrange;
            this.confirmation.Location = new System.Drawing.Point(11, 143);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(0, 29);
            this.confirmation.TabIndex = 24;
            // 
            // moneyText
            // 
            this.moneyText.Location = new System.Drawing.Point(350, 211);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(121, 20);
            this.moneyText.TabIndex = 23;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.DarkRed;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.balance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.balance.Location = new System.Drawing.Point(14, 181);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 29);
            this.balance.TabIndex = 21;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(681, 70);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 23);
            this.exit.TabIndex = 20;
            this.exit.Text = "Zakończ sesję";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.helloLabel.Location = new System.Drawing.Point(11, 60);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 25);
            this.helloLabel.TabIndex = 16;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(350, 181);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsers.TabIndex = 28;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(220, 184);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(124, 13);
            this.userLabel.TabIndex = 29;
            this.userLabel.Text = "Wybierz konto docelowe";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(276, 214);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(68, 13);
            this.amountLabel.TabIndex = 30;
            this.amountLabel.Text = "Wpisz kwotę";
            // 
            // transferWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.back);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.helloLabel);
            this.Name = "transferWindow";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.TextBox moneyText;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label amountLabel;
    }
}