// Problem 9. Sum of n Numbers

/*Write a program that enters a number n 
 * and after that enters more n numbers and 
 * calculates and prints their sum. 
 * Note: You may need to use a for-loop.
 */

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point 
        // in floating-point type numbers
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        // how many number will you be entering?
        Console.Write("\nPlease, enter a value for array length: ");
        int length = int.Parse(Console.ReadLine());

        // we create an array (list) with a number of empty slots equal to the above number length
        double[] nums = new double[length];

        for (int i = 0; i < length; i++)
        {
                Console.Write("\nPlease, enter number {0}: ", i + 1);
                nums[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe Max of these {0} numbers is {1}\n", length, nums.Max());
        Console.WriteLine("\nThe Min of these {0} numbers is {1}\n", length, nums.Min());
        Console.WriteLine("\nThe sum of these {0} numbers is {1}\n", length, nums.Sum());
        Console.WriteLine("\nThe average of these {0} numbers is {1}\n", length, nums.Average());
    }
}

