// Problem 12.* Randomize the Numbers 1…N

/* Write a program that enters an integer n and prints the numbers 1, 2, …, n in random order.

Examples:
n 	randomized numbers 1…n
3 	2 1 3
10 	3 4 8 2 6 7 9 1 10 5

Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
 */

using System;

class RandomizeTheNumbers
{
    public static void MixArray(int[] array)
    {
        int index, temp;
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            index = rand.Next(array.Length);

            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
    
    static void Main()
    {
        // input
        Console.Write("\nPlease, enter a value for n: ");
        int n = int.Parse(Console.ReadLine());

        // logic
        Console.Write("\n{0} sequential numbers in the range 1...{0}: ", n);

        int[] nums = new int[n]; // initializing nums arrray
        for (int i = 0; i < n; i++)
        {
            nums[i] = i+1; //adding the numbers 1 to n to the nums array
        }

        // printing the original nums array
        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }

        Console.Write("\n\nRandomized array: ");
        // mixing the nums array
        MixArray(nums);

        // printing the randomized nums array
        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

