/* Problem 19.	** – The Explorer
This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. 
 * Today he is going on an expedition to collect all kind of diamonds, no matter small or large. 
 * Help your friend to find all the diamonds in the biggest known cave "The Console Cave". 
 * At the only input line you will be given the width of the diamond. 
 * The char that forms the outline of the diamonds is '*' and the surrounding parts are made of '-' (see the examples). 
 * Your task is to print a diamond of given size n.
Input
Input data should be read from the console. 
•	The only input line will hold the width of the diamond – n.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	The output lines should hold the diamond.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> halfDiamond = new List<string>();

        // calculating top and bottom line
        string topHyphen = new String('-', n / 2);
        string top = topHyphen + "*" + topHyphen;

        // storing it into the halfDiamond list
        halfDiamond.Add(top);

        // calculating all middle lines, and storing them into the halfDiamond list
        for (int i = 1, j = 1; i <= n/2; i++, j +=2)
        {
            string middleLineHyphenOut = new String('-', n / 2 - i);
            string middleLineHyphenIn = new String('-', j);
            string middle = middleLineHyphenOut + "*" + middleLineHyphenIn + "*" + middleLineHyphenOut;
            halfDiamond.Add(middle);
        }

        // printing upper half of the diamond
        for (int i = 0; i < halfDiamond.Count; i++)
        {
            Console.WriteLine(halfDiamond[i]);
        }

        // printing mirror image of the upper half
        for (int k = halfDiamond.Count - 2; k >= 0; k--)
        {
            Console.WriteLine(halfDiamond[k]);
        }
    }
}

