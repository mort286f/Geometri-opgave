using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    public class Rectangle : Quadrangle
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public Rectangle(double a, double b) : base (a)
        {

        }

        //calculates the area of the square
        public override double CalculateArea()
        {
            return (A * 2) + (B * 2);
        }

        //calculates the perimeter of the square
        public override double CalculatePerimeter()
        {
            return A * B;
        }
    }
}
