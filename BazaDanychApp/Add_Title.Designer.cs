namespace BazaDanychApp
{
    partial class Add_Title
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
            this.Author_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Team_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_Text_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(156, 47);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 36;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged);
            // 
            // Team_Combo_Box
            // 
            this.Team_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Combo_Box.FormattingEnabled = true;
            this.Team_Combo_Box.Location = new System.Drawing.Point(156, 158);
            this.Team_Combo_Box.Name = "Team_Combo_Box";
            this.Team_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Team_Combo_Box.TabIndex = 37;
            this.Team_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Team_Combo_Box_SelectedIndexChanged);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(317, 491);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 38;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(222, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Tytuł";
            // 
            // Title_Text_Box
            // 
            this.Title_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_Text_Box.Location = new System.Drawing.Point(317, 262);
            this.Title_Text_Box.Name = "Title_Text_Box";
            this.Title_Text_Box.Size = new System.Drawing.Size(361, 30);
            this.Title_Text_Box.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(147, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data wydania";
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price_TextBox.Location = new System.Drawing.Point(317, 368);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(91, 30);
            this.Price_TextBox.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(207, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cena";
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Button.Location = new System.Drawing.Point(317, 448);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(133, 37);
            this.Add_Button.TabIndex = 45;
            this.Add_Button.Text = "Dodaj";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 30);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(340, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Artyści";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(340, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "Zespoły";
            // 
            // Add_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Team_Combo_Box);
            this.Controls.Add(this.Author_Combo_Box);
            this.Name = "Add_Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Title";
            this.Load += new System.EventHandler(this.Add_Title_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Author_Combo_Box;
        private System.Windows.Forms.ComboBox Team_Combo_Box;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title_Text_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}