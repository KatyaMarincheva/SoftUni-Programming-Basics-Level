// Problem 16. Decimal to Hexadecimal Number

/*  Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.

Examples:
decimal 	    hexadecimal
254 	        FE
6883 	        1AE3
338583669684 	4ED528CBB4
 */

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        // input
        Console.Write("Please enter an integer number: ");
        long num = long.Parse(Console.ReadLine());

        // logic:
        string hex = string.Empty; // this is the string to which we will be appending the hex symbols
        // if the entered decimal value is 0 - we print 0
        if (num == 0)
        {
            Console.WriteLine("The hexadecimal representation of the number you entered is: {0}\n", num.ToString());
        }

        else
        {   // for values > 0:  num % 16 = hex symbol => num/16 and again num % 16 = next hex symbol .... while num > 0
            while (num > 0)
	            {
                    string hexSymbol = "0"; 
                    long remainder = num % 16;

		                switch (remainder)
                        {   // for remainder values above 9, we assign the respective letter symbol
                            case 10: hexSymbol = "A";
                                break;
                            case 11: hexSymbol = "B";
                                break;
                            case 12: hexSymbol = "C";
                                break;
                            case 13: hexSymbol = "D";
                                break;
                            case 14: hexSymbol = "E";
                                break;
                            case 15: hexSymbol = "F";
                                break;
                            default: hexSymbol = remainder.ToString();
                                break;
                        }
                        hex += hexSymbol; // each hex symbol added to the initially declared string
                        num /= 16;
	                }

            // the hex symbols are retrieved in reversed order, so we will apply the Array.Reverse() method to reverse the hex symbols order
            var temp = hex.ToCharArray();
            Array.Reverse(temp);
            hex = new String(temp); // final hex string with symbols into the correct order

            // printing...
            Console.WriteLine("The hexadecimal representation of the number you entered is: {0}\n", hex);
	    }
    }
}


