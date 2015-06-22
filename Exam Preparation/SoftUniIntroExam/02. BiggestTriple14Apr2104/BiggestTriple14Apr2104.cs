using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        // read, split and parse input line, store in a list of unrestricted count
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        // declaring variables
        int maxSum = Int32.MinValue; // setting to initial Int32.MinValue is important, 
        // as we can get all actual sums below 0, and they should still be higher that the initial maxSum value
        int sum = 0;

        // declaring two lists (we prefer list to array so that we can have a temp and final lists of 1-3 elements):
        // temp will be storing every slice of 3 numbers, temporarily, until we calculate their sum and compare it to maxSum
        List<int> temp = new List<int>();
        // final will be storing the slice of maximal sum
        List<int> final = new List<int>();

        // keep slicing the intial numbers list and removing the slices from it, while numbers.Count >= 3
        while (numbers.Count >= 3)
        {
            temp = numbers.Take(3).ToList(); // taking the first 3 elements of the numbers list
            numbers.RemoveRange(0, 3); // removing the first 3 elements of the numbers list

            sum = temp.Sum(); // summing the temp list

            if (sum > maxSum) // comparing with maxSum
            {
                maxSum = sum;
                final = temp;
            }
        }

        // only in case there are still remaining elements in numbers list
        // we will take the last remaining elements ( 1 or 2), sum them and compare with maxSum
        if (numbers.Count != 0)
        {
            temp = numbers;
            sum = temp.Sum();

            if (sum > maxSum)
            {
                maxSum = sum;
                final = temp;
            }
        }

        // printing the result
        Console.WriteLine(string.Join(" ", final));
    }
}

