using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class FloatOrDoubleAutomated
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        Console.WriteLine("This is my initial list of variables. \nI have stored them into a list of type string variables.\n");

        Thread.Sleep(1000);

        List<string> input = new List<string>() { "34.567839023", "12.345", "8923.1234857", "3456.091", "-3456.091" };
        List<float> floats = new List<float>();
        List<double> doubles = new List<double>();

        Thread.Sleep(1000);

        foreach (string inputString in input)
        {
            Console.WriteLine("{0} {1}", inputString.GetType().Name, inputString);
        }

        Thread.Sleep(1000);

        Console.WriteLine("\nFurther my program will: ");
        Console.WriteLine("* use the GetType() method to obtain the data type of the initially stored input strings; \n* get the lenght of each string in the initial input list; \n* Convert.ToSingle() all strings with Length <= 8 (including the decimal point), \nas they will obviously not get rounded if stored in type float (Single) variables;");
        Console.WriteLine("* Convert.ToDouble() all strings with Length > 8, \nso that they can be stored without rounding, in type double variables; \n* use again the GetType() method to display the data type of all variables \nafter they have been added to their appropriate type float (Single) or type double lists.");

        Thread.Sleep(5000);

        foreach (string inputString in input)
        {
            bool contains = inputString.Contains('-');

            if (inputString.Length <= 8 && contains == false)
            {
                float floatNumber = Convert.ToSingle(inputString);
                floats.Add(floatNumber);
                Console.WriteLine("\n{0} {1}", floatNumber.GetType().Name, floatNumber);

                Thread.Sleep(1000);
            }
            else if (inputString.Length > 8 && contains == false)
            {
                double doubleNumber = Convert.ToDouble(inputString);
                doubles.Add(doubleNumber);
                Console.WriteLine("\n{0} {1}", doubleNumber.GetType().Name, doubleNumber);

                Thread.Sleep(1000);
            }
            if (inputString.Length <= 9 && contains == true)
            {
                float floatNumber = Convert.ToSingle(inputString);
                floats.Add(floatNumber);
                Console.WriteLine("\n{0} {1}", floatNumber.GetType().Name, floatNumber);

                Thread.Sleep(1000);
            }
            else if (inputString.Length > 9 && contains == true)
            {
                double doubleNumber = Convert.ToDouble(inputString);
                doubles.Add(doubleNumber);
                Console.WriteLine("\n{0} {1}", doubleNumber.GetType().Name, doubleNumber);

                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\nNow, please, test if the above algorithm works for any floating-point type number.");

        string result;
        do
        {
            Console.WriteLine("Please type below any positive or negative number of a total of up to 15 digits, \nexcluding the \"-\" sign, and press Enter:");
            string inputNumber = Convert.ToString(Console.ReadLine());

            bool negative = inputNumber.Contains('-');
            try
            {
                if (inputNumber.Length <= 8 && negative == false)
                {
                    float floatNumberOut = Convert.ToSingle(inputNumber);

                    Console.WriteLine("\n{0} {1}", floatNumberOut.GetType().Name, floatNumberOut);

                    Thread.Sleep(1000);
                }
                else if (inputNumber.Length > 8 && inputNumber.Length <= 15 && negative == false)
                {
                    double doubleNumberOut = Convert.ToDouble(inputNumber);

                    Console.WriteLine("\n{0} {1}", doubleNumberOut.GetType().Name, doubleNumberOut);
                }
                if (inputNumber.Length <= 9 && negative == true)
                {
                    float negFloatNumberOut = Convert.ToSingle(inputNumber);

                    Console.WriteLine("\n{0} {1}", negFloatNumberOut.GetType().Name, negFloatNumberOut);
                }
                else if (inputNumber.Length > 9 && inputNumber.Length <= 16 && negative == true)
                {
                    double negDoubleNumberOut = Convert.ToDouble(inputNumber);

                    Console.WriteLine("\n{0} {1}\n ", negDoubleNumberOut.GetType().Name, negDoubleNumberOut);
                }
                else if (inputNumber.Length > 16 && negative == true)
                {
                    decimal negDecimalNumberOut = Convert.ToDecimal(inputNumber);

                    Console.WriteLine("\nYou have entered a number of more than 15 digits. \nTo avoid rounding the input number, instead of storiing it in one of the above floating.point variables, \nthis program has chosen to store the input number into a decimal type variable: \n\n{0} {1}\n ", negDecimalNumberOut.GetType().Name, negDecimalNumberOut);
                }
                else if (inputNumber.Length > 15 && negative == false)
                {
                    decimal DecimalNumberOut = Convert.ToDecimal(inputNumber);

                    Console.WriteLine("\nYou have entered a number of more than 15 digits. \nTo avoid rounding the input number, instead of storing it in one of the above floating.point variables, \nthis program has chosen to store the input number into a decimal type variable: \n\n{0} {1}\n ", DecimalNumberOut.GetType().Name, DecimalNumberOut);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nThe input string is not a valid number.");

            }

            do
            {
                Console.Write("Would you like to try again? Y/N: ");
                result = Console.ReadLine();
                if (result.Equals("y", StringComparison.OrdinalIgnoreCase) || result.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                }
                else if (result.Equals("n", StringComparison.OrdinalIgnoreCase) || result.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nThank you for testing my program!\n");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Well, Yes or No :)");
                }
            } while (!result.Equals("n") && !result.Equals("y"));
            
        } while (!result.Equals("n"));

    }
}


