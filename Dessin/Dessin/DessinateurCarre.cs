using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessin
{
    public class DessinateurCarre : IDessinateur
    {

        public void dessiner(Forme f, Control c)
        {
            Carre cr = (Carre)f;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            System.Drawing.Graphics formGraphics = c.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(50, 50, (int)cr.Cote, (int)cr.Cote));
            myBrush.Dispose();
        }
    }
}
