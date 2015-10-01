using System;
using Point3DProject.Data;

namespace Point3DProject
{
    class TestPoint3D
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point3D(10, 15, 20);
            var secondPoint = new Point3D(25, 30, 35);

            var distance = Point3D.DistanceCalculator(firstPoint, secondPoint);

            Console.WriteLine(distance);
        }
    }
}
