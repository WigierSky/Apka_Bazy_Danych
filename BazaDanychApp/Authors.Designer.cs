namespace BazaDanychApp
{
    partial class Authors
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
            this.Author_Add_Button = new System.Windows.Forms.Button();
            this.Author_Show_Butt = new System.Windows.Forms.Button();
            this.Author_Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(647, 513);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 26;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Author_Add_Button
            // 
            this.Author_Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Add_Button.Location = new System.Drawing.Point(36, 166);
            this.Author_Add_Button.Name = "Author_Add_Button";
            this.Author_Add_Button.Size = new System.Drawing.Size(200, 200);
            this.Author_Add_Button.TabIndex = 27;
            this.Author_Add_Button.Text = "Dodaj autorów";
            this.Author_Add_Button.UseVisualStyleBackColor = true;
            this.Author_Add_Button.Click += new System.EventHandler(this.Author_Add_Button_Click);
            // 
            // Author_Show_Butt
            // 
            this.Author_Show_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Show_Butt.Location = new System.Drawing.Point(294, 166);
            this.Author_Show_Butt.Name = "Author_Show_Butt";
            this.Author_Show_Butt.Size = new System.Drawing.Size(200, 200);
            this.Author_Show_Butt.TabIndex = 28;
            this.Author_Show_Butt.Text = "Wyświetl autorów";
            this.Author_Show_Butt.UseVisualStyleBackColor = true;
            this.Author_Show_Butt.Click += new System.EventHandler(this.Author_Show_Butt_Click);
            // 
            // Author_Delete_Button
            // 
            this.Author_Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Delete_Button.Location = new System.Drawing.Point(552, 166);
            this.Author_Delete_Button.Name = "Author_Delete_Button";
            this.Author_Delete_Button.Size = new System.Drawing.Size(200, 200);
            this.Author_Delete_Button.TabIndex = 30;
            this.Author_Delete_Button.Text = "Usuń autorów";
            this.Author_Delete_Button.UseVisualStyleBackColor = true;
            this.Author_Delete_Button.Click += new System.EventHandler(this.Author_Delete_Button_Click);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Author_Delete_Button);
            this.Controls.Add(this.Author_Show_Butt);
            this.Controls.Add(this.Author_Add_Button);
            this.Controls.Add(this.Back_Button);
            this.Name = "Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Author_Add_Button;
        private System.Windows.Forms.Button Author_Show_Butt;
        private System.Windows.Forms.Button Author_Delete_Button;
    }
}