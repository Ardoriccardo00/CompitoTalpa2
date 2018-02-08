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
            this.components = new System.ComponentModel.Container();
            this.avanti = new System.Windows.Forms.Button();
            this.dialogo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nanaStanca = new System.Windows.Forms.PictureBox();
            this.aiuto = new System.Windows.Forms.Button();
            this.immagine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nanaStanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).BeginInit();
            this.SuspendLayout();
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
            // dialogo
            // 
            this.dialogo.AutoSize = true;
            this.dialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogo.Location = new System.Drawing.Point(121, 707);
            this.dialogo.Name = "dialogo";
            this.dialogo.Size = new System.Drawing.Size(116, 24);
            this.dialogo.TabIndex = 4;
            this.dialogo.Text = "Sample Text";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nanaStanca
            // 
            this.nanaStanca.Image = global::CompitoTalpa.Properties.Resources.nana_stanca_ritagliata;
            this.nanaStanca.Location = new System.Drawing.Point(640, 318);
            this.nanaStanca.Name = "nanaStanca";
            this.nanaStanca.Size = new System.Drawing.Size(137, 139);
            this.nanaStanca.TabIndex = 3;
            this.nanaStanca.TabStop = false;
            this.nanaStanca.Visible = false;
            this.nanaStanca.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aiuto
            // 
            this.aiuto.BackgroundImage = global::CompitoTalpa.Properties.Resources.icons8_informazioni_50;
            this.aiuto.Location = new System.Drawing.Point(12, 680);
            this.aiuto.Name = "aiuto";
            this.aiuto.Size = new System.Drawing.Size(48, 51);
            this.aiuto.TabIndex = 2;
            this.aiuto.UseVisualStyleBackColor = true;
            // 
            // immagine
            // 
            this.immagine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.immagine.Image = global::CompitoTalpa.Properties.Resources.background1;
            this.immagine.ImageLocation = "";
            this.immagine.Location = new System.Drawing.Point(40, 12);
            this.immagine.Name = "immagine";
            this.immagine.Size = new System.Drawing.Size(1371, 641);
            this.immagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.immagine.TabIndex = 0;
            this.immagine.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 743);
            this.Controls.Add(this.dialogo);
            this.Controls.Add(this.nanaStanca);
            this.Controls.Add(this.aiuto);
            this.Controls.Add(this.avanti);
            this.Controls.Add(this.immagine);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nanaStanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox immagine;
        private System.Windows.Forms.Button avanti;
        private System.Windows.Forms.Button aiuto;
        private System.Windows.Forms.PictureBox nanaStanca;
        private System.Windows.Forms.Label dialogo;
        private System.Windows.Forms.Timer timer1;
    }
}