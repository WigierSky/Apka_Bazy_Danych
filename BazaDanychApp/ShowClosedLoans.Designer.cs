namespace BazaDanychApp
{
    partial class ShowClosedLoans
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
            this.dgvl = new System.Windows.Forms.DataGridView();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvl
            // 
            this.dgvl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvl.Location = new System.Drawing.Point(13, 11);
            this.dgvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvl.Name = "dgvl";
            this.dgvl.RowHeadersWidth = 51;
            this.dgvl.RowTemplate.Height = 24;
            this.dgvl.Size = new System.Drawing.Size(757, 498);
            this.dgvl.TabIndex = 36;
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Back_Button.Location = new System.Drawing.Point(648, 513);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 37);
            this.Back_Button.TabIndex = 37;
            this.Back_Button.Text = "Wróć";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // ShowClosedLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.dgvl);
            this.Name = "ShowClosedLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowClosedLoans";
            this.Load += new System.EventHandler(this.ShowClosedLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvl;
        private System.Windows.Forms.Button Back_Button;
    }
}