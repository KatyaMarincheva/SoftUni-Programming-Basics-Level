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

