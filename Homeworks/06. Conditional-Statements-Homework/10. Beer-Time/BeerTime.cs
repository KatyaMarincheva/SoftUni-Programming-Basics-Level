// Problem 10.* Beer Time

/* A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” 
 * (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
 * and prints beer time or non-beer time according to the definition above 
 * or invalid time if the time cannot be parsed. 
 * Note: You may need to learn how to parse dates and times.

Examples:
time 	    result
1:00 PM 	beer time
4:30 PM 	beer time
10:57 PM 	beer time
8:30 AM 	non-beer time
02:59 AM 	beer time
03:00 AM 	non-beer time
03:26 AM 	non-beer time
 */

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class BeerTime
{

    static void Main()
    {
        // securing parsing in format HH:MM AM/PM
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        // intro
        string intro = @"A beer time is after 1:00 PM and before 3:00 AM.
This program enters a value for time,
and prints beer time or non-beer time according to the definition above 
or invalid time if the time input cannot be parsed. ";
        Console.WriteLine(intro);

        // declarations
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");
        DateTime time;
        
         try
        {
            // input
            Console.Write("\nPlease, enter time in format hh:mm tt: ");
            time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", CultureInfo.InvariantCulture);

            // logic
            if (time >= start || time <= end)
            {
                Console.WriteLine("\nbeer time\n");
            }

            else if (!(time >= start || time <= end))
            {
                Console.WriteLine("\nnon-beer time\n");
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time");
        }
    }
}

