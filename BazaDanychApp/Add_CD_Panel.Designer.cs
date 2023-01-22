namespace BazaDanychApp
{
    partial class Add_CD_Panel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_Box = new System.Windows.Forms.ComboBox();
            this.Team_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Author_Combo_Box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(316, 489);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 39;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(332, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Artyści";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(332, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Zespoły";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(302, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Wybierz tytuł";
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_Box.FormattingEnabled = true;
            this.Title_Box.Location = new System.Drawing.Point(146, 290);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(455, 39);
            this.Title_Box.TabIndex = 45;
            // 
            // Team_Combo_Box
            // 
            this.Team_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Combo_Box.FormattingEnabled = true;
            this.Team_Combo_Box.Location = new System.Drawing.Point(146, 173);
            this.Team_Combo_Box.Name = "Team_Combo_Box";
            this.Team_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Team_Combo_Box.TabIndex = 44;
            this.Team_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Team_Combo_Box_SelectedIndexChanged);
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(146, 65);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 43;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(220, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cena zakupu";
            // 
            // Price_TextBox
            // 
            this.Price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price_TextBox.Location = new System.Drawing.Point(392, 365);
            this.Price_TextBox.Name = "Price_TextBox";
            this.Price_TextBox.Size = new System.Drawing.Size(91, 30);
            this.Price_TextBox.TabIndex = 49;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Button.Location = new System.Drawing.Point(316, 446);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(133, 37);
            this.Add_Button.TabIndex = 51;
            this.Add_Button.Text = "Dodaj";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Add_CD_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.Team_Combo_Box);
            this.Controls.Add(this.Author_Combo_Box);
            this.Controls.Add(this.Back_Button);
            this.Name = "Add_CD_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_CD_Panel";
            this.Load += new System.EventHandler(this.Add_CD_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Title_Box;
        private System.Windows.Forms.ComboBox Team_Combo_Box;
        private System.Windows.Forms.ComboBox Author_Combo_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price_TextBox;
        private System.Windows.Forms.Button Add_Button;
    }
}