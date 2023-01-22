namespace BazaDanychApp
{
    partial class Client_Panel
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
            this.add_client_button = new System.Windows.Forms.Button();
            this.edit_client_button = new System.Windows.Forms.Button();
            this.delete_client_button = new System.Windows.Forms.Button();
            this.display_client_button = new System.Windows.Forms.Button();
            this.back_button_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_client_button
            // 
            this.add_client_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_client_button.Location = new System.Drawing.Point(141, 62);
            this.add_client_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(200, 200);
            this.add_client_button.TabIndex = 0;
            this.add_client_button.Text = "Dodaj klienta";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_click);
            // 
            // edit_client_button
            // 
            this.edit_client_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edit_client_button.Location = new System.Drawing.Point(414, 62);
            this.edit_client_button.Margin = new System.Windows.Forms.Padding(4);
            this.edit_client_button.Name = "edit_client_button";
            this.edit_client_button.Size = new System.Drawing.Size(200, 200);
            this.edit_client_button.TabIndex = 1;
            this.edit_client_button.Text = "Edytuj klienta";
            this.edit_client_button.UseVisualStyleBackColor = true;
            this.edit_client_button.Click += new System.EventHandler(this.edit_client_button_click);
            // 
            // delete_client_button
            // 
            this.delete_client_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_client_button.Location = new System.Drawing.Point(141, 284);
            this.delete_client_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_client_button.Name = "delete_client_button";
            this.delete_client_button.Size = new System.Drawing.Size(200, 200);
            this.delete_client_button.TabIndex = 2;
            this.delete_client_button.Text = "Usuń klienta";
            this.delete_client_button.UseVisualStyleBackColor = true;
            this.delete_client_button.Click += new System.EventHandler(this.delete_client_buttno_click);
            // 
            // display_client_button
            // 
            this.display_client_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display_client_button.Location = new System.Drawing.Point(414, 284);
            this.display_client_button.Margin = new System.Windows.Forms.Padding(4);
            this.display_client_button.Name = "display_client_button";
            this.display_client_button.Size = new System.Drawing.Size(200, 200);
            this.display_client_button.TabIndex = 3;
            this.display_client_button.Text = "Wyświetl klientów";
            this.display_client_button.UseVisualStyleBackColor = true;
            this.display_client_button.Click += new System.EventHandler(this.display_client_button_Click);
            // 
            // back_button_client
            // 
            this.back_button_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_button_client.Location = new System.Drawing.Point(661, 518);
            this.back_button_client.Margin = new System.Windows.Forms.Padding(4);
            this.back_button_client.Name = "back_button_client";
            this.back_button_client.Size = new System.Drawing.Size(108, 32);
            this.back_button_client.TabIndex = 4;
            this.back_button_client.Text = "Wróć";
            this.back_button_client.UseVisualStyleBackColor = true;
            this.back_button_client.Click += new System.EventHandler(this.back_button_client_Click);
            // 
            // Client_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.back_button_client);
            this.Controls.Add(this.display_client_button);
            this.Controls.Add(this.delete_client_button);
            this.Controls.Add(this.edit_client_button);
            this.Controls.Add(this.add_client_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.Button edit_client_button;
        private System.Windows.Forms.Button delete_client_button;
        private System.Windows.Forms.Button display_client_button;
        private System.Windows.Forms.Button back_button_client;
    }
}