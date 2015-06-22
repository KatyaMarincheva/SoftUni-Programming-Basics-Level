//  Problem 7. Point in a Circle

/* Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 *
 * Examples:
 *   x 	    y 	    inside
 *   0 	    1 	    true
 *  -2 	    0 	    true
 *  -1 	    2 	    false
 *   1.5   -1 	    true
 *  -1.5   -1.5 	false
 * 100 	  -30 	    false
 *   0 	    0 	    true
 *   0.2   -0.8 	true
 *   0.9   -1.93 	false
 *   1 	    1.655 	true
 */

using System;

class PointsInACircle
{
    static void Main()
    {
        const int center_x = 0;
        const int center_y = 0;
        const double radius = 2;

        string inputX;
        double x;

        string inputY;
        double y;

        string intro =
    @"This program checks if given point (x, y) 
is inside a circle K({0, 0}, 2).";

        Console.WriteLine(intro);

        do  // validates input for x
        {
            Console.Write("\nPlease enter a value for x: ");
            inputX = Console.ReadLine();

        } while (!double.TryParse(inputX, out x));


        do  // validates input for y
        {
            Console.Write("\nPlease enter a value for y: ");
            inputY = Console.ReadLine();

        } while (!double.TryParse(inputY, out y));

        // formula for points inside circle: x and y must satisfy (x - center_x)^2 + (y - center_y)^2 < radius^2
        bool insideCircle = Math.Pow((x - center_x), 2) + Math.Pow((y - center_y), 2) <= Math.Pow(radius, 2);

        Console.WriteLine();
        Console.WriteLine(@"Point ({0}, {1}) is inside the circle: {2}", x, y, insideCircle);
        Console.WriteLine();
    }
}


