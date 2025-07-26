using System.ComponentModel;
using System.Drawing;

namespace OOP_Assignment02
{
    internal class Program
    {
        static Point CreatePoint()
        {
            Point point = new Point();
            point.X = double.Parse(Console.ReadLine());
            point.Y = double.Parse(Console.ReadLine());
            return point;
            }

        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        static void Main(string[] args)
        {
            #region Q2 Create a struct called "Point" to represent a 2D point with properties "X" and "Y".Write a C# program that takes two points as input from the user and calculates the distance between them.
            Console.WriteLine("Please enter data for the first point");
            Point p1 = CreatePoint();
            Console.WriteLine("Please enter data for the second point");
            Point p2 = CreatePoint();

            Console.WriteLine(CalculateDistance(p1, p2));
            #endregion

        }
    }
}
