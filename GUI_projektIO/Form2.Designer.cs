
namespace GUI_projektIO
{
    partial class Form2
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.cashOut = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.actionOutButton = new System.Windows.Forms.Button();
            this.moneyText = new System.Windows.Forms.TextBox();
            this.confirmation = new System.Windows.Forms.Label();
            this.cashIn = new System.Windows.Forms.Button();
            this.actionInButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.transferMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.helloLabel.Location = new System.Drawing.Point(7, 3);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 25);
            this.helloLabel.TabIndex = 0;
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textLabel1.Location = new System.Drawing.Point(5, 44);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(189, 25);
            this.textLabel1.TabIndex = 1;
            this.textLabel1.Text = "Co chcesz zrobić?";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(343, 223);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(115, 23);
            this.check.TabIndex = 2;
            this.check.Text = "Sprawdź stan konta";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // cashOut
            // 
            this.cashOut.Location = new System.Drawing.Point(343, 252);
            this.cashOut.Name = "cashOut";
            this.cashOut.Size = new System.Drawing.Size(115, 23);
            this.cashOut.TabIndex = 3;
            this.cashOut.Text = "Wypłać pieniądze";
            this.cashOut.UseVisualStyleBackColor = true;
            this.cashOut.Click += new System.EventHandler(this.cashOut_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(677, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Zakończ sesję";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.DarkRed;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.balance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.balance.Location = new System.Drawing.Point(10, 124);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 29);
            this.balance.TabIndex = 6;
            // 
            // actionOutButton
            // 
            this.actionOutButton.Location = new System.Drawing.Point(401, 179);
            this.actionOutButton.Name = "actionOutButton";
            this.actionOutButton.Size = new System.Drawing.Size(75, 23);
            this.actionOutButton.TabIndex = 8;
            this.actionOutButton.Text = "Wypłać";
            this.actionOutButton.UseVisualStyleBackColor = true;
            this.actionOutButton.Click += new System.EventHandler(this.actionOutButton_Click);
            // 
            // moneyText
            // 
            this.moneyText.Location = new System.Drawing.Point(295, 182);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(100, 20);
            this.moneyText.TabIndex = 9;
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.confirmation.ForeColor = System.Drawing.Color.DarkOrange;
            this.confirmation.Location = new System.Drawing.Point(7, 86);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(0, 29);
            this.confirmation.TabIndex = 11;
            // 
            // cashIn
            // 
            this.cashIn.Location = new System.Drawing.Point(343, 281);
            this.cashIn.Name = "cashIn";
            this.cashIn.Size = new System.Drawing.Size(115, 23);
            this.cashIn.TabIndex = 12;
            this.cashIn.Text = "Wpłać pieniądze";
            this.cashIn.UseVisualStyleBackColor = true;
            this.cashIn.Click += new System.EventHandler(this.cashIn_Click);
            // 
            // actionInButton
            // 
            this.actionInButton.Location = new System.Drawing.Point(401, 180);
            this.actionInButton.Name = "actionInButton";
            this.actionInButton.Size = new System.Drawing.Size(75, 23);
            this.actionInButton.TabIndex = 13;
            this.actionInButton.Text = "Wpłać";
            this.actionInButton.UseVisualStyleBackColor = true;
            this.actionInButton.Click += new System.EventHandler(this.actionInButton_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(401, 223);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 14;
            this.back.Text = "Cofnij";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // transferMoney
            // 
            this.transferMoney.Location = new System.Drawing.Point(343, 310);
            this.transferMoney.Name = "transferMoney";
            this.transferMoney.Size = new System.Drawing.Size(115, 23);
            this.transferMoney.TabIndex = 15;
            this.transferMoney.Text = "Przelew";
            this.transferMoney.UseVisualStyleBackColor = true;
            this.transferMoney.Click += new System.EventHandler(this.transferMoney_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transferMoney);
            this.Controls.Add(this.back);
            this.Controls.Add(this.actionInButton);
            this.Controls.Add(this.cashIn);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.actionOutButton);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.cashOut);
            this.Controls.Add(this.check);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.helloLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button cashOut;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button actionOutButton;
        private System.Windows.Forms.TextBox moneyText;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Button cashIn;
        private System.Windows.Forms.Button actionInButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button transferMoney;
    }
}