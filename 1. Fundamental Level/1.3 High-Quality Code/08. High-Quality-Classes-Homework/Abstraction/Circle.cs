namespace Abstraction
{
    using System;

    class Circle : Figure
    {
        public Circle()
            : base(0)
        {
        }

        public Circle(double radius)
            : base(radius)
        {
        }

        public override double Width
        {
            get
            {
                throw new NotImplementedException("Circle does not have property Width!");
            }
        }

        public override double Height
        {
            get
            {
                throw new NotImplementedException("Circle does not have property Height!");
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * base.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * base.Radius * base.Radius;
            return surface;
        }
    }
}
