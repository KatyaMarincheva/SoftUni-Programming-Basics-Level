/* Problem 15.	Extract URLs from Text
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
Examples:
Input	
The site nakov.com can be access from http://nakov.com or www.nakov.com. 
It has subdomains like mail.nakov.com and svetlin.nakov.com. 
Please check http://blog.nakov.com for more information.	
 * 
Output
http://nakov.com
www.nakov.com
http://blog.nakov.com
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        // Example:
        string text = @"The site nakov.com can be access from http://nakov.com or www.nakov.com. 
It has subdomains like mail.nakov.com and svetlin.nakov.com. 
Please check http://blog.nakov.com for more information.";

        // text to array of words
        string[] words = text.Split(' ').ToArray();

        // printing
        Console.WriteLine("Output:");
        foreach (string str in words)
        {
            if (IsUrl(str))
            {
                Console.WriteLine(str);
            }
        }
        Console.WriteLine();
        
    }

    // checking for URLs
    private static bool IsUrl(string url)
    {
        string pattern = @"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*";
        Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return reg.IsMatch(url);
    }
}

