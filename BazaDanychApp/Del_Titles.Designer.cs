namespace BazaDanychApp
{
    partial class Del_Titles
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
            this.Team_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Author_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Title_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(321, 481);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 32;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Team_Combo_Box
            // 
            this.Team_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Combo_Box.FormattingEnabled = true;
            this.Team_Combo_Box.Location = new System.Drawing.Point(149, 187);
            this.Team_Combo_Box.Name = "Team_Combo_Box";
            this.Team_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Team_Combo_Box.TabIndex = 37;
            this.Team_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Team_Combo_Box_SelectedIndexChanged);
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(149, 71);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 36;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged);
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_Box.FormattingEnabled = true;
            this.Title_Box.Location = new System.Drawing.Point(149, 320);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(455, 39);
            this.Title_Box.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(307, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Wybierz tytuł";
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Button.Location = new System.Drawing.Point(321, 438);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(133, 37);
            this.Delete_Button.TabIndex = 40;
            this.Delete_Button.Text = "Usuń";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(333, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Zespoły";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(333, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Artyści";
            // 
            // Del_Titles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.Team_Combo_Box);
            this.Controls.Add(this.Author_Combo_Box);
            this.Controls.Add(this.Back_Button);
            this.Name = "Del_Titles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Del_Titles";
            this.Load += new System.EventHandler(this.Del_Titles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.ComboBox Team_Combo_Box;
        private System.Windows.Forms.ComboBox Author_Combo_Box;
        private System.Windows.Forms.ComboBox Title_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}