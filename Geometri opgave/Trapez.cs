using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    class Trapez : Quadrangle
    {
        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        private double d;

        public double D
        {
            get { return d; }
            set { d = value; }
        }

        public Trapez(double a, double b, double c, double d) : base (a)
        {
            this.B = b;
            this.C = c;
            this.D = d;
        }

        public double FindS()
        {
            return (A + B - C + D) / 2;
        }

        //finds the s variable that is used the find the area in a trapez
        public double FindH()
        {
            double s = FindS();
            return (2 / (A - C)) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - D));
        }

        //calculates the area of the square
        public override double CalculateArea()
        {
            return 0.5 * (A + C) * FindH();
        }

        //calculates the perimeter of the square
        public override double CalculatePerimeter()
        {
            return A + B + C + D;
        }
    }
}
