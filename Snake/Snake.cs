using System;

namespace Snake
{
    class Snake: GameObj
    {
        public Snake()
        {
            arr[0].X = 5;
            arr[0].Y = 5;
        }
        public void MoveRight() => arr[0].X++;
        public void MoveLeft()  => arr[0].X--;
        public void MoveDown()  => arr[0].Y++;
        public void MoveUp()    => arr[0].Y--;
    }
}
