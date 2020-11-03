using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    public abstract class Quadrangle : Figure
    {
        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public Quadrangle(double a)
        {
            this.A = a;
        }
    }
}
