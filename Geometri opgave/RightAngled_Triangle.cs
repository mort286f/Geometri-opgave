using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    class RightAngled_Triangle : Triangle
    {
        public RightAngled_Triangle(double a, double b, double c) : base (a, b, c)
        {

        }

        //calculates the perimeter of the square
        public override double CalculatePerimeter()
        {
            return A + B + C;
        }

        //calculates the area of the square
        public override double CalculateArea()
        {
            return 0.5 * A * B;
        }
    }
}
