using static System.Threading.Thread;

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

                Sleep(Interval);

            } while (true);
        }
    }
}
