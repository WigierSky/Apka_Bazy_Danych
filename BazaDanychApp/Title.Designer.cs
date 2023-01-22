namespace BazaDanychApp
{
    partial class Title
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
            this.Author_Title_Button = new System.Windows.Forms.Button();
            this.Show_Titles_Butt = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Author_Title_Button
            // 
            this.Author_Title_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Title_Button.Location = new System.Drawing.Point(164, 147);
            this.Author_Title_Button.Name = "Author_Title_Button";
            this.Author_Title_Button.Size = new System.Drawing.Size(200, 200);
            this.Author_Title_Button.TabIndex = 28;
            this.Author_Title_Button.Text = "Dodaj tytuły";
            this.Author_Title_Button.UseVisualStyleBackColor = true;
            this.Author_Title_Button.Click += new System.EventHandler(this.Author_Title_Button_Click);
            // 
            // Show_Titles_Butt
            // 
            this.Show_Titles_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show_Titles_Butt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Show_Titles_Butt.Location = new System.Drawing.Point(445, 147);
            this.Show_Titles_Butt.Name = "Show_Titles_Butt";
            this.Show_Titles_Butt.Size = new System.Drawing.Size(200, 200);
            this.Show_Titles_Butt.TabIndex = 30;
            this.Show_Titles_Butt.Text = "Wyświetl tytuły";
            this.Show_Titles_Butt.UseVisualStyleBackColor = true;
            this.Show_Titles_Butt.Click += new System.EventHandler(this.Show_Titles_Butt_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(637, 504);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 31;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Show_Titles_Butt);
            this.Controls.Add(this.Author_Title_Button);
            this.Name = "Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Author_Title_Button;
        private System.Windows.Forms.Button Show_Titles_Butt;
        private System.Windows.Forms.Button Back_Button;
    }
}