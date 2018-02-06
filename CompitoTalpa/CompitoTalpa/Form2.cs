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
        int pic = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void avanti_Click(object sender, EventArgs e)
        {
            if (pic == 0)
            {
                immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\inizio.JPEG";
            }
            else if (pic == 1) { immagine.ImageLocation = @"C:\Users\richi\source\repos\CompitoTalpa2\CompitoTalpa\Immagini\nana strana.JPG"; }
            pic = pic + 1;
        }
    }
}
