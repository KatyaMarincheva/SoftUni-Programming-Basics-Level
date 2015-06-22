// Problem 4.	Calculate Hypotenuse
// You are given three right angled triangles. Find the length of their hypotenuses.

/* 1.	Catheti: 3 and 4

   2.	Catheti:  10 and 12

   3.	Catheti 100 and 250
 */

using System;

class CalculateHypotenuse
{
    static void Main()
    {
        // Using Pythagoras' Theorem:  a^2 + b^2 = c^2 
        // hypotenuse c = square root of a^2 + b^2, or

        // 1.	Catheti: 3 and 4
        double c1 = HypotenuseCalculator(3, 4);
        Console.WriteLine("Catheti: 3 and 4 \nHypotenuse: {0}\n", c1);

        // 2.	Catheti:  10 and 12
        double c2 = HypotenuseCalculator(10, 12);
        Console.WriteLine("Catheti: 10 and 12 \nHypotenuse: {0}\n", c2);

        // 3.	Catheti 100 and 250
        double c3 = HypotenuseCalculator(100, 250);
        Console.WriteLine("Catheti: 100 and 250 \nHypotenuse: {0}\n", c3);
    }

    // the method below is a reusable hypotensue calculator code
    // which we will be applying the all the 3 groups of input numbers
    private static double HypotenuseCalculator(int a, int b)
    {
        double c = Math.Sqrt(a * a + b * b);

        return c;
    }
}

