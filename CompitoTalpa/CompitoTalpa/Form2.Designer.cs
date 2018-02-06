namespace CompitoTalpa
{
    partial class Form2
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
            this.immagine = new System.Windows.Forms.PictureBox();
            this.avanti = new System.Windows.Forms.Button();
            this.aiuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.SuspendLayout();
            // 
            // immagine
            // 
            this.immagine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.immagine.ImageLocation = "C:\\Users\\richi\\source\\repos\\CompitoTalpa2\\CompitoTalpa\\Immagini";
            this.immagine.Location = new System.Drawing.Point(40, 12);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(1371, 641);
            this.immagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // avanti
            // 
            this.avanti.Location = new System.Drawing.Point(1306, 659);
            this.avanti.Name = "avanti";
            this.avanti.Size = new System.Drawing.Size(119, 72);
            this.avanti.TabIndex = 1;
            this.avanti.Text = "Avanti";
            this.avanti.UseVisualStyleBackColor = true;
            this.avanti.Click += new System.EventHandler(this.avanti_Click);
            // 
            // aiuto
            // 
            this.aiuto.Location = new System.Drawing.Point(12, 659);
            this.aiuto.Name = "aiuto";
            this.aiuto.Size = new System.Drawing.Size(119, 72);
            this.aiuto.TabIndex = 2;
            this.aiuto.Text = "Aiuto";
            this.aiuto.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 743);
            this.Controls.Add(this.aiuto);
            this.Controls.Add(this.avanti);
            this.Controls.Add(this.immagine);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Button avanti;
        private System.Windows.Forms.Button aiuto;
    }
}