/* Problem 18.	** – Odd / Even Sum
This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
You are given a number n and 2*n numbers. Write a program to check whether the sum of the odd numbers 
 * is equal to the sum of the even n numbers. The first number is considered odd, the next even, the next odd again, etc. 
 * Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the odd and the even sums.
Input
The input data should be read from the console.
•	The first line holds an integer n – the count of numbers.
•	Each of the next 2*n lines holds exactly one number.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output must be printed on the console.
•	Print “Yes, sum=S” where S is the sum of the odd n numbers in case of the sum of the odd n numbers is equal to the sum of the even n numbers.
•	Otherwise print “No, diff=D” where D is the difference between the sum of the odd n numbers and the sum of the even n numbers. 
 * D should always be a positive number.
  */

using System;

class OddEvenSum
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
        int sumOdd = 0;
        int sumEven = 0;
        for (int j = 0; j < numbers.Length; j++)
        {
            if (j % 2 == 0)
            {
                sumOdd += numbers[j];
            }

            else
            {
                sumEven += numbers[j];
            }
        }

        // printing
        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumEven);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sumEven - sumOdd));
        }
    }
}

