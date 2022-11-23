namespace BazaDanychApp
{
    partial class Login_Screen
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_logg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Log = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Login_Box = new System.Windows.Forms.TextBox();
            this.Pass_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_logg
            // 
            this.label_logg.AutoSize = true;
            this.label_logg.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logg.Location = new System.Drawing.Point(121, 42);
            this.label_logg.Name = "label_logg";
            this.label_logg.Size = new System.Drawing.Size(176, 46);
            this.label_logg.TabIndex = 0;
            this.label_logg.Text = "Zaloguj się";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło:";
            // 
            // Button_Log
            // 
            this.Button_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Log.Location = new System.Drawing.Point(98, 268);
            this.Button_Log.Name = "Button_Log";
            this.Button_Log.Size = new System.Drawing.Size(221, 44);
            this.Button_Log.TabIndex = 3;
            this.Button_Log.Text = "Zaloguj";
            this.Button_Log.UseVisualStyleBackColor = true;
            this.Button_Log.Click += new System.EventHandler(this.Button_Log_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear_Button.Location = new System.Drawing.Point(98, 318);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(221, 44);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Wyczyść pola";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Exit_Button.Location = new System.Drawing.Point(98, 368);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(221, 44);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.Text = "Wyjście";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Login_Box
            // 
            this.Login_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_Box.Location = new System.Drawing.Point(129, 135);
            this.Login_Box.Name = "Login_Box";
            this.Login_Box.Size = new System.Drawing.Size(188, 34);
            this.Login_Box.TabIndex = 6;
            // 
            // Pass_Box
            // 
            this.Pass_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass_Box.Location = new System.Drawing.Point(129, 194);
            this.Pass_Box.Name = "Pass_Box";
            this.Pass_Box.Size = new System.Drawing.Size(188, 34);
            this.Pass_Box.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 424);
            this.Controls.Add(this.Pass_Box);
            this.Controls.Add(this.Login_Box);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Button_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_logg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Log;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Login_Box;
        private System.Windows.Forms.TextBox Pass_Box;
    }
}

