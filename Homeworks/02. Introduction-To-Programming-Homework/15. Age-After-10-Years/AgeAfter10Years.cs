// Problem 15.* Age after 10 Years -
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization; // allows the use of (contains) the CultureInfo class
using System.Threading; // allows the use of (contains) the Thread class

class AgeAfterTenYears
{
    static void Main()
    {
        /* the 2 lines of code below override the local date format settings of the particular computer,
         * and ensure that the computer is able to recognize your chosen date format as a valid date.
         * without the date formate instruction below,
         * a computer with local MM/dd/yyyy date format settings will not recognize the input 13/02/1985 as a valid date input */

        CultureInfo bg = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bg;

        string intro = @"Please, type below the date of your birthday
in any Day Month Year format of your choice
(including for instance: 1 януари 1985),
and press Enter.
Please note that a valid year input
should be between 1850 and 2010: ";

        // input:
        // if we want to use these two variables in the While statement, we should declare them outside the Do loop
        string input;
        DateTime birthday;

        // the Do While loop below validates the date input; if:
        /* the input does not correspond to any valid D/M/Y date format;
         * or the input for month is not a number between 1 and 12, neither a valid month name;
         * or the input for days exceeds the maximum days number for the specific month;
         * (the TryParse() method alone takes care of the 3 requirements above)
         * or the year input is not between 1850 and 2010;
         * in all above cases the user gets re-invited to enter a valid date
         */
        do
        {
            Console.Write(intro);
            input = Console.ReadLine();

        } while (!DateTime.TryParse(input, out birthday) || birthday.Year < 1850 || birthday.Year > 2010);

        // logic:
        // DateTime.Year Property gets only the year component of the respective date
        int yourAgeNow = DateTime.Now.Year - birthday.Year;

        /* the code below subtracts the user's age from his birthday date, the result is a date in the year of user's birth, and if this day is before his birthday,
         * subracts an year from the aboove calculated user's age
         * (shortly, this year the user will get for instance 30, but his birthday hasn't yet come, so he is still 29.)*/
        if (birthday > DateTime.Now.AddYears(-yourAgeNow)) yourAgeNow--;

        // printing:
        Console.WriteLine("\nYou are now {0} y.o.", yourAgeNow);
        Console.WriteLine("\nIn 10 years you will be {0} y.o.\n", yourAgeNow + 10);
    }
}
