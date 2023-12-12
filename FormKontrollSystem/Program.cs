using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FormKontrollSystem
{
    class Program
    {
        private static List<Shape> shapes = new();
        static void Main(string[] args)
        {
            InitData();
            ShowList();
            Console.WriteLine("All shapes area combined: " + CalculateAllArea());
            SortListByArea();
            SortListByColor();
            Console.ReadKey();
        }
        private static void InitData()
        {
            shapes.Add(new Circle("Small circle", "Blue", 5));
            shapes.Add(new Circle("Big circle", "Green", 25));
            shapes.Add(new Rectangle("Small rectangle", "Red", 6, 4.5));
            shapes.Add(new Rectangle("Big rectangle", "Green", 14.6, 9));
            shapes.Add(new Triangle("Small triangle", "Blue", 3, 3.5));
            shapes.Add(new Triangle("Big triangle", "Red", 10, 10));
        }

        private static void ShowList()
        {
            Console.WriteLine("Original list:");
            foreach (Shape shape in shapes)
            {
                if (shape == shapes[0]){Console.WriteLine();}
                Console.WriteLine($"Name: {shape.Name} -- Color: {shape.Color} -- Area: {shape.CalcArea()}");
            }
        }

        private static double CalculateAllArea()
        {
            double totalArea = 0;
            foreach (Shape shape in shapes)
            {
                totalArea += shape.CalcArea();
            }
            return totalArea;
        }

        private static void SortListByArea()
        {
            Console.WriteLine("\nList Sorted by area");
            List<Shape> sortedList = shapes.OrderBy(shape => shape.CalcArea()).ToList();
            foreach (var shape in sortedList)
            {
                if (shape == sortedList[0]){Console.WriteLine();}
                Console.WriteLine($"Name: {shape.Name} -- Color: {shape.Color} -- Area: {shape.CalcArea()}");
            }
        }

        private static void SortListByColor()
        {
            Console.WriteLine("\nList Sorted by color");
            List<Shape> sortedList = shapes.OrderBy(shape => shape.Color).ToList();
            foreach (var shape in sortedList)
            {
                if (shape == sortedList[0]){Console.WriteLine();}
                Console.WriteLine($"Name: {shape.Name} -- Color: {shape.Color} -- Area: {shape.CalcArea()}");
            }
        }
    }
}