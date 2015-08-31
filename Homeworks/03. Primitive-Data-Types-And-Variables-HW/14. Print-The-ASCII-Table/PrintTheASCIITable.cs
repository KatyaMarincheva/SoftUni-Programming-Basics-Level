// Problem 14.* Print the ASCII Table

// Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
// Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
//Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        /* In order to display the intended result please DO NOT use the console's "Raster Fonts". */
        Console.Title = "Problem 14. *Print the ASCII Table";

        char[] controlCharsSpecialCases = new char[] { '\u2022', '\u25D8', '\u25CB', '\u25D9', '\u2642', '\u2640', '\u266A' };
        int windowWidth = Console.LargestWindowWidth / 2;
        int windowHeight = Console.LargestWindowHeight / 2;
        Console.SetWindowSize(windowWidth, windowHeight);
        Console.SetBufferSize(windowWidth, 300);
        Console.OutputEncoding = Encoding.Unicode;
        Encoding encodingOEMUnitedStates = Encoding.GetEncoding(437);

        Console.WriteLine("{0} -> {1}", 0, "null");
        for (int i = 1; i < 255; i++)
        {
            if (i == 7 || i == 32 || i == 127)
            {
                if (i == 7)
                {
                    for (int j = 0; j < controlCharsSpecialCases.Length; j++)
                    {
                        Console.WriteLine("{0} -> {1}", i + j, controlCharsSpecialCases[j]);
                    }
                    i += controlCharsSpecialCases.Length;
                }
                else if (i == 32)
                {
                    Console.WriteLine("{0} -> {1}", i, "space");
                }
                else if (i == 127)
                {
                    Console.WriteLine("{0} -> {1}", i, '⌂');
                }
            }
            else
            {
                string character = encodingOEMUnitedStates.GetString(new byte[] { (byte)i });
                Console.WriteLine("{0} -> {1}", i, character);
            }
        }
        Console.WriteLine("255 -> non-breaking space");
    }
}
