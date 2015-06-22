// Problem 5. Print Reader's Name - Modifies the Hello World application to accept as input and print reader's name.

using System;

class PrintReadersName
{
    static void Main()
    {
        Console.Title = "Print Reader's Name";

        Console.Write("Please, type your name and press Enter: ");

        string name = Console.ReadLine(); // reads the input string (reader's name in this case) from the console

        // "\n" below is used as a new line character, or line feed; {0} is a place holder - holds a place within a string for a variable value
        Console.WriteLine("\nHello, {0}!", name);

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}
