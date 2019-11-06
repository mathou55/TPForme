using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin
{
    class Carre : Forme
    {
        private double cote;

        public Carre(double unCote, int unID) : base(unID)
        {
            this.Cote = unCote;
        }

        public double Cote { get => cote; set => cote = value; }

        protected override double perimetre()
        {
            double perimetre = 4 * this.cote;
            return perimetre;
        }

        protected override double surface()
        {
            double surface = this.cote * this.cote;
            return surface;
        }

        protected Point LaPosition { get => laPosition; set => laPosition = value; }
    }
}
