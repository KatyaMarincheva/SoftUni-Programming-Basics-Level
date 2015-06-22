// Problem 10.	Reformat C# Code
/* Reformat the following C# code to make it readable according to the C# best practices 
 * for code formatting. Change the casing of the identifiers in the code 
 * (e.g. use PascalCase for the class name):
 */

using System;

class HorribleCode
{
    static void Main()
    {
        Console.WriteLine("Hi, I am horribly formatted program");
        Console.WriteLine("Numbers and squares:");

        for (int i = 0; i < 10; i++)
        {
            //Console.WriteLine( i + "       --> " + i * i ); // will also do the same if uncommented

            // "{0, -8}" this placeholder and the other two set a virtual 8 or 4 digit cell 
            // for the respective number or string
            // and align left this number or string within its own cell
            Console.WriteLine("{0, -8}" + "{1, -4}" + "{2, -8}", i, "-->", i * i);
        }
    }
}