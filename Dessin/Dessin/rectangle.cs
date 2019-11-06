using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessin
{
    class Rectangle : Forme
    {
        private double longueur;
        private double largeur;

        public Rectangle(double uneLongueur, double uneLargeur, int unID) : base(unID)
        {
            this.longueur = uneLongueur;
            this.largeur = uneLargeur;
        }

        public double Longueur { get => longueur; set => longueur = value; }
        public double Largeur { get => largeur; set => largeur = value; }

        protected override double perimetre()
        {
            double perirmetre = (this.largeur + this.longueur) * 2;
            return perirmetre;
        }

        protected override double surface()
        {
            double surface = this.longueur * this.largeur;
            return surface;
        }

        protected new Point LaPosition { get => laPosition; set => laPosition = value; }
    }
}
