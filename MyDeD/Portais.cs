using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDeD
{
    public partial class Portais : Form
    {
        public Portais()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnVida_Click(object sender, EventArgs e)
        {
            VidaPessoal vida = new VidaPessoal();
            vida.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Voce voce = new Voce();
            voce.ShowDialog();//comentário
        }
    }
}
