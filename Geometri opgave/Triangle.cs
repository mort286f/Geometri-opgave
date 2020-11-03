using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    public abstract class Triangle : Figure
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
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

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
    }
}
