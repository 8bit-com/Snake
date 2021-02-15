using System.Threading;

namespace Snake
{
    class Timer
    {
        public event UI Tick;

        public int Interval { get; set; }

        public void Start()
        {
            do
            {
                Tick();

                Thread.Sleep(Interval);

            } while (true);
        }
    }
}
