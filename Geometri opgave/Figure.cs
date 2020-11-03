using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_opgave
{
    //super class that contains the two methods used for calculating area and perimeter
    public abstract class Figure
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
    }
}
