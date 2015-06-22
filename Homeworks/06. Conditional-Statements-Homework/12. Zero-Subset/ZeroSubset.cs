// Problem 12.* Zero Subset

//  We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        // allows me to instruct the console to read the dot as decimal point 
        // in floating-point type numbers
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        // intro
        string intro = @"This program enters 5 numbers,
and finds all subsets of these numbers whose sum is 0.";
        Console.WriteLine(intro);

        // input
        double[] nums = new double[5];
        while (true)
        {
            // limits the number of entries to the above chosen length = n
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please, enter a value for number {0}: ", (i + 1));
                nums[i] = double.Parse(Console.ReadLine());
            }

            double a = nums[0];
            double b = nums[1];
            double c = nums[2];
            double d = nums[3];
            double e = nums[4];
            bool zero = false;

            // logic
            if (a + b == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
                zero = true;
            }

            if (a + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
                zero = true;
            }

            if (a + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
                zero = true;
            }

            if (a + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
                zero = true;
            }

            if (b + c == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
                zero = true;
            }

            if (b + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
                zero = true;
            }

            if (b + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
                zero = true;
            }

            if (c + d == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
                zero = true;
            }

            if (c + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
                zero = true;
            }

            if (d + e == 0)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
                zero = true;
            }

            if (a + b + c == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                zero = true;
            }

            if (a + b + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                zero = true;
            }

            if (a + b + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                zero = true;
            }

            if (a + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                zero = true;
            }

            if (a + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                zero = true;
            }

            if (a + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
                zero = true;
            }

            if (b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                zero = true;
            }

            if (b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                zero = true;
            }

            if (b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                zero = true;
            }

            if (c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                zero = true;
            }

            if (a + b + c + d == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                zero = true;
            }

            if (a + b + c + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                zero = true;
            }

            if (a + b + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
                zero = true;
            }

            if (a + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
                zero = true;
            }

            if (b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
                zero = true;
            }

            if (a + b + c + d + e == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
                zero = true;
            }

            if (!zero)
            {
                Console.WriteLine("No zero subset.");
            }
        }
    }
}

