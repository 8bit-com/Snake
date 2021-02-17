using System;
using static Snake.Const;

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

        public ConsoleColor color;

        public GameObj()
        {
            Replace();
        }
        public void Replace()
        {
            arr[0].X = rand.Next(2, WIDTH - 2);
            arr[0].Y = rand.Next(2, HIGHT - 2);
        }
    }
}
