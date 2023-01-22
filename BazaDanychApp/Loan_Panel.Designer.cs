namespace BazaDanychApp
{
    partial class Loan_Panel
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
            this.Back_Button = new System.Windows.Forms.Button();
            this.Add_Loan = new System.Windows.Forms.Button();
            this.End_Loan = new System.Windows.Forms.Button();
            this.Show_Loans = new System.Windows.Forms.Button();
            this.Show_Dead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(637, 513);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 34;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Add_Loan
            // 
            this.Add_Loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Loan.Location = new System.Drawing.Point(147, 46);
            this.Add_Loan.Name = "Add_Loan";
            this.Add_Loan.Size = new System.Drawing.Size(200, 200);
            this.Add_Loan.TabIndex = 35;
            this.Add_Loan.Text = "Dodaj wypożyczenie";
            this.Add_Loan.UseVisualStyleBackColor = true;
            this.Add_Loan.Click += new System.EventHandler(this.Add_Loan_Click);
            // 
            // End_Loan
            // 
            this.End_Loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.End_Loan.Location = new System.Drawing.Point(436, 46);
            this.End_Loan.Name = "End_Loan";
            this.End_Loan.Size = new System.Drawing.Size(200, 200);
            this.End_Loan.TabIndex = 36;
            this.End_Loan.Text = "Zakończ wypożyczenie";
            this.End_Loan.UseVisualStyleBackColor = true;
            this.End_Loan.Click += new System.EventHandler(this.End_Loan_Click);
            // 
            // Show_Loans
            // 
            this.Show_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show_Loans.Location = new System.Drawing.Point(147, 286);
            this.Show_Loans.Name = "Show_Loans";
            this.Show_Loans.Size = new System.Drawing.Size(200, 200);
            this.Show_Loans.TabIndex = 37;
            this.Show_Loans.Text = "Wyświetl aktywne wypożyczenia";
            this.Show_Loans.UseVisualStyleBackColor = true;
            this.Show_Loans.Click += new System.EventHandler(this.Show_Loans_Click);
            // 
            // Show_Dead
            // 
            this.Show_Dead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show_Dead.Location = new System.Drawing.Point(436, 286);
            this.Show_Dead.Name = "Show_Dead";
            this.Show_Dead.Size = new System.Drawing.Size(200, 200);
            this.Show_Dead.TabIndex = 38;
            this.Show_Dead.Text = "Wyświetl zakończone wypożyczenia";
            this.Show_Dead.UseVisualStyleBackColor = true;
            this.Show_Dead.Click += new System.EventHandler(this.Show_Dead_Click);
            // 
            // Loan_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Show_Dead);
            this.Controls.Add(this.Show_Loans);
            this.Controls.Add(this.End_Loan);
            this.Controls.Add(this.Add_Loan);
            this.Controls.Add(this.Back_Button);
            this.Name = "Loan_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Add_Loan;
        private System.Windows.Forms.Button End_Loan;
        private System.Windows.Forms.Button Show_Loans;
        private System.Windows.Forms.Button Show_Dead;
    }
}