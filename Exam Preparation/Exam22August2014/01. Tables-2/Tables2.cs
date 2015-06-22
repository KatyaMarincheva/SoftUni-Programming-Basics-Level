/* Problem 1 – Tables 
Gosho is very good table maker. He has 4 bundles full of table legs. Every bundle holds packets. 
 * The first bundle holds packets with 1 leg, the second bundle holds packets with 2 legs and the other 2 bundles 
 * hold packets with 3 and 4 legs respectively. Example: (bundle3 = 5 packets * 3 legs = 15 legs). 
 * He also has T amount of table tops and N amount of tables that need to be made. Your task is to calculate 
 * how many tables can Goshko make and whether he has made more, less or equal amount of the needed tables. 
 * Every table is made from 4 legs and 1 table top.  Check the examples below to understand your task better.
Input
The input data should be read from the console.
•	At the first four lines you will be given integer numbers  representing how many packets each bundle has
•	At the fifth line an integer number T specifying the amount of table tops.
•	At the sixth line an integer number N specifying the amount of tables to be made.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of 1 or 2 lines:
•	Print “more: {0}” on the first line, if the tables made are more than the tables needed.
o	Print the materials left on the second line: “table tops left: {0}, legs left: {1}”
•	Print “less: {0} “, if the tables made are less than the tables needed. 
o	Print the materials needed  to create all needed tables: “tops needed: {0}, legs needed {1}”
•	Print “Just enough tables made: {0}”, if the tables made are equal with the tables needed.
Constraints
•	The inputs will be an integers in the range [0…999 999 999].
 */

using System;

class Tables
{
    static void Main()
    {
        long bundle1 = long.Parse(Console.ReadLine());
        long bundle2 = long.Parse(Console.ReadLine());
        long bundle3 = long.Parse(Console.ReadLine());
        long bundle4 = long.Parse(Console.ReadLine());
        long tableTops = long.Parse(Console.ReadLine());
        long tablesToBeMade = long.Parse(Console.ReadLine());

        long allLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);
        long tablesMade = Math.Min((allLegs / 4), tableTops);

        if (tablesMade > tablesToBeMade)
        {
            long topsLeft = tableTops - tablesToBeMade;
            long legsLeft = allLegs - tablesToBeMade * 4;
            Console.WriteLine("more: {0}", tablesMade - tablesToBeMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legsLeft);
        }
        else if (tablesMade < tablesToBeMade)
        {
            long topsNeedd = tablesToBeMade >= tableTops ? tablesToBeMade - tableTops : 0;
            long legsNeeded = tablesToBeMade * 4 >= allLegs ? tablesToBeMade * 4 - allLegs : 0;
            Console.WriteLine("less: {0}", tablesMade - tablesToBeMade);
            Console.WriteLine("tops needed: {0}, legs needed: {1}", topsNeedd, legsNeeded);
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tablesMade);
        }
    }
}
