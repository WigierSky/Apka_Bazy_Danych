namespace BazaDanychApp
{
    partial class Show_CDs
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
            this.dgvl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvl)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(648, 517);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 33;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // dgvl
            // 
            this.dgvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvl.Location = new System.Drawing.Point(12, 12);
            this.dgvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvl.Name = "dgvl";
            this.dgvl.RowHeadersWidth = 51;
            this.dgvl.RowTemplate.Height = 24;
            this.dgvl.Size = new System.Drawing.Size(757, 498);
            this.dgvl.TabIndex = 34;
            // 
            // Show_CDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.dgvl);
            this.Controls.Add(this.Back_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Show_CDs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_CDs";
            this.Load += new System.EventHandler(this.Show_CDs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.DataGridView dgvl;
    }
}