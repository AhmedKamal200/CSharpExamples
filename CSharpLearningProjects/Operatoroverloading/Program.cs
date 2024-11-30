using System;

namespace Operatoroverloading
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // تعريف عملية الجمع (+) بين نقطتين
        public static Point operator +(Point p1, Point p2)
        {
            return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point { X = 5, Y = 10 };
            Point p2 = new Point { X = 3, Y = 7 };

            // استخدام الـ Overloaded Operator +
            Point result = p1 + p2;

            Console.WriteLine($"X: {result.X}, Y: {result.Y}");
        }
    }

}
