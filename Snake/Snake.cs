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
        public void MoveRight() => Move(ref arr[0].X, true,  true );
        public void MoveLeft()  => Move(ref arr[0].X, true,  false);
        public void MoveDown()  => Move(ref arr[0].Y, false, true );
        public void MoveUp()    => Move(ref arr[0].Y, false, false);      
        void Move(ref int cord, bool dirXY, bool dirPM)
        {
            int limit = dirXY ? WIDTH - 2 : HIGHT - 1;
            int step  = dirXY ? 2 : 1;
            int istep = dirPM ? cord + step : cord - step;
            int bordr = dirPM ? step : limit;
            bool cond = dirPM ? (cord < limit) : (cord > step);

            cord = cond ? istep : bordr;
        }
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