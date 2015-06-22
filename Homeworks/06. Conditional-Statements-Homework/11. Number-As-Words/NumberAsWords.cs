// Problem 11.* Number as Words

// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
using System.Linq;

class NumberAsWords
{
    static void Main()
    {

            // intro
            string intro = "This program converts a number in the range [0…999] to words.";
            Console.WriteLine(intro);

            // declarations
            int units;
            int tens;
            int tens1;
            int hundreds;

        while (true)
        {
            // input
            Console.Write("\nPlease enter a number in the range [0…999]: ");
            int[] digits = Console.ReadLine().Select(c => c - '0').ToArray();

            // logic
            switch (digits.Length)
            {
                case 1:
                    {
                        units = digits[0];
                        UnitsNames(units);
                        break;
                    }
                case 2:
                    {
                        tens = digits[0];
                        units = digits[1];

                        if (tens == 1)
                        {
                            tens1 = digits[1];
                            TensOneNames(tens1);
                        }
                        else if (tens > 1)
                        {
                            TensNames(tens);
                            UnitsNames(units);
                        }
                        break;
                    }
                case 3:
                    {
                        hundreds = digits[0];
                        tens = digits[1];
                        units = digits[2];

                        HundredsNames(hundreds);

                        if (tens == 1)
                        {
                            Console.Write(" and ");
                            tens1 = digits[2];
                            TensOneNames(tens1);
                        }
                        else if (tens > 1)
                        {
                            TensNames(tens);
                            UnitsNames(units);
                        }
                        else if (tens == 0)
                        {
                            Console.Write(" and ");
                            UnitsNames(units);
                        }
                        break;
                    }
            }
        }
    }

    private static void HundredsNames(int hundreds)
    {
        switch (hundreds)
        {


            case 1:
                {
                    Console.Write("one hundred");
                    break;
                }

            case 2:
                {
                    Console.Write("two hundred");
                    break;
                }

            case 3:
                {
                    Console.Write("three hundred");
                    break;
                }

            case 4:
                {
                    Console.Write("four hundred");
                    break;
                }

            case 5:
                {
                    Console.Write("five hundred");
                    break;
                }

            case 6:
                {
                    Console.Write("six hundred");
                    break;
                }

            case 7:
                {
                    Console.Write("seven hundred");
                    break;
                }

            case 8:
                {
                    Console.Write("eight hundred");
                    break;
                }

            case 9:
                {
                    Console.Write("nine hundred");
                    break;
                }
        }
    }

    private static void TensNames(int tens)
    {
        switch (tens)
        {
            case 2:
                {
                    Console.Write(" twenty");
                    break;
                }

            case 3:
                {
                    Console.Write(" thirty");
                    break;
                }

            case 4:
                {
                    Console.Write(" fourty");
                    break;
                }

            case 5:
                {
                    Console.Write(" fifty");
                    break;
                }

            case 6:
                {
                    Console.Write(" sixty");
                    break;
                }

            case 7:
                {
                    Console.Write(" seventy");
                    break;
                }

            case 8:
                {
                    Console.Write(" eighty");
                    break;
                }

            case 9:
                {
                    Console.Write(" ninety");
                    break;
                }
        }
    }

    private static void TensOneNames(int tens1)
    {
        switch (tens1)
        {
            case 0:
                {
                    Console.Write("ten\n");
                    break;
                }

            case 1:
                {
                    Console.Write("eleven\n");
                    break;
                }

            case 2:
                {
                    Console.Write("twelve\n");
                    break;
                }

            case 3:
                {
                    Console.Write("thirteen\n");
                    break;
                }

            case 4:
                {
                    Console.Write("fourteen\n");
                    break;
                }

            case 5:
                {
                    Console.Write("fifteen\n");
                    break;
                }

            case 6:
                {
                    Console.Write("sixteen\n");
                    break;
                }

            case 7:
                {
                    Console.Write("seventeen\n");
                    break;
                }

            case 8:
                {
                    Console.Write("eighteen\n");
                    break;
                }

            case 9:
                {
                    Console.WriteLine("nineteen\n");
                    break;
                }
        }
    }

    private static void UnitsNames(int units)
    {
        switch (units)
        {
            case 0:
                {
                    Console.Write("\nzero\n");
                    break;
                }

            case 1:
                {
                    Console.Write(" one\n");
                    break;
                }

            case 2:
                {
                    Console.Write(" two\n");
                    break;
                }

            case 3:
                {
                    Console.Write(" three\n");
                    break;
                }

            case 4:
                {
                    Console.Write(" four\n");
                    break;
                }

            case 5:
                {
                    Console.Write(" five\n");
                    break;
                }

            case 6:
                {
                    Console.Write(" six\n");
                    break;
                }

            case 7:
                {
                    Console.Write(" seven\n");
                    break;
                }

            case 8:
                {
                    Console.Write(" eight\n");
                    break;
                }

            case 9:
                {
                    Console.Write(" nine\n");
                    break;
                }
        }
    }
}


