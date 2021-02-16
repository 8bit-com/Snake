using System;
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

        void PrintField()
        {
            for (int i = 0;  i < WIDTH; i++)
            {
                PrintPoint(Blue, i, 0);
                PrintPoint(Blue, i, HIGHT - 1);

                if (i < HIGHT)
                {
                    PrintPoint(Blue, 0, i);
                    PrintPoint(Blue, WIDTH - 1, i);
                }   
            }
        }
        void PrintPoint( ConsoleColor color, int X, int Y )
        {
            BackgroundColor = color;
            SetCursorPosition( X, Y );
            Write(' ');
        }

        void Print(bool visible)
        {
            CursorVisible = false;

            PrintObj(snake, visible);
            PrintObj(apple, visible);
        }

        void PrintObj<T>(T obj, bool visible) where T : GameObj
        {
            foreach (var item in obj.arr) 
                PrintPoint(visible? obj.color : Black, item.X, item.Y);
        }

        public void Start()
        {
            PrintField();

            timer.Interval = 200;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick()
        {
            Print(false);

            snake.arr[0].X++;

            Print(true);
        }
    }
}