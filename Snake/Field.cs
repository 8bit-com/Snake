using static Snake.Const;
using static Snake.Const.Point;

namespace Snake
{
    class Field
    {
        public Point[][] arr;

        public Field(int hight, int width)
        {
            arr = new Point[hight][];

            for (int Y = 0; Y < arr.Length; Y++)
            {
                arr[Y] = new Point[width];

                for (int X = 0; X < arr[Y].Length; X++)
                {
                    arr[Y][X] = SPACE;
                }
            }

            for (int X = 0; X < arr[0].Length; X++)
            {
                arr[0][X] = BORDER;

                arr[arr.Length - 1][X] = BORDER;
            }

            for (int Y = 0; Y < arr.Length; Y++)
            {
                arr[Y][0] = BORDER;

                arr[Y][arr[0].Length - 1] = BORDER;
            }
        }
    }
}