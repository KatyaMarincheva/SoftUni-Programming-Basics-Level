// Problem 6.	Least Common Multiple
// Find LCM(1234, 3456).

using System;

public class LeastCommonMultiple
{
    public static int determineLCM(int a, int b)
    {
        // finding out which one of the two input numbers is bigger
        int num1, num2;
        if (a > b)
        {
            num1 = a; num2 = b;
        }
        else
        {
            num1 = b; num2 = a;
        }

        // the code below considers two scenarios:
        // * either the bigger of the two numbers is directly divisible by the smaller one (exmample 8 and 4), 
        // in which case the smaller number is the LCM (return num2;)
        // * or we keep multiplying the bigger number with all numbers between 1 and the value of the smaller number
        // untill we reach a multiple of the bigger number which is also divisible by the smaller number (example 8 and 12; 12 * 2 /8 = 3)
        // in the worst case, we will reach product of num1 and num2, which could also happen to be their LCM, as with 3 and 5, where LCM = 15;
        for (int i = 1; i <= num2; i++)
        {
            if ((num1 * i) % num2 == 0)
            {
                return i * num1;
            }
        }
        return num2;
    }

    public static void Main(String[] args)
    {
        // applying the above method
        int result = determineLCM(1234, 3456);

        // printing the result
        Console.WriteLine("LCM of {0} and {1} is {2}\n", 1234, 3456, result);
    }
}

