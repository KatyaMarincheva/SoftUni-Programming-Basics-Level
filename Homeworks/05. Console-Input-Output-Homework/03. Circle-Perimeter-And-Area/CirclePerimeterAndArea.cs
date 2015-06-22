// Problem 3. Circle Perimeter and Area

/* Write a program that reads the radius r of a circle 
 * and prints its perimeter and area 
 * formatted with 2 digits after the decimal point.

Examples:
r 	    perimeter 	area
2 	    12.57 	    12.57
3.5 	21.99 	    38.48
 */

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        string intro =
@"This program reads the radius r of a circle 
and prints its perimeter and area.";
        Console.WriteLine(intro);

        string input;
        float r;

        do // validates r input
        {
            Console.Write("\nPlease, enter a value for r: ");
            input = Console.ReadLine().Replace(",", ".");  // so that the program can recognize both ',' and '.' as decimal points

        } while (!float.TryParse(input, out r));

        Console.WriteLine("\nCircle with radius r = {0:F2}\nPerimeter {1:F2}; Area {2:F2}\n", r, 2 * Math.PI * r, Math.PI * Math.Pow(r, 2));
    }
}

