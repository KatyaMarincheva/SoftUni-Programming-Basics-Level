using System;
using System.Globalization;
using System.Threading;

class FloatOrDouble
{
    static void Main()
    {
        CultureInfo en = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentCulture = en;

        double numberOne = 34.567839023;
        float numberTwo = 12.345f;
        double numberThree = 8923.1234857;
        float numberFour = 3456.091f;

        Console.WriteLine("{0} {1} \n{2} {3} \n{4} {5} \n{6} {7}", numberOne.GetType().Name, numberOne, numberTwo.
            GetType().Name, numberTwo, numberThree.GetType().Name, numberThree, numberFour.GetType().Name, numberFour);

        Console.WriteLine("\nData type information: \n\nSingle -> alias of float\n");
    }
}
