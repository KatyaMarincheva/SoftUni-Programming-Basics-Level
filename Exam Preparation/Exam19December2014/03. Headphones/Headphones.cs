/* Problem 3 – Headphones
Stamat really loves all kinds of music. He listens to music all the time. He even dreams of it. One day he decided to start programming. 
 * The only way he can write code is while listening to music (and singing… and even dancing). 
Your task is to help Stamat write a program that prints his headphones on the console using only asterisks '*' and dashes '-'. 
 * And since his headphones are very special they have a diameter. 
 * See the example below to better understand how the diameter affects the headphones' size.
--*******--   
--*-----*--   -> height = 5
--*-----*--
--*-----*--
--*-----*--
--*-----*--
-***---***-
*****-*****   -> horizontal diameter = 5
-***---***-   -> vertical diameter = 5
--*-----*--
Input
The input data consists of only 1 line: the diameter of Stamat's headphones.
Output
The output data should be printed on the console.
Constraints
•	The diameter of Stamat's headphones will always be an odd number in the range [3..29].
 */

using System;

class Headphones
{
    static void Main()
    {
        // input
        int diameter = int.Parse(Console.ReadLine());

        // counts
        int lengthCount = diameter + 2;
        int height = diameter;
        int horizontalDiameter = diameter;
        int verticalDiameter = diameter;
        int sideCount = diameter / 2;
        int midCount = diameter;
        int headphonesCount = 1;

        // strings
        string length = new string('*', lengthCount);
        string side = new string('-', sideCount);
        string middle = new string('-', midCount);
        string headphones = new string('*', headphonesCount);

        // printing
        Console.WriteLine("{0}{1}{0}", side, length);

        for (int i = 0; i < height; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", side, headphones, middle);
        }

        for (int j = 0; j < height/2; j++)
        {
            sideCount--;
            headphonesCount += 2;
            midCount -= 2;
            side = new string('-', sideCount);
            headphones = new string('*', headphonesCount);
            middle = new string('-', midCount);
            Console.WriteLine("{0}{1}{2}{1}{0}", side, headphones, middle);
        }

        for (int k = 0; k < height/2; k++)
        {
            sideCount++;
            headphonesCount -= 2;
            midCount += 2;
            side = new string('-', sideCount);
            headphones = new string('*', headphonesCount);
            middle = new string('-', midCount);
            Console.WriteLine("{0}{1}{2}{1}{0}", side, headphones, middle);
        }
    }
}

