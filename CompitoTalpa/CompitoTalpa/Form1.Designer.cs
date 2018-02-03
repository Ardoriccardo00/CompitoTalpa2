namespace CompitoTalpa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.controllo = new System.Windows.Forms.Label();
            this.colpito = new System.Windows.Forms.Label();
            this.abilita = new System.Windows.Forms.Button();
            this.talpa1 = new System.Windows.Forms.Button();
            this.talpa2 = new System.Windows.Forms.Button();
            this.talpa3 = new System.Windows.Forms.Button();
            this.talpa4 = new System.Windows.Forms.Button();
            this.talpa5 = new System.Windows.Forms.Button();
            this.talpa6 = new System.Windows.Forms.Button();
            this.talpa7 = new System.Windows.Forms.Button();
            this.talpa8 = new System.Windows.Forms.Button();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.punteggio = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uccidi la talpa!";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(109, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(109, 51);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // controllo
            // 
            this.controllo.AutoSize = true;
            this.controllo.Location = new System.Drawing.Point(257, 84);
            this.controllo.Name = "controllo";
            this.controllo.Size = new System.Drawing.Size(16, 13);
            this.controllo.TabIndex = 12;
            this.controllo.Text = "...";
            // 
            // colpito
            // 
            this.colpito.AutoSize = true;
            this.colpito.Location = new System.Drawing.Point(318, 84);
            this.colpito.Name = "colpito";
            this.colpito.Size = new System.Drawing.Size(16, 13);
            this.colpito.TabIndex = 13;
            this.colpito.Text = "...";
            // 
            // abilita
            // 
            this.abilita.Location = new System.Drawing.Point(447, 49);
            this.abilita.Name = "abilita";
            this.abilita.Size = new System.Drawing.Size(90, 48);
            this.abilita.TabIndex = 14;
            this.abilita.Text = "abilita";
            this.abilita.UseVisualStyleBackColor = true;
            this.abilita.Click += new System.EventHandler(this.abilita_Click);
            // 
            // talpa1
            // 
            this.talpa1.BackColor = System.Drawing.Color.Transparent;
            this.talpa1.Location = new System.Drawing.Point(53, 189);
            this.talpa1.Name = "talpa1";
            this.talpa1.Size = new System.Drawing.Size(131, 111);
            this.talpa1.TabIndex = 15;
            this.talpa1.UseVisualStyleBackColor = false;
            this.talpa1.Click += new System.EventHandler(this.talpa1_Click);
            // 
            // talpa2
            // 
            this.talpa2.BackColor = System.Drawing.Color.Transparent;
            this.talpa2.Location = new System.Drawing.Point(243, 189);
            this.talpa2.Name = "talpa2";
            this.talpa2.Size = new System.Drawing.Size(131, 111);
            this.talpa2.TabIndex = 16;
            this.talpa2.UseVisualStyleBackColor = false;
            this.talpa2.Click += new System.EventHandler(this.talpa2_Click);
            // 
            // talpa3
            // 
            this.talpa3.BackColor = System.Drawing.Color.Transparent;
            this.talpa3.Location = new System.Drawing.Point(426, 189);
            this.talpa3.Name = "talpa3";
            this.talpa3.Size = new System.Drawing.Size(131, 111);
            this.talpa3.TabIndex = 17;
            this.talpa3.UseVisualStyleBackColor = false;
            this.talpa3.Click += new System.EventHandler(this.talpa3_Click);
            // 
            // talpa4
            // 
            this.talpa4.BackColor = System.Drawing.Color.Transparent;
            this.talpa4.Location = new System.Drawing.Point(630, 189);
            this.talpa4.Name = "talpa4";
            this.talpa4.Size = new System.Drawing.Size(131, 111);
            this.talpa4.TabIndex = 18;
            this.talpa4.UseVisualStyleBackColor = false;
            this.talpa4.Click += new System.EventHandler(this.talpa4_Click);
            // 
            // talpa5
            // 
            this.talpa5.BackColor = System.Drawing.Color.Transparent;
            this.talpa5.Location = new System.Drawing.Point(53, 356);
            this.talpa5.Name = "talpa5";
            this.talpa5.Size = new System.Drawing.Size(131, 111);
            this.talpa5.TabIndex = 19;
            this.talpa5.UseVisualStyleBackColor = false;
            this.talpa5.Click += new System.EventHandler(this.talpa5_Click);
            // 
            // talpa6
            // 
            this.talpa6.BackColor = System.Drawing.Color.Transparent;
            this.talpa6.Location = new System.Drawing.Point(243, 356);
            this.talpa6.Name = "talpa6";
            this.talpa6.Size = new System.Drawing.Size(131, 111);
            this.talpa6.TabIndex = 20;
            this.talpa6.UseVisualStyleBackColor = false;
            this.talpa6.Click += new System.EventHandler(this.talpa6_Click);
            // 
            // talpa7
            // 
            this.talpa7.BackColor = System.Drawing.Color.Transparent;
            this.talpa7.Location = new System.Drawing.Point(426, 356);
            this.talpa7.Name = "talpa7";
            this.talpa7.Size = new System.Drawing.Size(131, 111);
            this.talpa7.TabIndex = 21;
            this.talpa7.UseVisualStyleBackColor = false;
            this.talpa7.Click += new System.EventHandler(this.talpa7_Click);
            // 
            // talpa8
            // 
            this.talpa8.BackColor = System.Drawing.Color.Transparent;
            this.talpa8.Location = new System.Drawing.Point(630, 356);
            this.talpa8.Name = "talpa8";
            this.talpa8.Size = new System.Drawing.Size(131, 111);
            this.talpa8.TabIndex = 22;
            this.talpa8.UseVisualStyleBackColor = false;
            this.talpa8.Click += new System.EventHandler(this.talpa8_Click);
            // 
            // Tempo
            // 
            this.Tempo.Interval = 1000;
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Punteggio";
            // 
            // punteggio
            // 
            this.punteggio.AutoSize = true;
            this.punteggio.Location = new System.Drawing.Point(725, 12);
            this.punteggio.Name = "punteggio";
            this.punteggio.Size = new System.Drawing.Size(16, 13);
            this.punteggio.TabIndex = 24;
            this.punteggio.Text = "...";
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "tempo rimanente:";
            // 
            // tem
            // 
            this.tem.AutoSize = true;
            this.tem.Location = new System.Drawing.Point(771, 49);
            this.tem.Name = "tem";
            this.tem.Size = new System.Drawing.Size(0, 13);
            this.tem.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 500);
            this.Controls.Add(this.tem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.punteggio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.talpa8);
            this.Controls.Add(this.talpa7);
            this.Controls.Add(this.talpa6);
            this.Controls.Add(this.talpa5);
            this.Controls.Add(this.talpa4);
            this.Controls.Add(this.talpa3);
            this.Controls.Add(this.talpa2);
            this.Controls.Add(this.talpa1);
            this.Controls.Add(this.abilita);
            this.Controls.Add(this.colpito);
            this.Controls.Add(this.controllo);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label controllo;
        private System.Windows.Forms.Label colpito;
        private System.Windows.Forms.Button abilita;
        private System.Windows.Forms.Button talpa1;
        private System.Windows.Forms.Button talpa2;
        private System.Windows.Forms.Button talpa3;
        private System.Windows.Forms.Button talpa4;
        private System.Windows.Forms.Button talpa5;
        private System.Windows.Forms.Button talpa6;
        private System.Windows.Forms.Button talpa7;
        private System.Windows.Forms.Button talpa8;
        private System.Windows.Forms.Timer Tempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label punteggio;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tem;
    }
}

