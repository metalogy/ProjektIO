
namespace GUI_projektIO
{
    partial class MoneyInWindow
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
            this.confirmation = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.TextBox();
            this.actionInButton = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(404, 324);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 34;
            this.back.Text = "Cofnij";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.confirmation.ForeColor = System.Drawing.Color.DarkOrange;
            this.confirmation.Location = new System.Drawing.Point(10, 187);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(0, 29);
            this.confirmation.TabIndex = 33;
            // 
            // moneyText
            // 
            this.moneyText.Location = new System.Drawing.Point(298, 280);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(100, 20);
            this.moneyText.TabIndex = 32;
            // 
            // actionInButton
            // 
            this.actionInButton.Location = new System.Drawing.Point(404, 280);
            this.actionInButton.Name = "actionInButton";
            this.actionInButton.Size = new System.Drawing.Size(75, 23);
            this.actionInButton.TabIndex = 31;
            this.actionInButton.Text = "Wpłać";
            this.actionInButton.UseVisualStyleBackColor = true;
            this.actionInButton.Click += new System.EventHandler(this.actionInButton_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.DarkRed;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.balance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.balance.Location = new System.Drawing.Point(13, 225);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 29);
            this.balance.TabIndex = 30;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(680, 114);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(111, 23);
            this.exit.TabIndex = 29;
            this.exit.Text = "Zakończ sesję";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.helloLabel.Location = new System.Drawing.Point(10, 104);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 25);
            this.helloLabel.TabIndex = 28;
            // 
            // MoneyInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.actionInButton);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.helloLabel);
            this.Name = "MoneyInWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.TextBox moneyText;
        private System.Windows.Forms.Button actionInButton;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label helloLabel;
    }
}