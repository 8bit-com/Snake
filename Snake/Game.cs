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
            snake.Step();

            Colision();
            
            Print(true);
        }

        void Colision()
        {
            int snakeX = snake.arr[0].X;
            int snakeY = snake.arr[0].Y;
            int appleX = apple.arr[0].X;
            int appleY = apple.arr[0].Y;

            if (snakeX == appleX & snakeY == appleY)
            {
                apple.Replace();
                snake.ReSize();
                snake.Step();
            }
        }
    }
}