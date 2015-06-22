// Problem 1. Declare Variables

// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

// Submit the source code of your Visual Studio project as part of your homework submission.

using System;
using System.Collections.Generic; // contains (allows the use of) the List<T> Class
using System.Linq; // contains (allows the use of) the List<T>.Except method
using System.Threading; // because I wanted to use the Thread.Sleep() method, and pause the program at times

class DeclareVariablesAutomated
{
    static void Main()
    {
        // below I initialize 5 lists into which I will be storing byte, sbyte, short ushort, and int numbers respectively
        List<int> intNumbers1 = new List<int> { 52130, -115, 4825932, 97, -10000 };
        List<int> byteNumbers = new List<int>();
        List<int> sbyteNumbers = new List<int>();
        List<int> shortNumbers = new List<int>();
        List<int> ushorNumbers = new List<int>();

        Console.WriteLine("This is my initial list of variables. \nI have stored them into an int List.\n");

        // prints all numbers from the above list, displays their type; for the time being they are all stored as integers
        foreach (int intNumber1 in intNumbers1) // loops over all strings in the input list
        {
            Console.WriteLine("{0} {1}", intNumber1.GetType().Name, intNumber1);
        }

        Thread.Sleep(1000); // pauses the program so that the next print comes with a given delay

        Console.WriteLine("\nFurther my program will: ");
        Console.WriteLine("* use the GetType() method to obtain the data type of the initially stored numbers; \n* use the Convert class with the appropriate respective ToByte(), etc. methods \nto automatically sieve the initially stored numbers into their respective byte, sbyte, short, ushort lists");
        Console.WriteLine("* use again the GetType() method to display the data type of the numbers after they have been added \nto their appropriate data type lists.");

        Thread.Sleep(5000);

        // the code below tries to convert all integers from the initial list into type byte numbers, 
        // bigger numbers make the program throw an exception
        foreach (int intNumber1 in intNumbers1)
        {
            try
            {
                byte byteNumber = Convert.ToByte(intNumber1); // tries to convert the number, initially stored as int, into byte
                byteNumbers.Add(byteNumber); // adds byte to byteNumbers

                // displays the resulting byte, as well as its type
                Console.WriteLine("\n{0} {1}", byteNumber.GetType().Name, byteNumber);
            }
            catch (Exception)
            {
                continue; // tells the program to leave this foreach statement and go to the next block of code
            }
        }

        Thread.Sleep(1000);
        // the type byte numbers are then excluded from the initial intNumbers1 list, 
        //and the rest of the numbers are stored into e new, intNumbers2 list 
        // - so that the program doesn't try to store small numbers into bigger data types, and so on...
        List<int> intNumbers2 = intNumbers1.Except(byteNumbers).ToList();

        // tries to store the rest of the numbers into type sbyte variables
        foreach (int intNumber2 in intNumbers2)
        {
            try
            {
                sbyte sbyteNumber = Convert.ToSByte(intNumber2);  // tries to convert the number, initially stored as int, into sbyte
                sbyteNumbers.Add(sbyteNumber); // adds sbyte to sbyteNumbers

                // displays the resulting sbyte, as well as its type
                Console.WriteLine("\n{0} {1}", sbyteNumber.GetType().Name, sbyteNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(1000);

        //the type sbyte numbers are excluded, 
        //and the numbers which are still to be converted are stored into a new, shorter list
        List<int> intNumbers3 = intNumbers2.Except(sbyteNumbers).ToList();

        // tries to store the rest of the numbers into type short variables
        foreach (int intNumber3 in intNumbers3)
        {
            try
            {
                short shortNumber = Convert.ToInt16(intNumber3);  // tries to convert the number, initially stored as int, into short
                shortNumbers.Add(shortNumber); // adds short to shortNumbers

                // displays the resulting short, as well as its type
                Console.WriteLine("{0} {1}", shortNumber.GetType().Name, shortNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(1000);

        //the type short numbers are excluded, 
        //and the numbers which are still to be converted are stored into a new, shorter list
        List<int> intNumbers4 = intNumbers3.Except(shortNumbers).ToList();

        // tries to store the rest of the numbers into type ushort variables
        foreach (int intNumber4 in intNumbers4)
        {
            try
            {
                ushort ushortNumber = Convert.ToUInt16(intNumber4);  // tries to convert the number, initially stored as int, into ushort
                ushorNumbers.Add(ushortNumber); // adds ushort to ushortNumbers

                // displays the resulting ushort, as well as its type
                Console.WriteLine("{0} {1}", ushortNumber.GetType().Name, ushortNumber);
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine();

        Thread.Sleep(2000);

        // as the console prints, one of the initially stored numbers stays integer
        Console.WriteLine("One of the initially stored numbers has remained into the initial int List and is still declared as an integer, as this is it's most appropriate data type:");
        List<int> intNumbersFinal = intNumbers4.Except(ushorNumbers).ToList();

        Thread.Sleep(2000);

        foreach (int numberFinal in intNumbersFinal)
        {
            Console.WriteLine("\n{0} {1}", numberFinal.GetType().Name, numberFinal); // prints the data type of the last remaining integer
        }
        Console.WriteLine();

        // prints data type information
        Console.WriteLine("Data type information: \n\nInt16 -> alias of short \nUInt16 -> alias of ushort \nInt32 -> alias of int \nUInt32 -> alias of uint \nInt64 -> alias of long \nUInt64 -> alias of ulong");

        Console.WriteLine("\nNow, please, test if the above algorithm works for any integral type number.");

        string result;
        do
        {
            Console.WriteLine("Please type below a number between -9223372036854775808 and 18446744073709551615, and press Enter:");
            //Start: // the program can be restarted from this point on, so that you can enter and test the program on multiple input numbers

            string inputNumber = Console.ReadLine();

            // similar to the above sieve algorithm, only this time all exception numbers are caught, 
            // and entered into the next try Convert.To... code block
            try
            {
                byte byteNumberOut = Convert.ToByte(inputNumber); // tries to convert input string into byte

                // displays the resulting byte, as well as its type
                Console.WriteLine("\n{0} {1}\n", byteNumberOut.GetType().Name, byteNumberOut);
            }
            catch (Exception)
            {
                try
                {
                    sbyte sbyteNumberOut = Convert.ToSByte(inputNumber); // tries to convert input string into sbyte

                    // displays the resulting sbyte, as well as its type
                    Console.WriteLine("\n{0} {1}\n", sbyteNumberOut.GetType().Name, sbyteNumberOut);
                }
                catch (Exception)
                {
                    try
                    {
                        short shortNumberOut = Convert.ToInt16(inputNumber); // tries to convert input string into short

                        // displays the resulting short, as well as its type
                        Console.WriteLine("\n{0} {1}\n", shortNumberOut.GetType().Name, shortNumberOut);

                    }
                    catch (Exception)
                    {
                        try
                        {
                            ushort ushortNumberOut = Convert.ToUInt16(inputNumber); // tries to convert input string into ushort

                            // displays the resulting ushort, as well as its type
                            Console.WriteLine("\n{0} {1}\n", ushortNumberOut.GetType().Name, ushortNumberOut);
                        }
                        catch (Exception)
                        {
                            try
                            {
                                int intNumberOut = Convert.ToInt32(inputNumber); // tries to convert input string into int

                                // displays the resulting int, as well as its type
                                Console.WriteLine("\n{0} {1}\n", intNumberOut.GetType().Name, intNumberOut);
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    uint uintNumberOut = Convert.ToUInt32(inputNumber);  // tries to convert input string into uint

                                    // displays the resulting uint, as well as its type
                                    Console.WriteLine("\n{0} {1}\n", uintNumberOut.GetType().Name, uintNumberOut);
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        long longNumberOut = Convert.ToInt64(inputNumber); // tries to convert input string into long

                                        // displays the resulting long, as well as its type
                                        Console.WriteLine("\n{0} {1}\n", longNumberOut.GetType().Name, longNumberOut);
                                    }
                                    catch (Exception)
                                    {
                                        try
                                        {
                                            ulong ulongNumberOut = Convert.ToUInt64(inputNumber); // tries to convert input string into ulong

                                            // displays the resulting ulong, as well as its type
                                            Console.WriteLine("\n{0} {1}\n", ulongNumberOut.GetType().Name, ulongNumberOut);
                                        }
                                        catch (Exception) // catches the exception (not-number input) and prompts user to enter new input number
                                        {
                                            Console.WriteLine("\nThe input string is not a valid integral type number or is too big to be stored into an integral type variable. \n(please also note that computer memory cannot store numbers smaller than -9223372036854775808 \nor bigger than 18446744073709551615 in an integral type variable, and you will need to store them in type decimal, BigInteger, or string variables).");
                                            //goto Start;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            do
            {
                // interactive code: accepts Yes and No input, ignores case and length of answer
                Console.Write("Would you like to try again? Y/N: ");
                result = Console.ReadLine();
                if (result.Equals("y", StringComparison.OrdinalIgnoreCase) || result.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    // the program 
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
