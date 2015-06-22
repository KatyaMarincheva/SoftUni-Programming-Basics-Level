/* // Problem 16.	** Half Sum
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

class HalfSum2
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());

        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            if (i < n)
            {
                sum1 += int.Parse(Console.ReadLine());
            }
            else
            {
                sum2 += int.Parse(Console.ReadLine());
            }
        }

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

