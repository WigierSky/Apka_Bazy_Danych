namespace BazaDanychApp
{
    partial class Worker_Panel
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
            this.Edit_Worker_Button = new System.Windows.Forms.Button();
            this.Add_Worker_Button = new System.Windows.Forms.Button();
            this.Delete_Worker_Button = new System.Windows.Forms.Button();
            this.Back_Button_WP = new System.Windows.Forms.Button();
            this.Show_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_Worker_Button
            // 
            this.Edit_Worker_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Worker_Button.Location = new System.Drawing.Point(136, 58);
            this.Edit_Worker_Button.Name = "Edit_Worker_Button";
            this.Edit_Worker_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_Worker_Button.TabIndex = 4;
            this.Edit_Worker_Button.Text = "Edytuj dane pracownika";
            this.Edit_Worker_Button.UseVisualStyleBackColor = true;
            this.Edit_Worker_Button.Click += new System.EventHandler(this.Edit_Worker_Button_Click);
            // 
            // Add_Worker_Button
            // 
            this.Add_Worker_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Worker_Button.Location = new System.Drawing.Point(466, 58);
            this.Add_Worker_Button.Name = "Add_Worker_Button";
            this.Add_Worker_Button.Size = new System.Drawing.Size(200, 200);
            this.Add_Worker_Button.TabIndex = 5;
            this.Add_Worker_Button.Text = "Dodaj pracownika";
            this.Add_Worker_Button.UseVisualStyleBackColor = true;
            this.Add_Worker_Button.Click += new System.EventHandler(this.Add_Worker_Button_Click);
            // 
            // Delete_Worker_Button
            // 
            this.Delete_Worker_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delete_Worker_Button.Location = new System.Drawing.Point(136, 292);
            this.Delete_Worker_Button.Name = "Delete_Worker_Button";
            this.Delete_Worker_Button.Size = new System.Drawing.Size(200, 200);
            this.Delete_Worker_Button.TabIndex = 6;
            this.Delete_Worker_Button.Text = "Usuń pracownika";
            this.Delete_Worker_Button.UseVisualStyleBackColor = true;
            // 
            // Back_Button_WP
            // 
            this.Back_Button_WP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button_WP.Location = new System.Drawing.Point(681, 518);
            this.Back_Button_WP.Name = "Back_Button_WP";
            this.Back_Button_WP.Size = new System.Drawing.Size(99, 33);
            this.Back_Button_WP.TabIndex = 7;
            this.Back_Button_WP.Text = "Wróć";
            this.Back_Button_WP.UseVisualStyleBackColor = true;
            this.Back_Button_WP.Click += new System.EventHandler(this.Back_Button_WP_Click);
            // 
            // Show_butt
            // 
            this.Show_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Show_butt.Location = new System.Drawing.Point(466, 292);
            this.Show_butt.Name = "Show_butt";
            this.Show_butt.Size = new System.Drawing.Size(200, 200);
            this.Show_butt.TabIndex = 8;
            this.Show_butt.Text = "Wyświetl pracowników";
            this.Show_butt.UseVisualStyleBackColor = true;
            this.Show_butt.Click += new System.EventHandler(this.Show_butt_Click);
            // 
            // Worker_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Show_butt);
            this.Controls.Add(this.Back_Button_WP);
            this.Controls.Add(this.Delete_Worker_Button);
            this.Controls.Add(this.Add_Worker_Button);
            this.Controls.Add(this.Edit_Worker_Button);
            this.Name = "Worker_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Edit_Worker_Button;
        private System.Windows.Forms.Button Add_Worker_Button;
        private System.Windows.Forms.Button Delete_Worker_Button;
        private System.Windows.Forms.Button Back_Button_WP;
        private System.Windows.Forms.Button Show_butt;
    }
}