using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizons : Figure
    {
        public Horizons(int xLeft, int xRight, int y, char sym)
        {
            vList = new List<Point>();

            for (int i = xLeft; i < xRight; i++)
            {
                Point p = new Point(i, y, sym);
                vList.Add(p);
            }
                      
        }

    }
}
