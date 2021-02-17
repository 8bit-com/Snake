using static System.Threading.Thread;
using static Snake.Const;
using System;

namespace Snake
{
    public delegate void Time();
    class Timer
    {
        public event Time Tick;
        public int Interval { get; set; }
        public void Start()
        {
            do
            {
                Tick();

                Sleep(Interval);

            } while (key != (int)ConsoleKey.Escape);
        }
    }
}