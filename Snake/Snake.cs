using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tall, int length, Direction _direction)
        {
            direction = _direction;
            vList = new List<Point>();
            for (int i = 0; i<length; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                vList.Add(p);
            }
        }

        internal void Move()
        {
            Point tall = vList.First();
            vList.Remove(tall);
            Point head = GetNextPoint();
            vList.Add(head);

            tall.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = vList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {               
                vList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool IsHitTail()
        {
            var head = vList.Last();
            for(int i = 0; i<vList.Count - 2; i++)
            {
                if (head.IsHit(vList[i]))
                    return true;
            }
            return false;
        }

        public int Score()

        {
            int score;
            if (vList.Count <= 4) return 0;
            else
            {
               score = vList.Count-4;
            }           
            return score;
        }
    }
}
