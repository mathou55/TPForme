using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessin
{
    class DessinateurCercle : IDessinateur
    {
        public void dessiner(Forme f, Control c)
        {
            Cercle cl = (Cercle)f;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.Graphics formGraphics = c.CreateGraphics();
            Pen myPen = new Pen(Color.Green);
            formGraphics.DrawEllipse(myPen, 100, 100, 50, 50);
            myBrush.Dispose();
        }
    }
}
