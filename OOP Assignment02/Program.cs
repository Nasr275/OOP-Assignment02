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
            #region
            Person[] people = new Person[3];
            people[0] = new Person("Nasr", 23);
            people[1] = new Person("Omar",24);
            people[2] = new Person("Adel",22);

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Person number {i+1} Name: {people[i].Name}");
                Console.WriteLine($"Person number {i+1} Age: {people[i].Age}");
            }

            #endregion


            #region Q2 Create a struct called "Point" to represent a 2D point with properties "X" and "Y".Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Please enter data for the first point");
            //Point p1 = CreatePoint();
            //Console.WriteLine("Please enter data for the second point");
            //Point p2 = CreatePoint();

            //Console.WriteLine($"Distance between the two points: {CalculateDistance(p1, p2)}");
            #endregion


            #region Q3 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //    Console.WriteLine();
            //}

            //Person oldest = people[0];

            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}
            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion
        }
    }
}
