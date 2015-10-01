using System;
using ShapesApp.Interfaces;

namespace ShapesApp.Shapes
{
    public class Circle : IShape
    {
        private  double _radious;

        /// <summary>
        /// Gets or sets the radious.
        /// </summary>
        /// <value>
        /// The radious.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Radious can't be under 1!</exception>
        public double Radious
        {
            get { return _radious; }
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Radious can't be under 1!");
                }

                _radious = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radious">The radious.</param>
        public Circle(double radious)
        {
            _radious = radious;
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            var area = Math.PI*Math.Pow(Radious, 2);

            return area;
        }

        public double CalculatePerimeter()
        {
            var perimeter = 2*Math.PI*Radious;

            return perimeter;
        }
    }
}
