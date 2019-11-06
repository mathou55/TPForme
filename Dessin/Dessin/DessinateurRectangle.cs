using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Dessin
{
    class DessinateurRectangle : IDessinateur
    {

        public void dessiner(Forme f, Control c)
        {
            Rectangle r = (Rectangle)f;
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = c.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(50, 20, (int) r.Longueur, (int) r.Largeur));
            myBrush.Dispose();
        }
        
    }
}
