// Problem 9. Play with Int, Double and String

/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
   If the variable is int or double, the program increases it by one.
   If the variable is a string, the program appends * at the end.
   Print the result at the console. Use switch statement.
*/

using System;

class IntDoubleString
{
    static void Main()
    {
        // choice input
        Console.Write("\nPlease enter 1 for integer, 2 for floating-point number, or 3 for string: ");
        byte choice;
        try
        {
            choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
            case 1:
                {
                    Console.Write("\nPlease enter a type int number: ");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nResult: {0}\n", ++integer);
                    break;
                }

            case 2:
                {
                    Console.Write("\nPlease enter a type double number: ");
                    double floatingPoint = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nResult: {0}\n", ++floatingPoint);
                    break;
                }

            case 3:
                {
                    Console.Write("\nPlease enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("\nResult: {0}*\n", str);
                    break;
                }
            default:
                {
                    Console.WriteLine("\nThis program works with 1, 2 or 3 for input.\n");
                    break;
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("\nThis program works with 1, 2 or 3 for input.\n");
        }      
    }
}

