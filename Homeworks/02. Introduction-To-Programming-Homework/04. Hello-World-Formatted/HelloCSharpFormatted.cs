// HelloCSharpF.cs - Problem 4. Hello World - Create, compile and run a “Hello C#” console application.
// a program to print the text "Hello C#!", and add some formatting to the console output

using System;

class HelloCSharpFormatted
{
    static void Main()
    {
        Console.Title = "Hello, World! (formatted)"; // adds a console title

        /*I will first declare a string Hello, holding the text which I intend to print
         using the String.Length property I will later be able to center the text on the console*/
        string hello = "Hello, C#!";

        // the next liines of code will apply some position, size and color formatting to the console output
        Console.SetWindowPosition(0, 0);  // sets the position of the console window relative to the screen buffer
        Console.CursorTop = 2; // sets the cursor on row 3 of the console (2 rows below the top of the console buffer)
        Console.ForegroundColor = ConsoleColor.Red; // sets the text color

        // prints the text "Hello C#!, and centers it on the console
        Console.WriteLine("{0," + ((Console.WindowWidth / 2) + hello.Length / 2) + "}", hello);

        // I am adding the next two lines of code for aesthetic purposes in this case, as I want to see only the text "Hello C#! on the console:
        Console.CursorVisible = false;  // hides the cursor
        Console.ReadLine();             // hides the "Press any key to continue" message
    }
}
