/* Problem 2 – Dream Item
Trifon has a dream item. He is a good programmer and started working last month, but he needs help with his salary. 
 * You are given the month when Trifon is working, the money he is making per hour, 
 * number of hours per day he is working and the price of his dream item. 
 * Assume February has 28 days and every month has exactly 10 holidays when Trifon is not working. 
 * All other months have either 31 or 30 (check a calendar if you’re unsure about the number of days in a given month). 
 * Also if Trifon makes more than 700 leva this month, he is promised a bonus of 10% of the total money 
 * (e.g. if he makes 800 lv, his bonus will be 80 and the total money he would earn is 880 lv).
Your task is to write a program that calculates whether Trifon can buy his dream item.
Input
The input data consists of one line coming from the console. Check the examples below.
The format is: Month\Money per hour\Hours per day\Price of the item. 
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print whether the item can be bought - 
"Money left = {0} leva." or "Not enough money. {0} leva needed." 
•	 The money must be rounded to the second digit after the decimal point.
Constraints
•	Month - "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov" or "Dec".
•	Money per hour - floating number [-7.9 x 1028 … 7.9 x 1028].
•	Hours per day - integer in range [1 to 24].
•	Item price - floating number in range [0... +7.9 x 1028].
 */

using System;
using System.Linq;

class DreamItem
{
    static void Main()
    {
        // Input format: Month\Money per hour\Hours per day\Price of the item
        string input = Console.ReadLine();
        string[] data = input.Split('\\').ToArray();

        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        decimal dreamItemPrice = decimal.Parse(data[3]);

        data[0] = data[0].Substring(0, 3);
        int daysInMonth = System.DateTime.DaysInMonth(2015, Array.IndexOf(months, data[0]) + 1);

        decimal income = (daysInMonth - 10) * decimal.Parse(data[2]) * decimal.Parse(data[1]);
        if (income > 700m)
        {
            income *= 1.1m;
        }
        decimal result = income - dreamItemPrice;

        if (result < 0)
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(result));
        }
        else
        {
            Console.WriteLine("Money left = {0:F2} leva.", result);
        }
    }
}

