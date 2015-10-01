namespace ShapesApp.Shapes
{
    public class Rectangle : BasicShape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            var area = Width * Height;

            return area;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            var perimeter = 2 * (Width + Height);

            return perimeter;
        }
    }
}
