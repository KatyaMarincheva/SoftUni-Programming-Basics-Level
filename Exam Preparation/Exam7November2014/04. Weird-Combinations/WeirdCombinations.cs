/* Problem 4 – Weird Combinations
You are given a sequence of 5 distinct numbers and/or letters. Find all possible combinations of 5 symbols containing the given numbers/letters. 
 * Then you will be given a number n. You have to find the n-th number in the natural order of all combinations. Example: sequence = "a1bc2", n = 5, 
 * combinations: "aaaaa", "aaaa1", "aaaab", "aaaac", "aaaa2", "aaa1a", "aaa1b"…  "2222b", "2222c", "22222".  5th element = aaa1a 
 * (take notice that the first element in the order is counted as 0). If the n-th number doesn't exist in print "No".
Input
Input data is read from the console.
•	The sequence of letters/numbers stays at the first line.
•	The number n of stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	Print the n-th number in the natural order of all combinations.
Constraints
•	N will be an integer number between 0 and 5000 and 
 */

using System;
using System.Linq;

class WeirdCombinations
{
    static void Main()
    {
        string sequence = Console.ReadLine();
        char[] elements = sequence.ToArray();
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(string.Join(" ", elements));

        int combinationsCount = 0;
        for (int d1 = 0; d1 < elements.Length; d1++)
        {
            for (int d2 = 0; d2 < elements.Length; d2++)
            {
                for (int d3 = 0; d3 < elements.Length; d3++)
                {
                    for (int d4 = 0; d4 < elements.Length; d4++)
                    {
                        for (int d5 = 0; d5 < elements.Length; d5++)
                        {
                            string combination = "" + elements[d1] + elements[d2] + elements[d3] + elements[d4] + elements[d5];
                            combinationsCount++;
                            if (combinationsCount == n + 1)
                            {
                                Console.WriteLine(combination);
                                return;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("No");
    }
}
