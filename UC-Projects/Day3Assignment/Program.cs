using System;

namespace Day3Assignment
{
    class Program
    //    {
    //        // Function to calculate distance
    //        static double distance(int x1, int y1, int x2, int y2)
    //        {
    //            // Calculating distance
    //            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
    //        }
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine(Math.Round(distance(5, 4, 4, 6)
    //                                   * 100000.0) / 100000.0);
    //        }
    //    }
    //}
    {
        static void Main(string[] args)
        {

            double x1 = 15d;
            double x2 = 8d;
            double y1 = 16d;
            double y2 = 10d;
            double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance);
        }
    }
}