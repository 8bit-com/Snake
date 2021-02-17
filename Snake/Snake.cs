using static System.ConsoleColor;
using static System.Console;
using static Snake.Const;

namespace Snake
{
    class Snake: GameObj
    {
        public delegate void Contr();

        Contr[] contrs;
        public Contr contr;

        public Snake()
        {
            color = Green;
            contr = new Contr(MoveRight);
            contrs = new Contr[]
            {
                MoveLeft,
                MoveUp,
                MoveRight,
                MoveDown
            };
        }
        public void MoveRight() => arr[0].X++;
        public void MoveLeft()  => arr[0].X--;
        public void MoveDown()  => arr[0].Y++;
        public void MoveUp()    => arr[0].Y--;
        public void Control()
        {
            if (KeyAvailable)
            {
                do
                {
                    key = (int)ReadKey(true).Key;
                } while (KeyAvailable);

                contr = (key > 36 && key < 41) ? contrs[key - 37] : contr;
            }
        }
    }
}
