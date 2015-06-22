//  Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

/* Examples:
Number a 	Number b 	Equal (with precision eps=0.000001) 	Explanation
5.3 	6.01 	false 	The difference of 0.71 is too big (> eps)
5.00000001 	5.00000003 	true 	The difference 0.00000002 < eps
5.00000005 	5.00000001 	true 	The difference 0.00000004 < eps
-0.0000007 	0.00000007 	true 	The difference 0.00000077 < eps
-4.999999 	-4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.
4.999999 	4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different. */

using System;
using System.Collections.Generic;


class ComparingFloats
{
    static void Main()
    {
        //I have stored the floats from the above two columns into two arrays
        List<double> floatsOne = new List<double> { 5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
        List<double> floatsTwo = new List<double> { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };

        // the for loop below calls the numbers at index 0, 1, etc. of the two arrays above, thus forming comparison pairs
        // the numebr at index 0 of array floatsOne will be compaired with the number at index 0 of array floatsTwo, etc.
        for (int i = 0; i <= 5; i++)
        {
            // checking if the absolute value of the difference between number 1 and number 2 will be smaller than 0.000001
            bool equal = Math.Abs(floatsOne[i] - floatsTwo[i]) < 0.000001;

            // equal ? (if the numebrs are equal) print True : (else) print False
            // floatsOne[i].ToString("0.00000000") formats the way the double numbers will be printed
            Console.WriteLine("The numbers \t{0} \tand \t{1} \tare equal: \t{2}.", floatsOne[i].ToString("0.00000000"), floatsTwo[i].ToString("0.00000000"), equal ? "True" : "False");
        }
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}
