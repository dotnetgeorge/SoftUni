/*
 * Problem 13.	* Comparing Floats
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
 * Note that we cannot directly compare two floating-point numbers a and b by a==b 
 * because of the nature of the floating-point arithmetic.
 * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 
 * Examples:
 * 
 * Number a	Number b	Equal (with precision eps=0.000001)	Explanation
 * 5.3	6.01	false	The difference of 0.71 is too big (> eps)
 * 5.00000001	5.00000003	true	The difference 0.00000002 < eps
 * 5.00000005	5.00000001	true	The difference 0.00000004 < eps
 * -0.0000007	0.00000007	true	The difference 0.00000077 < eps
 * -4.999999	-4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
 * 4.999999	4.999998	false	Border case. The difference 0.000001 == eps. We consider the numbers are different.
 */
using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double eps = 0.000001;
        double firstNumber = 5.00000001;
        double secondNumber = 5.00000003;

        double absoluteFirst = Math.Abs(firstNumber);
        double absoluteSecond = Math.Abs(secondNumber);
        double absoluteDifference = Math.Abs(firstNumber - secondNumber);

        if(absoluteFirst == absoluteSecond)
        {
            Console.WriteLine(true);
        }
        else if (firstNumber == 0 || secondNumber == 0 || absoluteDifference < Double.MinValue)
        {
            // a or b is zero or both are extremely close to it
            // relative error is less meaningful here
            Console.WriteLine(absoluteDifference < (eps * Double.MinValue));
        }
        else
        { // use relative error
            Console.WriteLine(absoluteDifference / (absoluteFirst + absoluteSecond) < eps);
        }
    }
}