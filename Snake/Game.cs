using static Snake.Const;
using static System.Console;
using static System.ConsoleColor;
using System;

namespace Snake
{
    class Game
    {
        void PrintPoint( Point point, int X, int Y )
        {
            ConsoleColor[] colors = { Black, DarkGray, Green, DarkGreen, Red };

            BackgroundColor = colors[ (int)point ];

            SetCursorPosition( X, Y );

            Write(' ');

            Write(' ');
        }
        void PrintField(Point[][] arr)
        {
            for (int Y = 0; Y < arr.Length; Y++)
            {
                for (int X = 0; X < arr[0].Length; X++)
                {
                    PrintPoint(arr[Y][X], X, Y);
                }
            }
        }
        public void Start()
        {
            Field field = new Field(HIGHT, WIDTH);

            PrintField(field.arr);
        }
    }
}
