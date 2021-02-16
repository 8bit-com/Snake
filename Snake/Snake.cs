using static System.ConsoleColor;

namespace Snake
{
    class Snake: GameObj
    {
        public Snake()
        {
            color = Green;
        }
        public void MoveRight() => arr[0].X++;
        public void MoveLeft()  => arr[0].X--;
        public void MoveDown()  => arr[0].Y++;
        public void MoveUp()    => arr[0].Y--;
    }
}
