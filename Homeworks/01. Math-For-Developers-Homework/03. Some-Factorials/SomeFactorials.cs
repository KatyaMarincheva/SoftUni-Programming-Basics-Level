// Problem 3.	Some Factorials
// Find 100!, 171! and 250! Give all digits.

using System;
using System.Numerics;

class SomeFactorials
{
    static void Main()
    {
    // declarations
        BigInteger factorialI = 1; // BigInteger is the only data type able to store such big numbers

    // logic - with each step we increase n!: * i=1; * i=2; * i=3; etc.
        for (int i = 1; i <= 250; i++)
        {
            factorialI *= i;

            // when the loop reaches i = 100, 171, and 250 respectively, we print
            if (i == 100 || i == 171 || i == 250)
            {
                Console.WriteLine("The factorial of {0} is \n{1}\n", i, factorialI);
            }
        }
    }
}

