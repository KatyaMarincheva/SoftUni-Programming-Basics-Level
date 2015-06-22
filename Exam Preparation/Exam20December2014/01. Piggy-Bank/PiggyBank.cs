/* Problem 1 – Piggy Bank
Anastas wants to buy himself a tank to drive around the streets of Sofia (he’s a fan of the classic game Carmageddon). 
 * He’s saving up and he needs your help to keep track of his progress.
Every day in a given month he saves up 2 leva and puts them in his piggy bank. Unless there is a party that day – 
 * he needs 5 leva to buy vodka on a party day, so he takes them out of the piggy bank.
You will be given the tank’s price and the number of party days in a month, each on a separate line. 
 * Assume each month has 30 days and each year has 12 months. Calculate how many years and months 
 * Anastas will need in order to save enough to buy his very own tank and print the result on the console 
 * in the format “X years, Y months”. In case he isn’t saving up at all and is wasting money on cheap alcohol instead, print “never”.
Note that if, for example, Anastas needs 3.1 months, you need to round that up – so you have to print “0 years 4 months”. 
 * The years and months should be integer numbers. Check out the examples to understand your task better. 
Input
The input will be read from the console. The input consists of exactly two lines:
•	On the first line you will be given an integer – the price of the tank.
•	On the second line you will be given the number of party days in a month.
The input will always be valid and in the format described, there is no need to check it explicitly.
Output
The output should be printed on the console.
•	On the only output line print the number of years and months Anastas will need to save enough money 
 * in the format “X years, Y months”, or print “never” in case he’s actually wasting money each month.
Constraints
•	The price of the tank will be an integer in the range [1 … 2 000 000 000].
•	The number of party days will be an integer in the range [0 … 30].
 */

using System;

class PiggyBank
{
    static void Main()
    {
        decimal price = decimal.Parse(Console.ReadLine());
        decimal partyDays = decimal.Parse(Console.ReadLine());

        decimal savings = (30 - partyDays) * 2;
        decimal expenses = partyDays * 5;
        decimal balance = savings - expenses;

        if (balance < 0)
        {
            Console.WriteLine("never");
        }
        else
        {
            decimal months = Math.Ceiling(price / balance);
            int years = (int)(months / 12);
            decimal andMonths = Math.Ceiling(months % 12);

            Console.WriteLine("{0} years, {1} months", years, andMonths );
        }
    }
}

