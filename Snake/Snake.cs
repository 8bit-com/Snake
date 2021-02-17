using static System.ConsoleColor;
using static System.Console;
using static Snake.Const;

namespace Snake
{
    class Snake: GameObj
    {
        public delegate void Contr();
        public Contr contr;
        Contr[] contrs;        

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
        public void MoveRight() => arr[0].X+=2;
        public void MoveLeft()  => arr[0].X-=2;
        public void MoveDown()  => arr[0].Y++;
        public void MoveUp()    => arr[0].Y--;
        public void Step()
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i > 0) arr[i] = arr[i - 1];
            }
        }
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
        public void ReSize()
        {
            Cord[] newArr = new Cord[arr.Length + 1];

            arr.CopyTo(newArr, 0); 

            arr = newArr;
        }
    }
}