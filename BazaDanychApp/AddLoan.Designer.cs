namespace BazaDanychApp
{
    partial class AddLoan
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
            this.Add_Butt = new System.Windows.Forms.Button();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Days_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Team_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Author_Combo_Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(318, 504);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 35;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Butt.Location = new System.Drawing.Point(318, 461);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(133, 37);
            this.Add_Butt.TabIndex = 36;
            this.Add_Butt.Text = "Dodaj";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price_TextBox.Location = new System.Drawing.Point(425, 395);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(91, 30);
            this.Price_TextBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(208, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cena wypożyczenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(185, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ilość dni wypożyczenia";
            // 
            // Days_Box
            // 
            this.Days_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Days_Box.Location = new System.Drawing.Point(425, 359);
            this.Days_Box.Name = "Days_Box";
            this.Days_Box.Size = new System.Drawing.Size(91, 30);
            this.Days_Box.TabIndex = 46;
            this.Days_Box.TextChanged += new System.EventHandler(this.Days_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(313, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Wybierz płytę";
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_Box.FormattingEnabled = true;
            this.Title_Box.Location = new System.Drawing.Point(161, 282);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(455, 39);
            this.Title_Box.TabIndex = 53;
            this.Title_Box.SelectedIndexChanged += new System.EventHandler(this.Title_Box_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(345, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Artyści";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(345, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Zespoły";
            // 
            // Team_Combo_Box
            // 
            this.Team_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Combo_Box.FormattingEnabled = true;
            this.Team_Combo_Box.Location = new System.Drawing.Point(161, 143);
            this.Team_Combo_Box.Name = "Team_Combo_Box";
            this.Team_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Team_Combo_Box.TabIndex = 50;
            this.Team_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Team_Combo_Box_SelectedIndexChanged);
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(161, 51);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 49;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged);
            // 
            // AddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Team_Combo_Box);
            this.Controls.Add(this.Author_Combo_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Days_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_TextBox);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.Back_Button);
            this.Name = "AddLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLoan";
            this.Load += new System.EventHandler(this.AddLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Add_Butt;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Days_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Title_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Team_Combo_Box;
        private System.Windows.Forms.ComboBox Author_Combo_Box;
    }
}