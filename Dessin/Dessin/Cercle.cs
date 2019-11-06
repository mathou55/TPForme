using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin
{
    class Cercle : Forme
    {
        private double rayon;

        public Cercle(double unRayon, int unID) : base(unID)
        {
            this.Rayon = unRayon;
        }

        public double Rayon { get => rayon; set => rayon = value; }

        protected override double perimetre()
        {
            double perimetre = 2 * 3.14 * this.Rayon;
            return perimetre;
        }

        protected override double surface()
        {
            double surface = (this.Rayon * this.Rayon) * 3.14;
            return surface;
        }

        protected Point LaPosition { get => laPosition; set => laPosition = value; }
    }

}
