namespace PeliIdeaGeneraattori
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
            this.GeneroiBT = new System.Windows.Forms.Button();
            this.IdeaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GeneroiBT
            // 
            this.GeneroiBT.Location = new System.Drawing.Point(142, 415);
            this.GeneroiBT.Name = "GeneroiBT";
            this.GeneroiBT.Size = new System.Drawing.Size(75, 23);
            this.GeneroiBT.TabIndex = 0;
            this.GeneroiBT.Text = "Generoi idea";
            this.GeneroiBT.UseVisualStyleBackColor = true;
            this.GeneroiBT.Click += new System.EventHandler(this.GeneroiBT_Click);
            // 
            // IdeaTB
            // 
            this.IdeaTB.Location = new System.Drawing.Point(24, 12);
            this.IdeaTB.Multiline = true;
            this.IdeaTB.Name = "IdeaTB";
            this.IdeaTB.ReadOnly = true;
            this.IdeaTB.Size = new System.Drawing.Size(336, 397);
            this.IdeaTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.IdeaTB);
            this.Controls.Add(this.GeneroiBT);
            this.Name = "Form1";
            this.Text = "Peli idea generaattori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeneroiBT;
        private System.Windows.Forms.TextBox IdeaTB;
    }
}

