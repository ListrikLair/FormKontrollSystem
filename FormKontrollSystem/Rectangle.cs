using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal class Rectangle : Shape
    {
        internal double Length { get; }
        internal double Width { get; }

        internal Rectangle(string name, string color, double length, double width) : base(name, color)
        {
            Length = length;
            Width = width;
        }

        internal override double CalcArea()
        {
            double area = Length*Width;
            return area;
        }
    }
}
