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
            this.SuspendLayout();
            // 
            // Edit_Clients_Button
            // 
            this.Edit_Clients_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Clients_Button.Location = new System.Drawing.Point(292, 220);
            this.Edit_Clients_Button.Name = "Edit_Clients_Button";
            this.Edit_Clients_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_Clients_Button.TabIndex = 0;
            this.Edit_Clients_Button.Text = "Edytuj klientów";
            this.Edit_Clients_Button.UseVisualStyleBackColor = true;
            this.Edit_Clients_Button.Click += new System.EventHandler(this.Edit_Clients_Button_Click);
            // 
            // Edit_CDs
            // 
            this.Edit_CDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_CDs.Location = new System.Drawing.Point(63, 220);
            this.Edit_CDs.Name = "Edit_CDs";
            this.Edit_CDs.Size = new System.Drawing.Size(175, 175);
            this.Edit_CDs.TabIndex = 1;
            this.Edit_CDs.Text = "Edytuj płyty";
            this.Edit_CDs.UseVisualStyleBackColor = true;
            this.Edit_CDs.Click += new System.EventHandler(this.Edit_CDs_Click);
            // 
            // Edit_Workers_Button
            // 
            this.Edit_Workers_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Workers_Button.Location = new System.Drawing.Point(292, 28);
            this.Edit_Workers_Button.Name = "Edit_Workers_Button";
            this.Edit_Workers_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_Workers_Button.TabIndex = 2;
            this.Edit_Workers_Button.Text = "Edytuj pracowników";
            this.Edit_Workers_Button.UseVisualStyleBackColor = true;
            this.Edit_Workers_Button.Click += new System.EventHandler(this.Edit_Workers_Button_Click);
            // 
            // Edit_Loans_Button
            // 
            this.Edit_Loans_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Loans_Button.Location = new System.Drawing.Point(63, 28);
            this.Edit_Loans_Button.Name = "Edit_Loans_Button";
            this.Edit_Loans_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_Loans_Button.TabIndex = 3;
            this.Edit_Loans_Button.Text = "Zarządzaj wypożyczeniami";
            this.Edit_Loans_Button.UseVisualStyleBackColor = true;
            this.Edit_Loans_Button.Click += new System.EventHandler(this.Edit_Loans_Button_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(518, 435);
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
    }
}