using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls ()
        {
            wallList = new List<Figure>();

            Horizons horUp = new Horizons(3, 70, 1, '-');          
            Horizons horBottom = new Horizons(3, 70, 28, '-');           
            Verticals vertUp = new Verticals(2, 2, 27, '|');
            Verticals vertRight = new Verticals(70, 2, 27, '|');

            wallList.Add(horUp);
            wallList.Add(horBottom);
            wallList.Add(vertUp);
            wallList.Add(vertRight);

        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
