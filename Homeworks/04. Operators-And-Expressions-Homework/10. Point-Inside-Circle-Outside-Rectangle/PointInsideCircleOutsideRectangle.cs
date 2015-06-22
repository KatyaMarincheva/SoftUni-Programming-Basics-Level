// Problem 10. Point Inside a Circle & Outside of a Rectangle

/* Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
 * // and out of the rectangle R(top=1, left=-1, width=6, height=2).

Examples:
x 	        y 	    inside K & outside of R
1 	        2 	    yes
2.5 	    2 	    no
0 	        1 	    no
2.5 	    1 	    no
2 	        0 	    no
4 	        0 	    no
2.5 	    1.5 	no
2 	        1.5 	yes
1 	        2.5 	yes
-100     -100 	    no  */

using System;
using System.Windows;


class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        // below I declare the variables defining the circle and the rectangle
        // so I can change them if I want to,
        // and use the algorithm below for any circle or rectangle
        double radius = 1.5;
        double cCentX = 1;
        double cCentY = 1;

        double rTop = 1;
        double rLeft = -1;
        double rWidth = 6;
        double rHeight = 2;

        string inputX;
        double x;

        string inputY;
        double y;

        string intro =
    @"This program checks for given point (x, y) 
if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle 
R(top=1, left=-1, width=6, height=2).";

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

        // formula for points inside circle
        bool insideCircle = Math.Pow((x - cCentX), 2) + Math.Pow((y - cCentY), 2) <= Math.Pow(radius, 2);

        // formula for points inside horizontal rectangle
        bool insideRectangle = (x >= rLeft) && (x <= (rLeft + rWidth)) && (y <= rTop) && (y >= (rTop - rHeight));

        Console.WriteLine();

        // print "yes" for points for which insideCircle and !insideRectangle (not inside rectangle) is true
        Console.WriteLine( "x       y 	inside K & outside of R \n{0, -8}{1, -8}{2, -20}", x, y, (insideCircle && !insideRectangle) ? "yes" : "no");
        Console.WriteLine();
    }
}

