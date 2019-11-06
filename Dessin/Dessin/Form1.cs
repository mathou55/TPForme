using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessin
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics formGraphics;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), 3);
            DessinateurRectangle dr = new DessinateurRectangle();
            dr.dessiner(r, this.p_ardoise);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Carre c = new Carre(Convert.ToDouble(textBox3.Text), 1);
            DessinateurCarre dc = new DessinateurCarre();
            dc.dessiner(c, this.p_ardoise);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cercle cl = new Cercle(Convert.ToDouble(textBox4.Text), 2);
            DessinateurCercle dcl = new DessinateurCercle();
            dcl.dessiner(cl, this.p_ardoise);
        }

        private void P_ardoise_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
