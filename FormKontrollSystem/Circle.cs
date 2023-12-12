using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Circle : Shape
    {
        internal double Radius { get; }

        internal Circle(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

        internal override double CalcArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
