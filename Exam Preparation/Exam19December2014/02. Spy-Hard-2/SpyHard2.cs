/* Problem 2 – Spy Hard
You are a handler. Your task is to relay messages between field operatives (spies), and headquarters (the CIA). The CIA developed a system; 
 * first, the operatives send coded messages to you, then you partially decrypt each message and relay it to headquarters 
 * where further decryption takes place. 
You will be given a key and a message. The key will be a number, it shows the base of the numeral system you’ll need to use for decryption. 
 * The message is comprised of various symbols which you convert to a number by adding together either the letter’s position 
 * in the alphabet (a = 1, b = 2, … , z = 26) if the symbol is a letter, or the symbol’s code in the ASCII table otherwise. 
 * After you get the sum of the symbols, you need to convert it to the numeral system provided by the key.
To headquarters you need to send a single string containing three numbers concatenated together; 
 * the first part will be the numeral system you used, next comes the number of symbols in the initial message 
 * and finally comes the partially decrypted message (a number in the specified numeral system). 
 * See the example below to get a clearer idea of the steps you need to take.
Input
The input data should be read from the console.
•	The first input line holds a number (the key).
•	The second input line holds a string (the message).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
•	On the only output line you must print the code you’ll transmit to headquarters.
Constraints
•	The key will be a number between 2 and 10 inclusive.
•	The length of the message will be between 1 and 100 symbols.
 */

using System;
using System.Text;

class SpyHard
{
    static void Main(string[] args)
    {
        int baseOfSystem = int.Parse(Console.ReadLine());
        Console.Write(baseOfSystem);

        string message = Console.ReadLine().ToLower();
        Console.Write(message.Length);

        int symbolSum = 0;

        for (int i = 0; i < message.Length; i++)
        {
            char currentSymbol = message[i];

            if (currentSymbol >= 'a' && currentSymbol <= 'z')
            {
                symbolSum += currentSymbol - 'a' + 1;
            }
            else
            {
                symbolSum += currentSymbol;
            }
        }

        StringBuilder numeralSystemConverter = new StringBuilder();

        while (symbolSum > 0)
        {
            numeralSystemConverter.Insert(0, symbolSum % baseOfSystem);
            symbolSum /= baseOfSystem;
        }

        Console.WriteLine(numeralSystemConverter);
    }
}