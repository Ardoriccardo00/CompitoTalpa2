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
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Tempo.Enabled = true;
            countdown.Enabled = true;
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
                
                talpa1.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);

                //System.Threading.Thread.Sleep(1000);
                //talpa1.BackColor = Color.FromArgb(255, 0, 0);

            }
            else
              if (numero == 2)
            {
                talpa2.BackColor = Color.FromArgb(0, 255, 33);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa2.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 3)
            {
                talpa3.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa3.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 4)
            {
                talpa4.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa4.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 5)
            {
                talpa5.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa5.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 6)
            {
                talpa6.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa6.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 7)
            {
                talpa7.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
                talpa8.BackColor = Color.FromArgb(255, 0, 0);
                //System.Threading.Thread.Sleep(1000);
                //talpa7.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            if (numero == 8)
            {
                talpa8.BackColor = Color.FromArgb(0, 255, 33);
                talpa2.BackColor = Color.FromArgb(255, 0, 0);
                talpa3.BackColor = Color.FromArgb(255, 0, 0);
                talpa4.BackColor = Color.FromArgb(255, 0, 0);
                talpa5.BackColor = Color.FromArgb(255, 0, 0);
                talpa6.BackColor = Color.FromArgb(255, 0, 0);
                talpa7.BackColor = Color.FromArgb(255, 0, 0);
                talpa1.BackColor = Color.FromArgb(255, 0, 0);
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
            lista.Text = "\npunti";
        }

        private void talpa1_Click(object sender, EventArgs e)
        {
            if (talpa1.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa1.BackColor == Color.FromArgb(255, 0, 0)) {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa2_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito2!";
            if (talpa2.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa2.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa3_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito3!";
            if (talpa3.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa3.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa4_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito4!";
            if (talpa4.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa4.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa5_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito5!";
            if (talpa5.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa5.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa6_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito6!";
            if (talpa6.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa6.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa7_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito7!";
            if (talpa7.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa7.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void talpa8_Click(object sender, EventArgs e)
        {
            colpito.Text = "Colpito8!";
            if (talpa8.BackColor == Color.FromArgb(0, 255, 33))
            {
                punti = punti + 1;
                punteggio.Text = Convert.ToString(punti);
            }
            else if (talpa8.BackColor == Color.FromArgb(255, 0, 0))
            {
                punti = punti - 1;
                punteggio.Text = Convert.ToString(punti);
            }
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            temp = temp - 1;
            Ttempo.Text = Convert.ToString(temp);
            if (temp == 0) { MessageBox.Show("Tempo scaduto!");
                lista.Text = "\npunti";
            }
            
        }
    }
}
