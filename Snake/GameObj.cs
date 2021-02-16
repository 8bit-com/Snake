using System;
using System.Collections.Generic;
using System.Text;

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
}
