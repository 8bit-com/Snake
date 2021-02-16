using System;
using static Snake.Const;
using static System.Console;
using static System.ConsoleColor;
using static System.ConsoleKey;

namespace Snake
{
    public delegate void Contr();
    class Game
    {
        Timer timer = new Timer();
        static Snake snake = new Snake();
        Apple apple = new Apple();
        Contr contr = new Contr(snake.MoveRight);

        void PrintField()
        {
            BackgroundColor = Blue;

            for (int i = 0;  i < WIDTH; i++)
            {
                PrintPoint(i, 0);
                PrintPoint(i, HIGHT - 1);

                if (i < HIGHT)
                {
                    PrintPoint(0, i);
                    PrintPoint(WIDTH - 1, i);
                }   
            }
        }
        void PrintPoint(int X, int Y )
        {
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
            BackgroundColor = visible ? obj.color : Black;

            foreach (var item in obj.arr) 
                PrintPoint(item.X, item.Y);
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

            GameControl();

            contr();

            Print(true);
        }
        private void GameControl()
        {
            if (KeyAvailable)
            {
                key = ReadKey(true).Key;

                Contr[] contrs =
                {
                    snake.MoveLeft,
                    snake.MoveUp,
                    snake.MoveRight,
                    snake.MoveDown
                };

                contr = contrs[(int)key - 37];
            }
        }
    }
}