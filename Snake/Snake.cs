using static Snake.Const;
using System;

namespace Snake
{
    struct Cord
    {
        public int X;
        public int Y;
    }

    class GameObj
    {
        public Cord[] arr = new Cord[1];

        public ConsoleColor color = ConsoleColor.Green;
    }
    class Snake: GameObj
    {
        public Snake()
        {
            arr[0].X = 5;
            arr[0].Y = 5;
        }
    }

    class Apple: GameObj
    {
        public Apple()
        {
            color = ConsoleColor.Yellow;
            Replace();
        }

        public void Replace()
        {
            arr[0].X = random.Next(2, WIDTH);
            arr[0].Y = random.Next(2, HIGHT);
        }
    }
}
