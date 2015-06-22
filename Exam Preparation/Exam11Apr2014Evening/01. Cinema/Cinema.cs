/* Problem 1 – Cinema
Most people like going to the cinema. If you are such person, help the cinema director Kircho solve his financial task.
Kircho is trying to calculate how much his incomes are for a single projection, if the movie hall is completely full. 
 * He knows the type of projection (and how much a ticket for each type costs), 
 * the number of rows and the number of columns in the hall (the cimena hall is rectangular).
There are three types of movies projected in Kircho’s cinema:
•	Premiere projection – 12.00 leva
•	Normal projection – 7.50 leva
•	Discount projection for kids, students and retirees – 5.00 leva
Your task is to calculate the incomes Kircho gets for a single projection full of people. 
 * You need to calculate how many people are watching the movie depending on the rows and 
 * columns in the hall and find the incomes in levas depending on the type of projection.
Input
•	The input data is read from the console. 
•	A string representing the type of projection stays at the first input line. It can be one of the following: 
 * “Premiere”, “Normal”, “Discount” (without the quotes).
•	The number of rows stays at the second input line.
•	The number of columns stays at the third input line.
•	The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print the incomes with two digits after the decimal point with “leva” 
 * appended at the end (see the example tests). Use "." as decimal separator.
Constraints
•	The rows and columns are numbers between 1 and 100, inclusively.
 */

using System;
using System.Globalization;
using System.Threading;

class Cinema
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        // input
        string typeOfProjection = Console.ReadLine();
        decimal rows = decimal.Parse(Console.ReadLine());
        decimal columns = decimal.Parse(Console.ReadLine());

        // calculations
        decimal income = rows * columns * GetPrice(typeOfProjection);

        // printing
        Console.WriteLine("{0:F2} leva", income);

    }

    private static decimal GetPrice(string typeOfProjection)
    {
        decimal ticketPrice = 0;
        switch (typeOfProjection)
        {
            case "Premiere": ticketPrice = 12.00m; break;
            case "Normal": ticketPrice = 7.50m; break;
            case "Discount": ticketPrice = 5.00m; break;
        }
        return ticketPrice;
    }
}

