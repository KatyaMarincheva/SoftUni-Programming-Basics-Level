// Problem 6. Quadratic Equation

/*Write a program that reads the coefficients a, b and c 
 * of a quadratic equation ax2 + bx + c = 0 
 * and solves it (prints its real roots).

Examples:
 a 	    b 	    c 	roots
 2 	    5 	   -3 	x1=-3; x2=0.5
-1 	    3 	    0 	x1=3; x2=0
-0.5 	4 	   -8 	x1=x2=4
 5 	    2 	    8 	no real roots
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class QuadraticEquation
{
    // the quadratic equation is a second order of polynomial equation in a single variable 
    // x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a

    #region SolveQuadratic(double a, double b, double c)

    public static void SolveQuadratic(double a, double b, double c)
    {
        //Calculating the discriminant of the square root
        double discriminant = (b * b) - 4 * a * c;
        if (discriminant < 0)
        {
            // no real roots
            Console.WriteLine("\nThere are no real roots\n");
        }
        else
        {
            // if x1 == x2 : one real root
            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ? "\nOne real root {0}\n" : "\nTwo real roots: {0} and {1}\n", x1, x2);
        }
    }
    #endregion

    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string intro = @"The quadratic equation is a second order of polynomial equation
in a single variable: x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
Please, enter the values for a, b, and c.";
        Console.WriteLine(intro);

        string input;
        double number;

        double[] numbers = new double[3];

        // limits the number entries to 3, and numbers the input entries
        for (int i = 0; i < 3; i++)
        {
            do // validate input for number
            {
                Console.Write("\nPlease, enter value {0}: ", i + 1);
                input = Console.ReadLine().Replace(",", ".");

            } while (!double.TryParse(input, out number));

            numbers[i] = number; // adds the entered numbers into the numbers list 
        }

        // calling SolveQuadratic method
        SolveQuadratic(numbers[0], numbers[1], numbers[2]);
    }
}

