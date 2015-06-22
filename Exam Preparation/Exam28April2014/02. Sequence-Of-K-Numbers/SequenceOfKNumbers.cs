/* Problem 2 – Sequence of K Numbers
Write a program to remove all sequences of k equal elements from a sequence of integers. For example, 
 * if we have the sequence 3 3 3 8 8 2 5 1 7 7 7 4 4 4 4 3 4 4 and we remove all sequences of k = 2 elements, 
 * we will obtain 3 2 5 1 7 3. For k = 3, we will obtain the following result: 8 8 2 5 1 4 3 4 4. For k = 1, the result will be empty.
Input
The input data comes from the console. It should consist of a two lines:
•	The first line holds the input numbers, separated one from another by a space.
•	The second line holds the number k.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of a single line holding the obtained sequence of numbers. 
 * Separate each number from the next number by a space.
Constraints
•	The input sequence numbers are integers in the range [-1000 … 1000].
•	The count of the input numbers is in the range [1 … 1000].
•	The number k is integer in the range [1 … 1000].
 */

using System;
using System.Linq;
using System.Collections.Generic;

class SequenceOfKNumbers
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> copy = new List<int>(numbers);
        int k = int.Parse(Console.ReadLine());

        int index = 0;
        while (index < numbers.Count - k + 1)
        {

            List<int> temp = new List<int>();

            temp = numbers.Skip(index).Take(k).ToList();
            if (temp.All(x => x == temp[0]))
            {
                numbers.RemoveRange(index, k);
            }
            else
            {
                index++;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

