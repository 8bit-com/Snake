using System;
using static Snake.Const;

namespace Snake
{
    class Apple : GameObj
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
