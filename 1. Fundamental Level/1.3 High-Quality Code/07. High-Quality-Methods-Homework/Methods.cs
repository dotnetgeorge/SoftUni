using System;
using System.Linq;

namespace Methods
{
    class Methods
    {
        /// <summary>
        /// Calculates the triangle area.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                return -1;
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Numbers to digit.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }

            //return "Invalid number!";
        }

        /// <summary>
        /// Finds the maximum.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <returns></returns>
        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                return -1;
            }

            //for (int i = 1; i < elements.Length; i++)
            //{
            //    if (elements[i] > elements[0])
            //    {
            //        elements[0] = elements[i];
            //    }
            //}

            //return elements[0];
            int findMax = elements.OrderByDescending(x => x).FirstOrDefault();

            return findMax;
        }

        /// <summary>
        /// Prints as number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="format">The format.</param>
        /// <exception cref="ArgumentException">Invalid format!</exception>
        static void PrintAsNumber(object number, string format)
        {

            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException(nameof(format), "Invalid format!");
            }
        }


        /// <summary>
        /// Calculates the distance.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="isHorizontal">if set to <c>true</c> [is horizontal].</param>
        /// <param name="isVertical">if set to <c>true</c> [is vertical].</param>
        /// <returns></returns>
        static double CalcDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            if (x1 <= 0 || y1 <= 0 || x2 <= 0 || y2 <= 0)
            {
                Console.Error.WriteLine("Points ");
                return -1;
            }

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
