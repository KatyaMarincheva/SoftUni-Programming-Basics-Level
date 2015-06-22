// Problem 8. Isosceles Triangle

/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©

Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it. */

using System;
using System.Text;
using System.Threading;

class IsoscelesTriangleTwo
{
    protected static void WriteAt(char copiright, int x, int y)
    {
        char copyright = '\u00A9';
        try
        {
            Console.SetCursorPosition(x, y);
            Console.Write(copyright);
            Thread.Sleep(200);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyright = '\u00A9';

        // Draw the right side of the isosceles triangle, from bottom to top.
        for (int x = 19, y = 9; x >= 13; x -= 2, y -= 2)
        {
            WriteAt(copyright, x, y);
        }

        // Draw the left side of the isosceles triangle, from top to bottom.
        for (int x = 11, y = 5; x >= 7; x -= 2, y += 2)
        {
            WriteAt(copyright, x, y);
        }

        // Draw the bottom side of the isosceles triangle, from left to right.
        for (int x = 11, y = 9; x <= 15; x += 4)
        {
            WriteAt(copyright, x, y);
        }

        Console.WriteLine();
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}

