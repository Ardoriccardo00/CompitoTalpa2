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
    public partial class Form2 : Form
    {
        int pic = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void avanti_Click(object sender, EventArgs e)
        {
            //if (pic == 0)
            //{
            //    immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\inizio.JPEG";
            //}
            //else if (pic == 1) { immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\nana strana.JPG"; }
            //pic = pic + 1;

            switch (pic) {
                case 1:
               immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\inizio.JPEG";
                    pic = pic + 1;
                    break;
                case 2:
                    immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\background1.png";
                    nanaStanca.Visible = true;
                    dialogo.Text = "...";
                    pic = pic + 1;
                    break;
                case 3:
                    dialogo.Text = "Che cos'è tutto questo rumore?";
                    pic = pic + 1;
                    break;
                case 4:
                    
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nanaStanca.Top = 10;
            nanaStanca.Left = 5;
        }
    }
}
