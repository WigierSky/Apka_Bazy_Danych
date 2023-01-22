namespace BazaDanychApp
{
    partial class WorkerLogin
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
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Edit_Loans_Button = new System.Windows.Forms.Button();
            this.Edit_Clients_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button.Location = new System.Drawing.Point(641, 497);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(129, 44);
            this.Exit_Button.TabIndex = 12;
            this.Exit_Button.Text = "Wyjście";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Edit_Loans_Button
            // 
            this.Edit_Loans_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Loans_Button.Location = new System.Drawing.Point(144, 167);
            this.Edit_Loans_Button.Name = "Edit_Loans_Button";
            this.Edit_Loans_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Loans_Button.TabIndex = 13;
            this.Edit_Loans_Button.Text = "Zarządzaj wypożyczeniami";
            this.Edit_Loans_Button.UseVisualStyleBackColor = true;
            this.Edit_Loans_Button.Click += new System.EventHandler(this.Edit_Loans_Button_Click);
            // 
            // Edit_Clients_Button
            // 
            this.Edit_Clients_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Clients_Button.Location = new System.Drawing.Point(422, 167);
            this.Edit_Clients_Button.Name = "Edit_Clients_Button";
            this.Edit_Clients_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Clients_Button.TabIndex = 14;
            this.Edit_Clients_Button.Text = "Zarządzaj klientami";
            this.Edit_Clients_Button.UseVisualStyleBackColor = true;
            this.Edit_Clients_Button.Click += new System.EventHandler(this.Edit_Clients_Button_Click);
            // 
            // WorkerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Edit_Clients_Button);
            this.Controls.Add(this.Edit_Loans_Button);
            this.Controls.Add(this.Exit_Button);
            this.Name = "WorkerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Edit_Loans_Button;
        private System.Windows.Forms.Button Edit_Clients_Button;
    }
}