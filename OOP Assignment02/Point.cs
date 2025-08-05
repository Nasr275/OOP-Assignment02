using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment02
{
    internal struct Point
    {
        public double X { set; get;} 
        public double Y { set; get; }

        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return $"X : {X}, Y : {Y}";
        }
    } 
}
