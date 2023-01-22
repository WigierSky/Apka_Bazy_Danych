namespace BazaDanychApp
{
    partial class AddAuthors
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
            this.Artist_Butt = new System.Windows.Forms.RadioButton();
            this.Team_Butt = new System.Windows.Forms.RadioButton();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Team_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(300, 488);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 27;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Artist_Butt
            // 
            this.Artist_Butt.AutoSize = true;
            this.Artist_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Artist_Butt.Location = new System.Drawing.Point(319, 55);
            this.Artist_Butt.Name = "Artist_Butt";
            this.Artist_Butt.Size = new System.Drawing.Size(94, 29);
            this.Artist_Butt.TabIndex = 29;
            this.Artist_Butt.TabStop = true;
            this.Artist_Butt.Text = "Artysta";
            this.Artist_Butt.UseVisualStyleBackColor = true;
            // 
            // Team_Butt
            // 
            this.Team_Butt.AutoSize = true;
            this.Team_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_Butt.Location = new System.Drawing.Point(320, 267);
            this.Team_Butt.Name = "Team_Butt";
            this.Team_Butt.Size = new System.Drawing.Size(92, 29);
            this.Team_Butt.TabIndex = 30;
            this.Team_Butt.TabStop = true;
            this.Team_Butt.Text = "Zespół";
            this.Team_Butt.UseVisualStyleBackColor = true;
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_Textbox.Location = new System.Drawing.Point(365, 112);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(145, 30);
            this.Name_Textbox.TabIndex = 31;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_Label.Location = new System.Drawing.Point(290, 115);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(48, 25);
            this.Name_Label.TabIndex = 32;
            this.Name_Label.Text = "Imię";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Surname_TextBox.Location = new System.Drawing.Point(365, 173);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(145, 30);
            this.Surname_TextBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(242, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nazwisko";
            // 
            // Team_TextBox
            // 
            this.Team_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Team_TextBox.Location = new System.Drawing.Point(365, 326);
            this.Team_TextBox.Name = "Team_TextBox";
            this.Team_TextBox.Size = new System.Drawing.Size(221, 30);
            this.Team_TextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(191, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nazwa Zespołu";
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Butt.Location = new System.Drawing.Point(300, 434);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(133, 37);
            this.Add_Butt.TabIndex = 37;
            this.Add_Butt.Text = "Dodaj";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // AddAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Add_Butt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Team_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.Team_Butt);
            this.Controls.Add(this.Artist_Butt);
            this.Controls.Add(this.Back_Button);
            this.Name = "AddAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAuthors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.RadioButton Artist_Butt;
        private System.Windows.Forms.RadioButton Team_Butt;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Team_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Butt;
    }
}