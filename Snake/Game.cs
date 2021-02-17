using static Snake.Print;
using static System.Console;

namespace Snake
{
    class Game
    {        
        Timer timer = new Timer();
        Snake snake = new Snake();
        Apple apple = new Apple();
        void Print(bool visible)
        {
            CursorVisible = false;
            PrintObj(snake, visible);
            PrintObj(apple, visible);
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

            snake.Control();

            snake.contr();

            Print(true);
        }
    }
}