namespace Point3DProject.Data
{
    using System;

    public class Point3D
    {
        private readonly double _pointX;
        private readonly double _pointY;
        private readonly double _pointZ;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D"/> class.
        /// </summary>
        /// <param name="pointX">The point x.</param>
        /// <param name="pointY">The point y.</param>
        /// <param name="pointZ">The point z.</param>
        public Point3D(double pointX, double pointY, double pointZ)
        {
            _pointX = pointX;
            _pointY = pointY;
            _pointZ = pointZ;
        }

        /// <summary>
        /// Gets the get start point.
        /// </summary>
        /// <value>
        /// The get start point.
        /// </value>
        public static Point3D GetStartPoint { get; } = new Point3D(0, 0, 0);

        /// <summary>
        /// Distances the calculator.
        /// </summary>
        /// <param name="firstPoint">The first point.</param>
        /// <param name="secondPoint">The second point.</param>
        /// <returns></returns>
        public static double DistanceCalculator(Point3D firstPoint, Point3D secondPoint)
        {
            var deltaX = secondPoint._pointX - firstPoint._pointX;
            var deltaY = secondPoint._pointY - firstPoint._pointY;
            var deltaZ = secondPoint._pointZ - firstPoint._pointZ;

            var distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));

            return distance;
        }
    }
}