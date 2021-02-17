using static Snake.Const;
using static System.Console;
using static System.ConsoleColor;

namespace Snake
{
    class Game
    {
        delegate void Contr();
        Timer timer = new Timer();
        Snake snake = new Snake();
        Apple apple = new Apple();
        Contr[] contrs;
        Contr contr;

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
            Init();

            PrintField();

            timer.Interval = 200;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        void Init()
        {
            contr  = new Contr(snake.MoveRight);
            contrs = new Contr[]
            { 
                snake.MoveLeft,
                snake.MoveUp,
                snake.MoveRight,
                snake.MoveDown
            };
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
                do
                {
                    key = (int)ReadKey(true).Key;
                } while (KeyAvailable);

                contr = (key > 36 && key < 41) ? contrs[key-37] : contr;
            }
        }
    }
}