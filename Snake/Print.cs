using static System.ConsoleColor;
using static System.Console;
using static Snake.Const;

namespace Snake
{
    static class Print
    {
        public static void PrintPoint(int X, int Y)
        {
            SetCursorPosition(X, Y);
            Write(' ');
        }

        public static void PrintField()
        {
            BackgroundColor = Blue;

            for (int i = 0; i < WIDTH; i++)
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

        public static void PrintObj<T>(T obj, bool visible) where T : GameObj
        {
            BackgroundColor = visible ? obj.color : Black;

            foreach (var item in obj.arr)
                PrintPoint(item.X, item.Y);
        }
    }
}
