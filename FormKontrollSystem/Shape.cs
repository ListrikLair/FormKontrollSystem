using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrollSystem
{
    internal abstract class Shape
    {
        internal string Name { get; }
        internal string Color { get; }

        protected Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }

        internal abstract double CalcArea();
    }
}
