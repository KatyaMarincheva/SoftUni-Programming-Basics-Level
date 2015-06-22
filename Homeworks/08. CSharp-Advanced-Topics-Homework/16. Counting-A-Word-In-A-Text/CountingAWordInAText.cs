/* Problem 16.	* Counting a Word in a Text
Write a program that counts how many times a given word occurs in given text. 
 * The first line in the input holds the word. The second line of the input holds the text. 
 * The output should be a single integer number – the number of word occurrences. 
 * Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. 
 * A word is a sequence of letters separated by punctuation or start / end of text. 
 * Examples:
Input	                                                                Output
hi
Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!	3
 * 
SoftUni
The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni
Output 5

SoftUni
Software University	
Output 0

SoftUni
SoftUni	
Output 1

SoftUni
SoftUni.SoftUni	
Output 2
 */

using System;
using System.Text.RegularExpressions;

class CountingAWordInAText
{
    static int CompareWords(string inputWord, string inputText)
    {
        string[] allWords = inputText.Split(
            new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int counter = 0;

        for (int i = 0; i < allWords.Length; i++)
        {
            if (string.Equals(allWords[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        string keyWord = "SoftUni";
        string someText = @"The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";

        int result = CompareWords(keyWord, someText);
        Console.WriteLine(result);
    }
}

