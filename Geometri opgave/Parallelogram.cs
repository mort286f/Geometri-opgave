using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    class Parallelogram : Quadrangle
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double v;

        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public Parallelogram(int a, int b, double v) : base (a)
        {
            this.A = a;
            this.B = b;
            this.V = v;
        }

        //calculates the area of the square
        public override double CalculateArea()
        {
            return A * B * Math.Sin(V);
        }

        //calculates the perimeter of the square
        public override double CalculatePerimeter()
        {
            return (A * 2) + (B * 2);
        }
    }
}
