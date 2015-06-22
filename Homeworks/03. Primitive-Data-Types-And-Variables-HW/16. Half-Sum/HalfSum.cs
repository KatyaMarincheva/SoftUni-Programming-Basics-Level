// Problem 16.	** Half Sum
/* Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game. He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.
You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums.
Input
The input data should be read from the console.
•	The first line holds an integer n – the count of numbers.
•	Each of the next 2*n lines holds exactly one number.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output must be printed on the console.
•	Print “Yes, sum=S” where S is the sum of the first n numbers in case of the sum of the first n numbers is equal to the sum of the second n numbers.
•	Otherwise print “No, diff=D” where D is the difference between the sum of the first n numbers and the sum of the second n numbers. D should always be a positive number.
 */

using System;
using System.Linq;

class HalfSum
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[2 * n];
        for (int i = 0; i < 2 * n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // logic 
        // the method array.Take(x) creates a new collection of type IEnumerable<T> (T = int in this case) and of length x
        // that is why we apply the ToArray() method as well, so that we can keep working with arrays
        int[] subset1 = numbers.Take(n).ToArray();
        int[] subset2 = numbers.Skip(n).Take(n).ToArray();

        int sum1 = subset1.Sum();
        int sum2 = subset2.Sum();

        // printing
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum1 - sum2));
        }
    }
}


