namespace BazaDanychApp
{
    partial class Admin_Panel
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
            this.Edit_Clients_Button = new System.Windows.Forms.Button();
            this.Edit_CDs = new System.Windows.Forms.Button();
            this.Edit_Workers_Button = new System.Windows.Forms.Button();
            this.Edit_Loans_Button = new System.Windows.Forms.Button();
            this.Tittle_Edit_Button = new System.Windows.Forms.Button();
            this.Author_Edit_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_Clients_Button
            // 
            this.Edit_Clients_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Clients_Button.Location = new System.Drawing.Point(539, 286);
            this.Edit_Clients_Button.Name = "Edit_Clients_Button";
            this.Edit_Clients_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Clients_Button.TabIndex = 0;
            this.Edit_Clients_Button.Text = "Edytuj klientów";
            this.Edit_Clients_Button.UseVisualStyleBackColor = true;
            this.Edit_Clients_Button.Click += new System.EventHandler(this.Edit_Clients_Button_Click);
            // 
            // Edit_CDs
            // 
            this.Edit_CDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_CDs.Location = new System.Drawing.Point(297, 286);
            this.Edit_CDs.Name = "Edit_CDs";
            this.Edit_CDs.Size = new System.Drawing.Size(200, 200);
            this.Edit_CDs.TabIndex = 1;
            this.Edit_CDs.Text = "Edytuj płyty";
            this.Edit_CDs.UseVisualStyleBackColor = true;
            this.Edit_CDs.Click += new System.EventHandler(this.Edit_CDs_Click);
            // 
            // Edit_Workers_Button
            // 
            this.Edit_Workers_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Workers_Button.Location = new System.Drawing.Point(539, 58);
            this.Edit_Workers_Button.Name = "Edit_Workers_Button";
            this.Edit_Workers_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Workers_Button.TabIndex = 2;
            this.Edit_Workers_Button.Text = "Edytuj pracowników";
            this.Edit_Workers_Button.UseVisualStyleBackColor = true;
            this.Edit_Workers_Button.Click += new System.EventHandler(this.Edit_Workers_Button_Click);
            // 
            // Edit_Loans_Button
            // 
            this.Edit_Loans_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Loans_Button.Location = new System.Drawing.Point(297, 58);
            this.Edit_Loans_Button.Name = "Edit_Loans_Button";
            this.Edit_Loans_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Loans_Button.TabIndex = 3;
            this.Edit_Loans_Button.Text = "Zarządzaj wypożyczeniami";
            this.Edit_Loans_Button.UseVisualStyleBackColor = true;
            this.Edit_Loans_Button.Click += new System.EventHandler(this.Edit_Loans_Button_Click);
            // 
            // Tittle_Edit_Button
            // 
            this.Tittle_Edit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tittle_Edit_Button.Location = new System.Drawing.Point(46, 58);
            this.Tittle_Edit_Button.Name = "Tittle_Edit_Button";
            this.Tittle_Edit_Button.Size = new System.Drawing.Size(200, 200);
            this.Tittle_Edit_Button.TabIndex = 9;
            this.Tittle_Edit_Button.Text = "Edytuj tytuły";
            this.Tittle_Edit_Button.UseVisualStyleBackColor = true;
            this.Tittle_Edit_Button.Click += new System.EventHandler(this.Tittle_Edit_Button_Click);
            // 
            // Author_Edit_Button
            // 
            this.Author_Edit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Edit_Button.Location = new System.Drawing.Point(46, 286);
            this.Author_Edit_Button.Name = "Author_Edit_Button";
            this.Author_Edit_Button.Size = new System.Drawing.Size(200, 200);
            this.Author_Edit_Button.TabIndex = 10;
            this.Author_Edit_Button.Text = "Edytuj autorów";
            this.Author_Edit_Button.UseVisualStyleBackColor = true;
            this.Author_Edit_Button.Click += new System.EventHandler(this.Author_Edit_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button.Location = new System.Drawing.Point(641, 506);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(129, 44);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.Text = "Wyjście";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Author_Edit_Button);
            this.Controls.Add(this.Tittle_Edit_Button);
            this.Controls.Add(this.Edit_Loans_Button);
            this.Controls.Add(this.Edit_Workers_Button);
            this.Controls.Add(this.Edit_CDs);
            this.Controls.Add(this.Edit_Clients_Button);
            this.Name = "Admin_Panel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_Clients_Button;
        private System.Windows.Forms.Button Edit_CDs;
        private System.Windows.Forms.Button Edit_Workers_Button;
        private System.Windows.Forms.Button Edit_Loans_Button;
        private System.Windows.Forms.Button Tittle_Edit_Button;
        private System.Windows.Forms.Button Author_Edit_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}