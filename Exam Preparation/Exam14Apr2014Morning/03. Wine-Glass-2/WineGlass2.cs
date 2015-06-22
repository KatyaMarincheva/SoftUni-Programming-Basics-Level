/* Problem 3 – Wine Glass
Bulgarians are famous for being enchanted by the magic of the red wine. Its magic is very powerful and yet unpredictable. 
 * Some people report being struck by a memory loss charm, others lose control over their speech, to others it acts like a love potion. 
 * You’re asked to help the Bulgarians by printing a few of their beloved magical wine glasses for them.
Input
The input data should be read from the console.
•	You have an integer number N (always even number) specifying the height of the wine glass.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. You should print the wine glass on the console following the examples below.
•	The glass has exactly N rows, each of which contains exactly N symbols. 
•	The first row should contain the backslash (“\”) symbol, a total of (N-2) asterisks (“*”) and the slash (“/”) symbol.
•	The second row should contain exactly one dot (”.”) before the backslash, one after the slash and two less (compared to the row above) 
 * asterisks between the slash and backslash.
•	The third row should contain one more dot at each side and two less asterisks and so on, until the (N /2) row, 
 * where there should be no asterisks between the slashes.
•	On the next (N/2)-2 rows, if N >= 12 or (N/2)-1 rows, if N < 12, you should print the stem that should look like the following: 
 * a count of (N/2)-1 dots (“.”), followed by two vertical lines (“|”) and (N/2)-1 dots after the lines. The remaining one or two rows 
 * (up to a total count of N) should be filled with exactly N dashes (“-”) on each row.
Constraints
•	The number N will be an even integer between 4 and 60, inclusive.
 */

using System;

class WineGlass
{
    const char GlassFillingSymbol = '*';
    const char EmptySpaceSymbol = '.';

    static void Main()
    {
        // Read a positive, even number 
        int n = int.Parse(Console.ReadLine());
        int borderSpacing = 0;
        int middleSpacing = n - 2;

        for (int i = 0; i < n; i++)
        {
            // For the first half we print the upper part (bowl) of the glass
            if (i < n / 2)
            {
                string dots = new string(EmptySpaceSymbol, borderSpacing);
                string asterisks = new string(GlassFillingSymbol, middleSpacing);
                Console.WriteLine(dots + '\\' + asterisks + '/' + dots);
                borderSpacing++;
                middleSpacing -= 2;
            }
            // After that we print the stem according to the rules
            else if (n < 12 && i < n - 1 || n >= 12 && i < n - 2)
            {
                string dots = new string(EmptySpaceSymbol, n / 2 - 1);
                Console.WriteLine(dots + '|' + '|' + dots);
            }
            // Finally we print the foot of the glass
            else
            {
                Console.WriteLine(new string('-', n));
            }
        }
    }
}

