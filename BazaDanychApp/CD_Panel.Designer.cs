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
            this.Edit_CD_Button = new System.Windows.Forms.Button();
            this.Del_CD_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_CD_Button
            // 
            this.Add_CD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_CD_Button.Location = new System.Drawing.Point(52, 162);
            this.Add_CD_Button.Name = "Add_CD_Button";
            this.Add_CD_Button.Size = new System.Drawing.Size(200, 200);
            this.Add_CD_Button.TabIndex = 4;
            this.Add_CD_Button.Text = "Dodaj płytę";
            this.Add_CD_Button.UseVisualStyleBackColor = true;
            this.Add_CD_Button.Click += new System.EventHandler(this.Add_CD_Button_Click);
            // 
            // Edit_CD_Button
            // 
            this.Edit_CD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Edit_CD_Button.Location = new System.Drawing.Point(293, 162);
            this.Edit_CD_Button.Name = "Edit_CD_Button";
            this.Edit_CD_Button.Size = new System.Drawing.Size(200, 200);
            this.Edit_CD_Button.TabIndex = 6;
            this.Edit_CD_Button.Text = "Edytuj  płytę";
            this.Edit_CD_Button.UseVisualStyleBackColor = true;
            // 
            // Del_CD_Button
            // 
            this.Del_CD_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Del_CD_Button.Location = new System.Drawing.Point(546, 162);
            this.Del_CD_Button.Name = "Del_CD_Button";
            this.Del_CD_Button.Size = new System.Drawing.Size(200, 200);
            this.Del_CD_Button.TabIndex = 7;
            this.Del_CD_Button.Text = "Usuń płytę";
            this.Del_CD_Button.UseVisualStyleBackColor = true;
            // 
            // CD_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Del_CD_Button);
            this.Controls.Add(this.Edit_CD_Button);
            this.Controls.Add(this.Add_CD_Button);
            this.Name = "CD_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CD_Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_CD_Button;
        private System.Windows.Forms.Button Edit_CD_Button;
        private System.Windows.Forms.Button Del_CD_Button;
    }
}