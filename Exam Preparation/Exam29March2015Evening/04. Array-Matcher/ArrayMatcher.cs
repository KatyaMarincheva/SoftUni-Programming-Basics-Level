/* Problem 4 – Array Matcher
You are given a string that consists of two character arrays and a command. 
 * Your task is to create a new array from the given two by executing the command. 
If the command says "join" it means that you should create an array with elements that are contained in both arrays. 
 * If the command says "right exclude" it means that the newly created array should contain only elements from the first array 
 * that are not contained in the second array. If the command says "left exclude" it means that you should create an array 
 * with elements from the second array that are not contained in the first array. 
The newly created array should have its elements sorted by their ASCII code. Examples:
1.	You are given the array "ABCD", the array "CAFG" and the command "join". The new array should be "AC".
2.	You are given the array "ABCD", the array "CAFG" and the command "right exclude". The new array should be "BD".
3.	You are given the array "ABCD", the array "CAFG" and the command "left exclude". The new array should be "FG".
Input
The input data should be read from the console.
•	A single line containing the two arrays and the command, separated by a '\' sign.

The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
The output should be printed on the console. It should consist of exactly 1 line:
•	The output should be the elements of the newly formed array, sorted by their ASCII code.

Constraints
•	The characters of the arrays will be characters from the ASCII table.
•	Each element in an array will have only one occurrence.
 */

using System;
using System.Linq;

class ArrayMatcher
{
    static void Main()
    {
        // Input format: EDCBA\ZHGLCA\left exclude
        string input = Console.ReadLine();
        string[] data = input.Split('\\').ToArray();

        switch (data[2])
        {
            case "join": JoinStrings(data); break;
            case "right exclude": RightExclude(data); break;
            case "left exclude": LeftExclude(data); break;
        }  
    }

    private static void LeftExclude(string[] data)
    {
        string a = data[0];
        string b = data[1];
        char[] c = b.Except(a).ToArray();
        Array.Sort(c);
        Console.WriteLine(string.Join("", c));
    }

    private static void RightExclude(string[] data)
    {
        string a = data[0];
        string b = data[1];
        char[] c = a.Except(b).ToArray();
        Array.Sort(c);
        Console.WriteLine(string.Join("", c));
    }

    private static void JoinStrings(string[] data)
    {
        string a = data[0];
        string temp = a;
        string b = data[1];
        temp = string.Join("", temp.Except(b));
        char[] c = a.Except(temp).ToArray();
        Array.Sort(c);
        Console.WriteLine(string.Join("", c));
    }
}

