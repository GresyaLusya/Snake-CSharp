using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapHight;
        int mapWidth;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapHight, int mapWidth, char sym)
        {
            this.mapHight = mapHight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapHight - 4);
            int y = random.Next(2, mapWidth - 4);
            return new Point(x, y, sym);
        }
    }
}
