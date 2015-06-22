// Problem 17.	** Sunglasses
/* Do you know that the next solar eclipse will occur on April 29, 2014? It will be observable from South Asia, Australia, the Pacific and the Indian Oceans and Antarctica. Spiro is an entrepreneur who wants to cash in on this natural phenomenon. Help him produce protective sunglasses of different sizes. You will get 5% of the profit.
Input
•	The input data should be read from the console.
•	You have an integer number N (always an odd number) specifying the height of sunglasses.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
You should print the sunglasses on the console. The sunglasses consist of three parts: frames, lenses and a bridge (the connection between the two frames). Each frame's width is double the height N and should be printed using the character '*' (asterisk). Print the lenses with the character '/'. Finally, connect the two frames with a bridge that is of size N, using the character '|'. Leave the rest of the space between the frames blank.
 */

using System;

class Sunglasses
{
    static void Main()
    {
        // input
        int N = int.Parse(Console.ReadLine());

        // logic
        string upFrames = new String('*', 2 * N);
        string betweenFrames = new String(' ', N);
        string bridge = new String('|', N);
        string lenses = new String('/', (2 * N) - 2);

        // printing
        Console.WriteLine("{0}{1}{0}", upFrames, betweenFrames);
        for (int i = 0; i < (N / 2) - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", lenses, betweenFrames);
        }
        Console.WriteLine("*{0}*{1}*{0}*", lenses, bridge);
        for (int i = 0; i < (N / 2) - 1; i++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", lenses, betweenFrames);
        }
        Console.WriteLine("{0}{1}{0}", upFrames, betweenFrames);
    }
}




