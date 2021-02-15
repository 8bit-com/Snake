using static Snake.Const;
using System;

namespace Snake
{
    struct Cord
    {
        public int X;

        public int Y;
    }
    class Snake
    {
        public Cord[] arr = new Cord[1];

        public ConsoleColor color = ConsoleColor.Green;

        public Snake()
        {
            arr[0].X = 5;
            arr[0].Y = 5;
        }
    }

    class Apple
    {
        public Cord cord = new Cord();

        public ConsoleColor color = ConsoleColor.Yellow;

        public Apple()
        {
            Replace();
        }

        public void Replace()
        {
            cord.X = random.Next(2, WIDTH);
            cord.Y = random.Next(2, HIGHT);
        }
    }
}
