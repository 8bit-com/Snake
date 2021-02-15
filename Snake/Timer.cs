using System.Threading;

namespace Snake
{
    public delegate void UI();
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
