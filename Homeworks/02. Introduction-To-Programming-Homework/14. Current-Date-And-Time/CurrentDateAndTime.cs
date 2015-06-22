// Problem 14.* Current Date and Time 
// Create a console application that prints the current date and time. Find in Internet how.

using System;
using System.Globalization; // allows the use of (contains) the CultureInfo class
using System.Threading; // allows the use of (contains) the Thread class

class CurrentDateAndTime
{
    static void Main()
    {
        // the 2 lines of code below override the local date format settings of the particular computer
        // and ensure we will print the date and time in local, Bulgarian format

        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;

        /* The DateTime.Now Property 
        * gets a DateTime object that is set to the current date and time on this computer, expressed as the local time. */
        Console.Title = "Current Date and Time";

        DateTime dateAndTimeNow = DateTime.Now;

        Console.WriteLine("Current date and time: {0}", dateAndTimeNow);

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}
