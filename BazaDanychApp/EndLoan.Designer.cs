namespace BazaDanychApp
{
    partial class EndLoan
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
            this.Add_Butt = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Loan_Combo_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grade_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Butt.Location = new System.Drawing.Point(324, 447);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(133, 37);
            this.Add_Butt.TabIndex = 38;
            this.Add_Butt.Text = "Zatwiedź";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(324, 490);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 37;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(237, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "Wybierz wypożyczoną płytę";
            // 
            // Loan_Combo_Box
            // 
            this.Loan_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Loan_Combo_Box.FormattingEnabled = true;
            this.Loan_Combo_Box.Location = new System.Drawing.Point(161, 213);
            this.Loan_Combo_Box.Name = "Loan_Combo_Box";
            this.Loan_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Loan_Combo_Box.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(261, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ocena (1-5)";
            // 
            // Grade_Box
            // 
            this.Grade_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Grade_Box.Location = new System.Drawing.Point(403, 311);
            this.Grade_Box.Name = "Grade_Box";
            this.Grade_Box.Size = new System.Drawing.Size(91, 30);
            this.Grade_Box.TabIndex = 55;
            // 
            // EndLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grade_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Loan_Combo_Box);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.Back_Button);
            this.Name = "EndLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndLoan";
            this.Load += new System.EventHandler(this.EndLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Butt;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Loan_Combo_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grade_Box;
    }
}