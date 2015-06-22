/* Problem 11.	Count of Letters
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
 * The letters should be listed in alphabetical order. Use the input and output format from the examples below. 
Examples:
Input	                                Output
b b a a b	                            a -> 2
                                        b -> 3

h d h a a a s d f d a d j d s h a a	    a -> 6
                                        d -> 5
                                        f -> 1
                                        h -> 3
                                        j -> 1
                                        s -> 2
 */

using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        // input
        Console.WriteLine("Please, enter a text with letters to count: ");
        string text = Console.ReadLine().ToLower();
        Console.WriteLine();

        // this dictionary will hold the pairs: letter (key) -> count (value)
        Dictionary<char, int> dict = new Dictionary<char, int>();

        // if we come across a letter in the text - we add the letter and is count to the dictionary
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                if (!dict.ContainsKey(text[i])) // if the letter is not already added
                {
                    dict.Add(text[i], text.Count(x => x == text[i]));
                }
            }
        }

        // we want the dictionary letter-keys sorted lexicographically
        var list = dict.Keys.ToList();
        list.Sort();

        // printing
        foreach (var key in list)
        {
            Console.WriteLine("Letter: {0} -> count: {1}\n",
                key, dict[key]);
        }
    }
}



