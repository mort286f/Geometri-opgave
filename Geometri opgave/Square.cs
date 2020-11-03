using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    public class Square : Quadrangle
    {
        public Square(double a) : base (a)
        {

        }

        //calculates the perimeter of the square
        public override double CalculatePerimeter()
        {
            return A + A + A + A;
        }

        //calculates the area of the square
        public override double CalculateArea()
        {
            return A * 4;
        }
    }
}
