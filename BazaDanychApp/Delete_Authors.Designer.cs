namespace BazaDanychApp
{
    partial class Delete_Authors
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
            this.Del_Butt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(151, 140);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 32;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged);
            // 
            // Team_Combo_Box
            // 
            this.Team_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Combo_Box.FormattingEnabled = true;
            this.Team_Combo_Box.Location = new System.Drawing.Point(151, 297);
            this.Team_Combo_Box.Name = "Team_Combo_Box";
            this.Team_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Team_Combo_Box.TabIndex = 33;
            this.Team_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Team_Combo_Box_SelectedIndexChanged);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(312, 481);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 34;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Del_Butt
            // 
            this.Del_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Del_Butt.Location = new System.Drawing.Point(312, 438);
            this.Del_Butt.Name = "Del_Butt";
            this.Del_Butt.Size = new System.Drawing.Size(133, 37);
            this.Del_Butt.TabIndex = 35;
            this.Del_Butt.Text = "Usuń";
            this.Del_Butt.UseVisualStyleBackColor = true;
            this.Del_Butt.Click += new System.EventHandler(this.Del_Butt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(330, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Artyści";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(330, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Zespoły";
            // 
            // Delete_Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Del_Butt);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Team_Combo_Box);
            this.Controls.Add(this.Author_Combo_Box);
            this.Name = "Delete_Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Authors";
            this.Load += new System.EventHandler(this.Delete_Authors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Author_Combo_Box;
        private System.Windows.Forms.ComboBox Team_Combo_Box;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Del_Butt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}