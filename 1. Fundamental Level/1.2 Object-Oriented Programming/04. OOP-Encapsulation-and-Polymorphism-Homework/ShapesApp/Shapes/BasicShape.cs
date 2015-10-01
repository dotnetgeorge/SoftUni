using System;
using ShapesApp.Interfaces;

namespace ShapesApp.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double _width;
        private double _height;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicShape"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected BasicShape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Width can not be under 1!</exception>
        public double Width
        {
            get
            {
                return _width;
            }
            protected set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Width can not be under 1!");
                }

                _width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Height can not be under 1!</exception>
        public double Height
        {
            get
            {
                return _height;
            }
            protected set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Height can not be under 1!");
                }

                _height = value;
            }
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns></returns>
        public abstract double CalculatePerimeter();
    }
}
