// Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.


using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine("Initial values: \na = {0} \nb = {1}\n\n", a, b);

        a ^= b ^= a; //The ^ operator performs a bitwise exclusive-OR operation on integral operands 
        b ^= a;

        Console.WriteLine("Final values: \na = {0} \nb = {1}\n\n", a, b);

        Console.ReadLine();

        /*Explanation: 
         * a = 5 =  0101 (binary)
         * b = 10 = 1010 (binary)
         * 
         * 1. We start from the b ^=a expression on the upper row:
         * b ^=a is b = b ^ a, which is: 1010
         *                               0101
         *                       result: 1111 (now b = 15, and a = 5)
         *                       
         * 2. We proceed with the a ^= b expression, only a is still 5, and b is now 15:
         * a ^= b is a = a ^ b, which is 0101
         *                               1111
         *                       result: 1010 (now a = 10, and b = 15)
         *  as a result of the whole expression a ^= b ^= a, a is now equal to 10 (a has now the iniitial value of b);
         *  and for the moment b = 15;
         *  
         * 3. The final operation:
         * b ^= a is b = b ^ a; which is 1111
         *                               1010
         *                       result: 0101 (now a = 10, and b = 5)      
         *                       
         * The values of a and be have been swapped.
         */
    }
}


