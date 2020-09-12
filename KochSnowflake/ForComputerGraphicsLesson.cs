using System;
using System.Collections.Generic;

namespace KochSnowflake
{
    static class ForComputerGraphicsLesson
    {
        public static MyPoint PerGraduses(MyPoint A, MyPoint B, double graduses)
        {
            double radians = graduses * (Math.PI / 180);
            //Используется матрица преобразования для поворота
            //  | cos  sin |
            //  |-sin  cos |
            List<MyPoint> temp = new List<MyPoint>();         
            temp.Add(new MyPoint((float)Math.Cos(radians), (float)Math.Sin(radians)));
            temp.Add(new MyPoint((float)-Math.Sin(radians), (float)Math.Cos(radians)));
            return Multiply(A, B, temp);
        }

        static public MyPoint Multiply(MyPoint A, MyPoint B, List<MyPoint> temp)
        {
            MyPoint result = new MyPoint();
            result.X = (B.X - A.X) * temp[0].X + (B.Y - A.Y) * temp[1].X + A.X;
            result.Y = (B.X - A.X) * temp[0].Y + (B.Y - A.Y) * temp[1].Y + A.Y;
            return result;
        }
    }
}
