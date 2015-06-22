// Problem 7. Print First and Last Name - Create console application that prints your first and last name, each at a separate line.

using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Title = "Print First and Last Name";

        // "\n" below is used as a new line character
        // {0,10} is an instance of string formating - it's a placeholder, which also sets a virtual 10-digit wide cell, 
        // and aligns the string in it as requested: {0,10} for right alignment, {0,-10} for left alignment
        Console.WriteLine("\n{0,10}\n{1,10}", "Name:", "Surname:");

        Console.CursorVisible = false;
        Console.ReadLine();
    }
}