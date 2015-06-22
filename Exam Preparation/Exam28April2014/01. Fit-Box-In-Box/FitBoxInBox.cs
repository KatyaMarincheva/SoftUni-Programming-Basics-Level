/* Problem 1 – Fit Box in Box
Nakov likes boxes. Ha has many boxes at home. To save space he often puts his boxes one inside another. 
 * A box can fit inside another box if the size of the smaller box is smaller than the size of the bigger box in all dimensions at the same time. 
 * Of course, boxes can be rotated to fit one inside another. Here are few examples:
•	(5, 1, 6) fits naturally in (6, 2, 9), because 5 < 6 and 1 < 2 and 6 < 9
•	(5, 1, 6) fits in (2, 7, 6) after rotating the second box to (6, 2, 7)
•	(7, 8, 1) cannot fit in (12, 7, 3) even after rotating
•	(6, 2, 9) cannot fit in (5, 1, 6) even after rotating
You are given the sizes of two boxes (width, height and depth). Write a program to check whether the boxes can fit one inside another and how exactly. 
 * Print the smaller box first, exactly as it is given in the input (without rotating), followed by "<" and the larger box (eventually rotated) 
 * to fit each of the dimensions. Print all possible ways to put the smaller box into the larger box. In case there is no smaller box, print nothing. 
 * See the examples below to catch the idea.
Input
The input data comes from the console. It holds exactly 6 different numbers, each at a separate line:
•	The first 3 lines hold the dimensions of the first box (width, height and depth).
•	The second 3 lines hold the dimensions of the second box (width, height and depth).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of zero or more lines:
•	If a smaller box exists, print all possible ways to fit the smaller box (without rotation) in the larger box (eventually rotated) in format: 
 * (w1, h1, d1) < (w2, h2, d2). Note that the first box is smaller if w1 < w2 and h2 < h2 and d1 < d2. Beware of whitespaces in the output format!
•	Print each possible fit into a separate line. The lines order is not important.
•	In case of no smaller box exists, print nothing.
Constraints
•	All input numbers are unique integers in [1 … 1000].
 */

using System;
using System.Collections.Generic;
using System.Linq;

class FitBoxInBox
{
    static void Main()
    {
        // initialize two lists of integer numbers, for the 3 dimention numbers per box: box1 and box2
        List<int> box1 = new List<int>();

        // fill list box1 with values
        for (int i = 0; i < 3; i++)
        {
            box1.Add(int.Parse(Console.ReadLine()));
        }

        // fill list box2 with values
        List<int> box2 = new List<int>();
        for (int i = 0; i < 3; i++)
        {
            box2.Add(int.Parse(Console.ReadLine()));
        }

        // compare box1 and box2 initial values, assuming that box1 is the smaller one
        //Console.WriteLine(string.Join(" ", box2));
        CompareBoxes(box1, box2);

        // start swapping second box values; if you uncomment the Console.WriteLine lines below, you will see how exactly the array looks like after each reversing
        box2.Reverse(1, 2); // second and third value swap places: the code means: start at position 1 in the array, and swap 2 array elements
        // in the above case this means: we have an array of 3 numbers, say 1 2 3, start at number 2 (position 1), and swap 2 numbers (numbers 2 and 3)
        // the result is 1 3 2
        CompareBoxes(box1, box2);
        //Console.WriteLine(string.Join(" ", box2));

        box2.Reverse(); // this code reverses the entire array: the above 1 3 2 becomes 2 3 1
        CompareBoxes(box1, box2);
        //Console.WriteLine(string.Join(" ", box2));

        box2.Reverse(1, 2);
        CompareBoxes(box1, box2);
        //Console.WriteLine(string.Join(" ", box2));

        box2.Reverse();
        CompareBoxes(box1, box2);
        //Console.WriteLine(string.Join(" ", box2));

        box2.Reverse(1, 2);
        CompareBoxes(box1, box2);
        //Console.WriteLine(string.Join(" ", box2));

        box2.Reverse(); // to initial values
        // compare box1 and box2 initial values, assuning that box2 is the smaller one
        //Console.WriteLine(string.Join(" ", box1));
        CompareBoxes(box2, box1); // as the method needs the box, assumed to be smaller, to be at first position, we swap the positions of box1 ans box2


        // start swapping first box values
        box1.Reverse(1, 2);
        CompareBoxes(box2, box1);
        //Console.WriteLine(string.Join(" ", box1));

        box1.Reverse();
        CompareBoxes(box2, box1);
        //Console.WriteLine(string.Join(" ", box1));

        box1.Reverse(1, 2);
        CompareBoxes(box2, box1);
        //Console.WriteLine(string.Join(" ", box1));

        box1.Reverse();
        CompareBoxes(box2, box1);
        //Console.WriteLine(string.Join(" ", box1));

        box1.Reverse(1, 2);
        CompareBoxes(box2, box1);
        //Console.WriteLine(string.Join(" ", box1));

    }
    // this method compares the box assumed to be smaller to the box assumed to be bigger
    // the numbers in the first array respectively correspond to the box assumed to be smaller
    // the numbers in the second array correspond to the box assumed to be bigger
    private static void CompareBoxes(List<int> first, List<int> second)
    {
        if (first[0] < second[0] && first[1] < second[1] && first[2] < second[2])
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                first[0], first[1], first[2], second[0], second[1], second[2]);
        }
    }
}