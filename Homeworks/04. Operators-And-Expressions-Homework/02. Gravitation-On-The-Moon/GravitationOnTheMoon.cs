// Problem 2. Gravitation on the Moon

/* The gravitational field of the Moon is approximately 17% of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 * 
 * Examples:
 * weight 	weight on the Moon
 * 86 	    14.62
 * 74.6 	12.682
 * 53.7 	9.129 
 */

using System;
using System.Globalization;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point in floating-point type numbers
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        string intro = 
@"This program calculates the weight of a man on the moon 
by a given weight on the Earth.";
        Console.WriteLine(intro);

        string input;
        float weight;

        do // validates weight input
        {
        Console.Write("\nPlease, enter a weight value: ");
        input = Console.ReadLine().Replace(",", ".");  // so that the program can recognize both ',' and '.' as decimal points

        } while (!float.TryParse(input, out weight));


        Console.WriteLine("\nWeight on Moon \n= 17% of the weight on Earth ({0}kg) \n= {1}kg\n", weight, ((17 * weight)/100));
    }
}

