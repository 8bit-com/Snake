using System;
using System.Threading;
using static Snake.Const;
using static System.Console;
using static System.ConsoleColor;

namespace Snake
{
    public delegate void UI();

    class Game
    {
        Field field = new Field(HIGHT, WIDTH);

        Snake snake = new Snake();

        Timer timer = new Timer();

        void PrintPoint( int i, int X, int Y )
        {
            ConsoleColor[] colors = { Black, DarkGray, Green, DarkGreen, Red };

            BackgroundColor = colors[i];

            SetCursorPosition( X, Y );

            Write(' ');
        }
        void PrintField(Point[][] arr)
        {
            for (int Y = 0; Y < arr.Length; Y++)
            {
                for (int X = 0; X < arr[0].Length; X++)
                {
                    PrintPoint((int)arr[Y][X], X, Y);
                }
            }
        }
        public void Start()
        {
            timer.Interval = 200;

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick()
        {
            PrintField(field.arr);
        }
    }
}