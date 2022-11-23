namespace BazaDanychApp
{
    partial class CD_Panel
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
            this.Add_CD_Button = new System.Windows.Forms.Button();
            this.Edit_Loans_Button = new System.Windows.Forms.Button();
            this.Edit_CD_Button = new System.Windows.Forms.Button();
            this.Edit_Tittle_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_CD_Button
            // 
            this.Add_CD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_CD_Button.Location = new System.Drawing.Point(48, 30);
            this.Add_CD_Button.Name = "Add_CD_Button";
            this.Add_CD_Button.Size = new System.Drawing.Size(175, 175);
            this.Add_CD_Button.TabIndex = 4;
            this.Add_CD_Button.Text = "Dodaj płytę";
            this.Add_CD_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Loans_Button
            // 
            this.Edit_Loans_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Loans_Button.Location = new System.Drawing.Point(48, 228);
            this.Edit_Loans_Button.Name = "Edit_Loans_Button";
            this.Edit_Loans_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_Loans_Button.TabIndex = 5;
            this.Edit_Loans_Button.Text = "Dodaj tytuł";
            this.Edit_Loans_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_CD_Button
            // 
            this.Edit_CD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_CD_Button.Location = new System.Drawing.Point(285, 30);
            this.Edit_CD_Button.Name = "Edit_CD_Button";
            this.Edit_CD_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_CD_Button.TabIndex = 6;
            this.Edit_CD_Button.Text = "Edytuj lub usuń płytę";
            this.Edit_CD_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Tittle_Button
            // 
            this.Edit_Tittle_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_Tittle_Button.Location = new System.Drawing.Point(285, 228);
            this.Edit_Tittle_Button.Name = "Edit_Tittle_Button";
            this.Edit_Tittle_Button.Size = new System.Drawing.Size(175, 175);
            this.Edit_Tittle_Button.TabIndex = 7;
            this.Edit_Tittle_Button.Text = "Edytuj lub usuń płytę";
            this.Edit_Tittle_Button.UseVisualStyleBackColor = true;
            // 
            // CD_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 435);
            this.Controls.Add(this.Edit_Tittle_Button);
            this.Controls.Add(this.Edit_CD_Button);
            this.Controls.Add(this.Edit_Loans_Button);
            this.Controls.Add(this.Add_CD_Button);
            this.Name = "CD_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CD_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_CD_Button;
        private System.Windows.Forms.Button Edit_Loans_Button;
        private System.Windows.Forms.Button Edit_CD_Button;
        private System.Windows.Forms.Button Edit_Tittle_Button;
    }
}