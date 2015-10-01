namespace Point3DProject.Data
{
    using System.Collections.Generic;

    public class Path3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Path3D"/> class.
        /// </summary>
        public Path3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Path3D"/> class.
        /// </summary>
        /// <param name="point">The point.</param>
        public Path3D(Point3D point)
        {
            Point.Add(point);
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count => Point.Count;

        /// <summary>
        /// Gets the point.
        /// </summary>
        /// <value>
        /// The point.
        /// </value>
        public IList<Point3D> Point { get; } = new List<Point3D>();
    }
}