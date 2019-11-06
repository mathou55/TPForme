using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int unX, int unY)
        {
            this.x = unX;
            this.y = unY;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        
    }

}
