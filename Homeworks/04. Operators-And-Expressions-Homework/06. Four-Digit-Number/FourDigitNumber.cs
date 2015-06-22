//  Problem 6. Four-Digit Number

/* Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * 
 *      Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 *      Prints on the console the number in reversed order: dcba (in our example 1102).
 *      Puts the last digit in the first position: dabc (in our example 1201).
 *      Exchanges the second and the third digits: acbd (in our example 2101).
 *
 * The number has always exactly 4 digits and cannot start with 0.
 *
 * Examples:
 * n 	sum of digits 	reversed 	last digit in front 	second and third digits exchanged
 * 2011 	 4 	        1102 	    1201 	                2101
 * 3333 	12 	        3333 	    3333 	                3333
 * 9876 	30 	        6789 	    6987 	                9786   
 */

using System;
using System.Collections.Generic; // contains (allows the use of) the List<T> Class
using System.Linq; // contains (allows the use of) the List<T>.Sum() method

class FourDigitNumber
{
    // the method GetDigit() gets the value of the digit at a given position, in a given number
    static int GetDigit(int number, int digit)
    {
        return (number / (int)Math.Pow(10, digit - 1)) % 10;
    }

    static void Main()
    {
        // lists to store the extracted digits of the 4-digit number, 1 copie in each list
        List<int> workString = new List<int>();
        List<int> digitString = new List<int>();


        string intro = @"This program takes a four-digit number as input;
calculates the sum of its digits, prints the number:
reversed, last digit first, 2nd and 3rd digits exchanged.";
        Console.WriteLine(intro);

        string input;
        int num;

        do  // validates number input
        {
            Console.Write("\nPlease enter a four-digit number \nbetween 1000 and 9999: ");
            input = Console.ReadLine();

        } while ((!int.TryParse(input, out num)) || (input.Length != 4) || num < 1000);

        // the values of the number 1234, will be retrieved in the order 4-3-2-1
        for (int i = 1; i <= 4; i++)
        {
            int digitValue = GetDigit(num, i); 

            workString.Add(digitValue);
            digitString.Add(digitValue);
        }

        // from the retrieved (4-3-2-1) to the original (1-2-3-4)
        digitString.Reverse();


        // "" means that, in the result string, there will be no separators between the joined array elements
        string stringNumber = string.Join("", digitString.ToArray());

        // List<T>.Sum() method - calculates the sum of all list elements (digits) (1st task)
        int sumOfDigits = digitString.Sum();

        // my second task was to print the input number digits in reversed order (4-3-2-1) (2nd task)
        string reversed = string.Join("", workString.ToArray());

        // Reverse(1, 3) changes the order in workString from 4-3-2-1 to 4-1-2-3 (3rd task)
        workString.Reverse(1, 3);
        string lastDigitInFront = string.Join("", workString.ToArray());

        // Reverse(1, 2) changes the order in digitString from 1-2-3-4 to 1-3-2-4 (4th  task)
        digitString.Reverse(1, 2); 
        string secondAndThirdDigitsExchanged = string.Join("", digitString.ToArray());

        // preparing a table view output....
        string separator = new String('-', 95);
        Console.WriteLine("\n{0}", separator);
        Console.WriteLine("| number | sum of digits | reversed | last digit in front | second and third digits exchanged |");
        Console.WriteLine(separator);
        Console.WriteLine("| {0,6} | {1,13} | {2,8} | {3,19} | {4,33} |", stringNumber, sumOfDigits.ToString().PadLeft(2), reversed, lastDigitInFront, secondAndThirdDigitsExchanged);
        Console.WriteLine("{0}\n", separator);

            // Done!
    }
}



