/* Problem 4 – Longest Alphabetical Word
Nakov enjoys playing with words. Recently he invented the following puzzle game. He starts by given word w (e.g. "softwareuniversity") 
 * and he fills a square block of size n*n (e.g. n=7) with this word as many times as it fits, from left to right and from up to down 
 * (see the example on the right). It is also called Nakov's square block of word w and size n.
Nakov defines an alphabetical word as a sequence of letters, where each letter is alphabetically after its previous letter in the word. For example, 
 * "abc", "fo" and "aeou" are alphabetical words, but "zabc", "srevi" and "ntaeou" are not.
Now Nakov wants to find the longest alphabetical word in the obtained square block. The word can start anywhere in the square block and can run in left, 
 * right, up or down direction and cannot go outside of the square block. In our example, if we start from row 3 and column 2 in our 7 x 7 square block, 
 * we find the following alphabetical words: "aw" (left direction), "ar" (right direction), "at" (up direction) and "aeou" (down direction).
Write a program that reads a word w and a number n and finds the longest alphabetical word in Nakov's square block of word w and size n. 
 * If more than one longest alphabetical words exist in the block, find the smallest of them in the standard lexicographical order.
Input
The input data should be read from the console. The input data consists of exactly two lines:
•	The first line will hold the word w.
•	The second line will hold the size n.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
You have to print at the console the longest alphabetical word.
Constraints
•	The word w will be a non-empty string, consisting of lower Latin letters, up 1000. 
•	The size of the square n will be an integer value in the range [1…50].
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class LongestAlphabeticalWord
{
    static void Main()
    {
        // input
        char[] w = Console.ReadLine().ToCharArray();
        int n = int.Parse(Console.ReadLine());

        // declarations
        int length = w.Length;
        int index = 0;
        char[,] square = new char[n, n];
        int count = 1;
        int maxSecq = 1;
        StringBuilder maxValue = new StringBuilder();
        Dictionary<string, int> results = new Dictionary<string, int>();

        // filling the square (the matrix) with the letters from the word
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                square[row, col] = w[index % length];
                index++;
            }
        }

        // if n = 1, we just print the whole matrix representing 1 single letter
        if (n == 1)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(square[row, col]);
                }
                Console.WriteLine();
            }
            return;
        }

        // in case you want to see how the entire square looks like
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {
        //        Console.Write(square[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        //Searching horizontally, from left to right, for increasing values
        for (int row = 0; row < square.GetLength(0); row++)
        {
            for (int col = 0; col < square.GetLength(1) - 1; col++)     
            {
                maxValue.Append(square[row, col]);
                //Console.WriteLine(square[row, col]);
                if ((square[row, col] < square[row, col + 1]))
                {
                    count++;

                    maxValue.Append(square[row, col + 1]);
                }

                else
                {
                    count = 1;
                    maxValue.Clear();
                }
                if (count >= maxSecq)
                {
                    maxSecq = count;
                    string temp = new string(maxValue.ToString().ToCharArray().Distinct().ToArray());
                    if (!results.ContainsKey(temp))
                    {
                        results.Add(temp, count);
                    }
                }

            }
            count = 1;
            maxValue.Clear();
        }

        //Searching horizontally, from left to right, for decreasing values
        for (int row = 0; row < square.GetLength(0); row++)
        {
            for (int col = 0; col < square.GetLength(1) - 1; col++)     
            {
                maxValue.Append(square[row, col]);
                if ((square[row, col] > square[row, col + 1]))
                {
                    count++;
                    maxValue.Append(square[row, col + 1]);
                }

                else
                {
                    count = 1;
                    maxValue.Clear();
                }
                if (count >= maxSecq)
                {
                    maxSecq = count;
                    // reversing the string (as if we have searched from right to left)
                    string temp = new string(maxValue.ToString().ToCharArray().Distinct().Reverse().ToArray());
                    if (!results.ContainsKey(temp))
                    {
                        results.Add(temp, count);
                    }
                }

            }
            count = 1;
            maxValue.Clear();
        }

        //Searching vertically, top to bottom, for decreasing values
        for (int col = 0; col < square.GetLength(1); col++)                 
        {
            for (int row = 0; row < square.GetLength(0) - 1; row++)
            {
                maxValue.Append(square[row, col]);
                if ((square[row, col] < square[row + 1, col]))
                {
                    count++;
                    maxValue.Append(square[row + 1, col]);
                }
                else
                {
                    count = 1;
                    maxValue.Clear();
                }
                if (count >= maxSecq)
                {
                    maxSecq = count;
                    string temp = new string(maxValue.ToString().ToCharArray().Distinct().ToArray());
                    if (!results.ContainsKey(temp))
                    {
                        results.Add(temp, count);
                    }

                }
            }
            count = 1;
            maxValue.Clear();
        }

        //Searching vertically, top to bottom, for decreasing values
        for (int col = 0; col < square.GetLength(1); col++)                 
        {
            for (int row = 0; row < square.GetLength(0) - 1; row++)
            {
                maxValue.Append(square[row, col]);
                if ((square[row, col] > square[row + 1, col]))
                {
                    count++;
                    maxValue.Append(square[row + 1, col]);
                }
                else
                {
                    count = 1;
                    maxValue.Clear();
                }
                if (count >= maxSecq)
                {
                    maxSecq = count;
                    // reversing the string (as if we have searched bottom to top)
                    string temp = new string(maxValue.ToString().ToCharArray().Distinct().Reverse().ToArray());
                    if (!results.ContainsKey(temp))
                    {
                        results.Add(temp, count);
                    }

                }
            }
            count = 1;
            maxValue.Clear();
        }

        // removing empty key entries
        results.Remove(String.Empty);

        // these would be all strings with max length
        int max = results.Values.Max();
        List<string> final = new List<string>();
        foreach (KeyValuePair<string, int> pair in results)
        {
            if (pair.Value  == max)
	        {
                // adding to final all strings with max length
		        final.Add(pair.Key);
	        }
        }

        // "If more than one longest alphabetical words exist in the block, find the smallest of them in the standard lexicographical order"
        Console.WriteLine(final.Min());

        // in case you want to see all strings
        //foreach (KeyValuePair<string, int> pair in results)
        //{
        //    Console.WriteLine("{0} {1}", pair.Key, pair.Value);
        //}

    }
}
