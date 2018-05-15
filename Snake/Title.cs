using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Title
    {
        public Title()
        {
            Console.SetWindowSize(75, 30);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.Title = "Snake the Game";
        }

        public void Menu()
        {
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("SNAKE THE GAME\n");
            Console.SetCursorPosition(24, 14);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Нажми Enter для начала игры");

            Console.ReadLine();

            Console.Clear();

            Walls walls = new Walls();
            walls.Draw();

            Console.SetCursorPosition(15, 10);
            Console.Write("Управление: единичное короткое нажатие на стрелки\n");
            Console.SetCursorPosition(27, 12);
            Console.Write("UP DOWN LEFT RIGHT\n");
            Console.SetCursorPosition(27, 16);
            Console.Write("Жми Enter и погнали!");
            Console.ReadLine();
            Console.Clear();

            walls.Draw();


        }

        public void GameOver(Walls walls, Snake snake)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            walls.Draw();
            Console.SetCursorPosition(25, 10);
            Console.Write("=======================");
            Console.SetCursorPosition(28, 12);
            Console.Write("G A M E   O V E R");
            Console.SetCursorPosition(33, 14);
            Console.Write("Счет: {0}", snake.Score());
            Console.SetCursorPosition(25, 16);
            Console.Write("=======================");
            Console.ReadLine();
           
        }

    }
}
