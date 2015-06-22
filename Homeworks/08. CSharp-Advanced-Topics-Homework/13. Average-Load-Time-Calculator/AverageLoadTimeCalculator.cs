/* Problem 13.	Average Load Time Calculator
We have a report that holds dates, web site URLs and load times (in seconds) 
 * in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. 
 * Print the URLs in the same order as they first appear in the input report. 
 * Print the output in the format given below. Use double floating-point precision. 
Examples:
Input	
2014-Mar-02 11:33 http://softuni.bg 8.37725
2014-Mar-02 11:34 http://www.google.com 1.335
2014-Mar-03 21:03 http://softuni.bg 7.25
2014-Mar-03 22:00 http://www.google.com 2.44
2014-Mar-03 22:01 http://www.google.com 2.45
2014-Mar-03 22:01 http://www.google.com 2.77
Output
http://softuni.bg -> 7.813625
http://www.google.com -> 2.24875
Input
2014-Apr-01 02:01 http://softuni.bg 8.37725
2014-Apr-01 02:05 http://www.nakov.com 11.622
2014-Apr-01 02:06 http://softuni.bg 4.33
2014-Apr-01 02:11 http://www.google.com 1.94
2014-Apr-01 02:11 http://www.google.com 2.011
2014-Apr-01 02:12 http://www.google.com 4.882
2014-Apr-01 02:34 http://softuni.bg 4.885
2014-Apr-01 02:36 http://www.nakov.com 10.74
2014-Apr-01 02:36 http://www.nakov.com 11.75
2014-Apr-01 02:38 http://softuni.bg 3.886
2014-Apr-01 02:44 http://www.google.com 1.04
2014-Apr-01 02:48 http://www.google.com 1.4555
2014-Apr-01 02:55 http://www.google.com 1.977
Output
http://softuni.bg -> 5.3695625
http://www.nakov.com -> 11.3706666666667
http://www.google.com -> 2.21758333333333
 */

using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        // Example 1:
        string report1 = @"2014-Mar-02 11:33 http://softuni.bg 8.37725
2014-Mar-02 11:34 http://www.google.com 1.335
2014-Mar-03 21:03 http://softuni.bg 7.25
2014-Mar-03 22:00 http://www.google.com 2.44
2014-Mar-03 22:01 http://www.google.com 2.45
2014-Mar-03 22:01 http://www.google.com 2.77";

        // Example 2:
        string report2 = @"2014-Apr-01 02:01 http://softuni.bg 8.37725
2014-Apr-01 02:05 http://www.nakov.com 11.622
2014-Apr-01 02:06 http://softuni.bg 4.33
2014-Apr-01 02:11 http://www.google.com 1.94
2014-Apr-01 02:11 http://www.google.com 2.011
2014-Apr-01 02:12 http://www.google.com 4.882
2014-Apr-01 02:34 http://softuni.bg 4.885
2014-Apr-01 02:36 http://www.nakov.com 10.74
2014-Apr-01 02:36 http://www.nakov.com 11.75
2014-Apr-01 02:38 http://softuni.bg 3.886
2014-Apr-01 02:44 http://www.google.com 1.04
2014-Apr-01 02:48 http://www.google.com 1.4555
2014-Apr-01 02:55 http://www.google.com 1.977";

        LTCalculator(report1);

        LTCalculator(report2);
    }

    private static void LTCalculator(string report1)
    {
        // separating the input lines
        string[] lines = report1.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

        // splitting input lines into details
        List<List<string>> details = new List<List<string>>();
        for (int i = 0; i < lines.Length; i++)
        {
            List<string> sublist = lines[i].Split(' ').ToList();
            details.Add(sublist);
        }

        // extracting data for the calculations
        Dictionary<string, List<Double>> data = new Dictionary<string, List<Double>>();

        // storing all individual URLs as keys, with vale all respective load times in a list
        for (int j = 0; j < lines.Length; j++)
        {
            if (!data.ContainsKey(details[j][2]))
            {
                data.Add(details[j][2], new List<Double>());
                data[details[j][2]].Add(Double.Parse(details[j][3]));
            }
            else
            {
                data[details[j][2]].Add(Double.Parse(details[j][3]));
            }
        }

        // printing
        Console.WriteLine("Report:");
        Console.WriteLine(report1);
        Console.WriteLine("\nOutput: ");
        foreach (KeyValuePair<string, List<Double>> pair in data)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value.Average());
        }
        Console.WriteLine();
    }
}

