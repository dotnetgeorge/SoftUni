using System;
using System.Collections.Generic;
using ShapesApp.Interfaces;
using ShapesApp.Shapes;

namespace ShapesApp
{
    internal class TestShapesApp
    {
        private static void Main()
        {
            var shapes = new List<IShape>();

            InitializeShapes(ref shapes);

            PrintShapes(shapes);
        }

        public static void InitializeShapes(ref List<IShape> shapes)
        {
            shapes.Add(new Circle(3));
            shapes.Add(new Circle(6));
            shapes.Add(new Rhombus(10, 7));
            shapes.Add(new Rhombus(8, 5));
            shapes.Add(new Rectangle(6, 4));
            shapes.Add(new Rectangle(8, 6));
        }

        public static void PrintShapes(List<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("Type: {0}", shape.GetType().ToString().Replace("ShapesApp.Shapes.", string.Empty));
                Console.WriteLine("Area: {0:F2}", shape.CalculateArea());
                Console.WriteLine("Perimeter: {0:F2}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}