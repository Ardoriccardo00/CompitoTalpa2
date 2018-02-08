using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompitoTalpa
{
    public partial class Form1 : Form
    {
        int punti = 0;
        int temp = 60;
        bool Stalpa1 = false;
        bool Stalpa2 = false;
        bool Stalpa3 = false;
        bool Stalpa4 = false;
        bool Stalpa5 = false;
        bool Stalpa6 = false;
        bool Stalpa7 = false;
        bool Stalpa8 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Tempo.Enabled = true;
            countdown.Enabled = true;
            talpa1.Enabled = true;
            talpa2.Enabled = true;
            talpa3.Enabled = true;
            talpa4.Enabled = true;
            talpa5.Enabled = true;
            talpa6.Enabled = true;
            talpa7.Enabled = true;
            talpa8.Enabled = true;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            int ticc = 0;

            Random r = new Random();
            int numero = r.Next(1, 8);
            controllo.Text = (r.Next(1, 8).ToString());
            ticc = ticc + 1;
            if (numero == 1)
            {
                Stalpa1 = true;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);

                //System.Threading.Thread.Sleep(1000);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);

            }
            else
              if (numero == 2)
            {
                Stalpa2 = true;
                Stalpa1 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa2.BackColor = Color.FromArgb(0, 255, 33);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 3)
            {
                Stalpa3 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa3.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 4)
            {
                Stalpa4 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa4.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 5)
            {
                Stalpa5 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa5.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 6)
            {
                Stalpa6 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa7 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa6.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 7)
            {
                Stalpa7 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa8 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.spooh;
                talpa8.Image = CompitoTalpa.Properties.Resources.otto;
                //talpa7.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 8)
            {
                Stalpa8 = true;
                Stalpa1 = false;
                Stalpa2 = false;
                Stalpa3 = false;
                Stalpa4 = false;
                Stalpa5 = false;
                Stalpa6 = false;
                Stalpa7 = false;
                talpa1.Image = CompitoTalpa.Properties.Resources.uno;
                talpa2.Image = CompitoTalpa.Properties.Resources.due;
                talpa3.Image = CompitoTalpa.Properties.Resources.tre;
                talpa4.Image = CompitoTalpa.Properties.Resources.quattro;
                talpa5.Image = CompitoTalpa.Properties.Resources.cinque;
                talpa6.Image = CompitoTalpa.Properties.Resources.sei;
                talpa7.Image = CompitoTalpa.Properties.Resources.sette;
                talpa8.Image = CompitoTalpa.Properties.Resources.spooh;
                //talpa8.BackColor = Color.FromArgb(0, 255, 33);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa8.BackColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void abilita_Click(object sender, EventArgs e)
        {
            talpa1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            talpa1.Enabled = false;
            talpa2.Enabled = false;
            talpa3.Enabled = false;
            talpa4.Enabled = false;
            talpa5.Enabled = false;
            talpa6.Enabled = false;
            talpa7.Enabled = false;
            talpa8.Enabled = false;
            Tempo.Enabled = false;
            countdown.Enabled = false;
            lista.Items.Add(punti);
            punti = 0;
        }

        private void talpa1_Click(object sender, EventArgs e)
        {
            if (Stalpa1 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa1 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa2_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito2!";
            if (Stalpa2 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa2 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa3_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito3!";
            if (Stalpa3 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa3 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa4_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito4!";
            if (Stalpa4 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa4 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa5_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito5!";
            if (Stalpa5 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa5 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa6_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito6!";
            if (Stalpa6 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa6 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa7_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito7!";
            if (Stalpa7 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa7 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa8_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito8!";
            if (Stalpa8 == true)
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (Stalpa8 == false)
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            temp = temp - 1;
            Ttempo.Text = Convert.ToString(temp);
            if (temp == 0)
            {
                MessageBox.Show("Tempo scaduto!");
                talpa1.Enabled = false;
                talpa2.Enabled = false;
                talpa3.Enabled = false;
                talpa4.Enabled = false;
                talpa5.Enabled = false;
                talpa6.Enabled = false;
                talpa7.Enabled = false;
                talpa8.Enabled = false;
                Tempo.Enabled = false;
                countdown.Enabled = false;
                lista.Items.Add(punti);
                punti = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tempo.Interval = 2000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tempo.Interval = 1000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tempo.Interval = 750;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tempo.Interval = 500;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Tempo.Interval = 500;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ops... questa modalità non è ancora finita...");
            if (textBox1.Text == "mostralol")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void vita_Click(object sender, EventArgs e)
        {
            label2.Text = "Vite: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
