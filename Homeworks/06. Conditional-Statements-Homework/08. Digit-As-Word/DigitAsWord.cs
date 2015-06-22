// Problem 8. Digit as Word

/* Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
   Print “not a digit” in case of invalid input.
   Use a switch statement.

Examples:
 d 	    result
 2 	    two
 1 	    one
 0 	    zero
 5 	    five
-0.1 	not a digit
hi 	    not a digit
 9 	    nine
10 	    not a digit
 */
using System;

class DigitAsWord
{
    static void Main()
    {
        // declarations
        byte digit;
        bool isDigit;

        // input
        Console.Write("\nPlease, enter a digit (0-9): ");
        isDigit = byte.TryParse(Console.ReadLine(), out digit);

        Console.WriteLine("\n{0, -6}{1, -12}", "d", "result");
        Console.Write("{0, -6}", digit);
        // logic
        if (isDigit)
        {
            switch (digit)
            {
                case 0:
                    {
                        Console.Write("{0, -12}\n", "zero");
                        break;
                    }

                case 1:
                    {
                        Console.Write("{0, -12}\n", "one");
                        break;
                    }

                case 2:
                    {
                        Console.Write("{0, -12}\n", "two");
                        break;
                    }

                case 3:
                    {
                        Console.Write("{0, -12}\n", "three");
                        break;
                    }

                case 4:
                    {
                        Console.Write("{0, -12}\n", "four");
                        break;
                    }

                case 5:
                    {
                        Console.Write("{0, -12}\n", "five");
                        break;
                    }

                case 6:
                    {
                        Console.Write("{0, -12}\n", "six");
                        break;
                    }

                case 7:
                    {
                        Console.Write("{0, -12}\n", "seven");
                        break;
                    }

                case 8:
                    {
                        Console.Write("{0, -12}\n", "eight");
                        break;
                    }

                case 9:
                    {
                        Console.Write("{0, -12}\n", "nine");
                        break;
                    }

                default:
                    {
                        Console.Write("{0, -12}\n", "not a digit");
                        break;
                    }
            }
        }

        Console.WriteLine();
    }
}

