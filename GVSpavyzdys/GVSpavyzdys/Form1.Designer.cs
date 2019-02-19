namespace GVSpavyzdys
{
    partial class Form1
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
            this.Grupe = new System.Windows.Forms.GroupBox();
            this.PakeistiButton = new System.Windows.Forms.Button();
            this.TekstinisLaukas = new System.Windows.Forms.TextBox();
            this.TekstasMYgtukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grupe
            // 
            this.Grupe.Location = new System.Drawing.Point(61, 82);
            this.Grupe.Name = "Grupe";
            this.Grupe.Size = new System.Drawing.Size(422, 572);
            this.Grupe.TabIndex = 0;
            this.Grupe.TabStop = false;
            this.Grupe.Text = "Grupe";
            // 
            // PakeistiButton
            // 
            this.PakeistiButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PakeistiButton.Location = new System.Drawing.Point(640, 373);
            this.PakeistiButton.Name = "PakeistiButton";
            this.PakeistiButton.Size = new System.Drawing.Size(270, 105);
            this.PakeistiButton.TabIndex = 1;
            this.PakeistiButton.Text = "Pakeisti";
            this.PakeistiButton.UseVisualStyleBackColor = true;
            this.PakeistiButton.Click += new System.EventHandler(this.PakeistiButton_Click);
            // 
            // TekstinisLaukas
            // 
            this.TekstinisLaukas.Location = new System.Drawing.Point(597, 109);
            this.TekstinisLaukas.Name = "TekstinisLaukas";
            this.TekstinisLaukas.Size = new System.Drawing.Size(294, 35);
            this.TekstinisLaukas.TabIndex = 2;
            // 
            // TekstasMYgtukas
            // 
            this.TekstasMYgtukas.Location = new System.Drawing.Point(941, 373);
            this.TekstasMYgtukas.Name = "TekstasMYgtukas";
            this.TekstasMYgtukas.Size = new System.Drawing.Size(314, 105);
            this.TekstasMYgtukas.TabIndex = 3;
            this.TekstasMYgtukas.Text = "Mygtukas";
            this.TekstasMYgtukas.UseVisualStyleBackColor = true;
            this.TekstasMYgtukas.Click += new System.EventHandler(this.TekstasMYgtukas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 810);
            this.Controls.Add(this.TekstasMYgtukas);
            this.Controls.Add(this.TekstinisLaukas);
            this.Controls.Add(this.PakeistiButton);
            this.Controls.Add(this.Grupe);
            this.Name = "Form1";
            this.Text = "Blah";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupe;
        private System.Windows.Forms.Button PakeistiButton;
        private System.Windows.Forms.TextBox TekstinisLaukas;
        private System.Windows.Forms.Button TekstasMYgtukas;
    }
}

