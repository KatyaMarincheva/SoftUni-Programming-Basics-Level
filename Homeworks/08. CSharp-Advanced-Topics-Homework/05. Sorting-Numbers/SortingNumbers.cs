/* Problem 5.	Sorting Numbers
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
 */

using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        // input
        Console.Write("Please enter an int value for n: ");
        int n = int.Parse(Console.ReadLine());      

        // filling the array of numbers
        Console.WriteLine("Please, enter {0} numbers, each on a separate line:", n);
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        array = SelectionSort(array);
        Console.WriteLine("\nOutput:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
    }

    private static int[] SelectionSort(int[] array)
    {
        // declaring two lists
        List<int> tempList = array.ToList(); // initial int array converted into this list
        int[] sorted = new int[array.Length]; // sordted list - to accomodate the sorted numbers from the above tempList

        int i = 0;
        while (tempList.Count != 0)
        {
            tempList.Min(); // finding tempList monimal value
            sorted[i] = tempList.Min(); // adding it to the sorted list
            tempList.Remove(tempList.Min()); // removing it from tempList
            i++;
            // and restarting the above, until tempList.Count == 0
        }
        return sorted;
    }
}

