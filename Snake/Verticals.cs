using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Verticals : Figure
    {     
            public Verticals(int x, int yTop, int yBottom, char sym)
            {
                vList = new List<Point>();

                for (int i = yTop; i <= yBottom; i++)
                {
                    Point p = new Point(x, i, sym);
                    vList.Add(p);
                }


            }

        }
    }

