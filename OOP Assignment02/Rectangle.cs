using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment02
{
    internal struct Rectangle
    {
        private double width;
        private double height;


        public double Width
        {
            get { return width; }
            set
            {
                if(value >= 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }

            }

        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                    height = value;
                else
                  Console.WriteLine("Error: Width cannot be negative.");

            }

        }


        public double Area
        {
            get
            {
                return width * height;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
