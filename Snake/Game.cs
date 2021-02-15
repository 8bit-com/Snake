using System;
using System.Threading;
using static Snake.Const;
using static System.Console;
using static System.ConsoleColor;

namespace Snake
{
    class Game
    {
        Timer timer = new Timer();

        Snake snake = new Snake();

        Apple apple = new Apple();

        void PrintPoint( ConsoleColor color, int X, int Y )
        {
            BackgroundColor = color;

            SetCursorPosition( X, Y );

            Write(' ');
        }

        void Print()
        {
            CursorVisible = false;

            foreach (var item in snake.arr)            
                PrintPoint(snake.color, item.X, item.Y);

            PrintPoint(apple.color, apple.cord.X, apple.cord.Y);
        }
        public void Start()
        {

            timer.Interval = 200;

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick()
        {
            Print();

            snake.arr[0].X++;
        }
    }
}