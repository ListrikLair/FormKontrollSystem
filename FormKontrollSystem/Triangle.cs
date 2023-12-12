using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Triangle : Shape
    {
        internal double BaseWidth { get; }
        internal double Height { get; }

        internal Triangle(string name, string color, double baseWidth, double height) : base(name, color)
        {
            BaseWidth = baseWidth;
            Height = height;
        }

        internal override double CalcArea()
        {
            double area = BaseWidth * Height / 2;
            return area;
        }
    }
}
