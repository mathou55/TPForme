using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin
{
    public abstract class Forme 
    {
        protected int id;
        protected Point laPosition;

        public Forme(int unID)
        {
            this.id = unID;
        }

        protected int Id { get => id; set => id = value; }
        protected Point LaPosition { get => laPosition; set => laPosition = value; }

        protected abstract double perimetre();
        protected abstract double surface();
    }
 
}
