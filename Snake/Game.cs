using static Snake.Const;
using static System.Console;
using System;
namespace Snake
{
    class Game
    {
        void PrintPoint(Point point, int X, int Y)
        {
            ConsoleColor color;

            switch(point)
            {
                case Point.APPLE:
                    color = ConsoleColor.Red;
                    break;
                case Point.BORDER:
                    color = ConsoleColor.DarkGray;
                    break;
                case Point.HEAD:
                    color = ConsoleColor.DarkGreen;
                    break;
                case Point.SNAKE:
                    color = ConsoleColor.Green;
                    break;
                case Point.SPACE:
                    color = ConsoleColor.Black;
                    break;
                default:
                    color = ConsoleColor.Black;
                    break;
            }

            BackgroundColor = color;

            SetCursorPosition(X, Y);

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
