/* Problem 16.	** – Magic Dates
Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the weight of this date by joining together all its digits, 
 * multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will have 8-digits: 17032007, 
 * so the weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 
 * + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. 
 * The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar 
 * (years have 12 months, each having 28, 29, 30 or 31 days, etc.). Years start from 1 January and end in 31 December.
Input
The input data should be read from the console. It consists of 3 lines:
•	The first line holds an integer number – start year.
•	The second line holds an integer number – end year.
•	The third line holds an integer number – magic weight.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of dates in format dd-mm-yyyy in alphabetical order. 
 * Each string should stay on a separate line. In case no magic dates exist, print “No”.
Beware that the regional settings at your computer and at the judge's computer may be different!
Constraints
•	The start and end year are integers in the range [1900-2100].
•	The magic weight is an integer number in range [1…1000].
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class MagicDates
{
    static void Main()
    {
        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;

        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        DateTime one = new DateTime(startYear, 1, 1);
        DateTime two = new DateTime(endYear, 12, 31);
        List<DateTime> allDays = EachDay(one, two).ToList();
        int N = allDays.Count;


        List<DateTime> magicDates = new List<DateTime>();
        for (int i = 0; i < N; i++)
        {
            int sum = 0;
            List<int> temp = new List<int>();
            foreach (char c in allDays[i].ToString("ddMMyyyy"))
            {

                temp.Add(c - '0');
            }

            for (int j = 0; j < temp.Count; j++)
            {
                for (int k = j + 1; k < temp.Count; k++)
                {
                    sum += temp[j] * temp[k];
                }
            }

            if (sum == magicWeight)
            {
                magicDates.Add(allDays[i]);
            }
        }

        if (magicDates.Count > 0)
        {
            foreach (var item in magicDates)
            {
                Console.WriteLine(item.ToString("dd-MM-yyyy"));
            }
        }
        else
        {
            Console.WriteLine("No");
        }

    }

    public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
    {
        for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            yield return day;
    }
}


