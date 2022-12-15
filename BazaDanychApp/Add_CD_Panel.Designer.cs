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
            this.Add_CD_Label = new System.Windows.Forms.Label();
            this.Author_Combo_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Author_Label = new System.Windows.Forms.Label();
            this.Title_ComboBox = new System.Windows.Forms.ComboBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_CD_Label
            // 
            this.Add_CD_Label.AutoSize = true;
            this.Add_CD_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_CD_Label.Location = new System.Drawing.Point(259, 77);
            this.Add_CD_Label.Name = "Add_CD_Label";
            this.Add_CD_Label.Size = new System.Drawing.Size(221, 46);
            this.Add_CD_Label.TabIndex = 1;
            this.Add_CD_Label.Text = "Dodaj płytę";
            // 
            // Author_Combo_Box
            // 
            this.Author_Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Combo_Box.FormattingEnabled = true;
            this.Author_Combo_Box.Location = new System.Drawing.Point(174, 165);
            this.Author_Combo_Box.Name = "Author_Combo_Box";
            this.Author_Combo_Box.Size = new System.Drawing.Size(455, 39);
            this.Author_Combo_Box.TabIndex = 2;
            this.Author_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Author_Combo_Box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(626, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(577, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imię";
            // 
            // Author_Label
            // 
            this.Author_Label.AutoSize = true;
            this.Author_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Label.Location = new System.Drawing.Point(66, 172);
            this.Author_Label.Name = "Author_Label";
            this.Author_Label.Size = new System.Drawing.Size(82, 32);
            this.Author_Label.TabIndex = 5;
            this.Author_Label.Text = "Autor";
            // 
            // Title_ComboBox
            // 
            this.Title_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_ComboBox.FormattingEnabled = true;
            this.Title_ComboBox.Location = new System.Drawing.Point(174, 249);
            this.Title_ComboBox.Name = "Title_ComboBox";
            this.Title_ComboBox.Size = new System.Drawing.Size(455, 39);
            this.Title_ComboBox.TabIndex = 6;
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title_Label.Location = new System.Drawing.Point(66, 256);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(76, 32);
            this.Title_Label.TabIndex = 7;
            this.Title_Label.Text = "Tytuł";
            // 
            // Add_CD_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.Title_ComboBox);
            this.Controls.Add(this.Author_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Author_Combo_Box);
            this.Controls.Add(this.Add_CD_Label);
            this.Name = "Add_CD_Panel";
            this.Text = "Add_CD_Panel";
            this.Load += new System.EventHandler(this.Add_CD_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Add_CD_Label;
        private System.Windows.Forms.ComboBox Author_Combo_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Author_Label;
        private System.Windows.Forms.ComboBox Title_ComboBox;
        private System.Windows.Forms.Label Title_Label;
    }
}