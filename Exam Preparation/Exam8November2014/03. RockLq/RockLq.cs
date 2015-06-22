/* Problem 3 – RockLq
You will be given an integer N. The width of the rocklq is (3*N). The height of the rocklq is (2*N). 
 * Check the examples below to understand your task better.
Input
Input data is read from the console.
•	The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a picture of size N following the formulas above and the examples below.
Constraints
•	N will be a number between 5 and 31 and will be an odd number.
•	Time limit: 0.25 seconds. Allowed memory: 16 MB.
Examples
Input	Output		Input	Output		Input	Output
5	
.....*****.....
...*.......*...
.*...........*.
*...*.....*...*
*.*.*.....*.*.*
....*.....*....
...*.......*...
..*.........*..
.*...........*.
***************	
 7
.......*******.......
.....*.........*.....
...*.............*...
.*.................*.
*.....*.......*.....*
*...*.*.......*.*...*
*.*...*.......*...*.*
......*.......*......
.....*.........*.....
....*...........*....
...*.............*...
..*...............*..
.*.................*.
*********************	
9
.........*********.........
.......*...........*.......
.....*...............*.....
...*...................*...
.*.......................*.
*.......*.........*.......*
*.....*.*.........*.*.....*
*...*...*.........*...*...*
*.*.....*.........*.....*.*
........*.........*........
.......*...........*.......
......*.............*......
.....*...............*.....
....*.................*....
...*...................*...
..*.....................*..
.*.......................*.
***************************
 */

using System;

class RockLq
{
    static void Main() 
    {
        // input
        int N = int.Parse(Console.ReadLine());

        // counts
        int collar_waistCount = N;
        int sidesCount = N;
        int skirtWidth = 3 * N;
        int sleeveCounts = N / 2;
        int skirtLength = N - 1;
        int midCount = N + 2;
        int armpitCount = 1;
        int sleeveWidth = N - 2;

        // strings
        string collar = new string('*', collar_waistCount);
        string side = new string('.', sidesCount);
        string middle = new string('.', midCount);
        string armpit = new string('.', armpitCount);
        string skirtBorder = new string('*', skirtWidth);
        string sleeve = new string('.', sleeveWidth);
        string waist = new string('.', collar_waistCount);

        // printing
        Console.WriteLine("{0}{1}{0}", side, collar); 

        for (int i = 0; i < N/2; i++) 
        {
            sidesCount -= 2;
            side = new string('.', sidesCount);
            middle = new string('.', midCount);
            Console.WriteLine("{0}*{1}*{0}", side, middle);
            midCount += 4;
        }

        Console.WriteLine("*{0}*{1}*{0}*", sleeve, waist); 
       
        for (int j = 0; j < N/2 - 1; j++) 
        {
            sleeveWidth -= 2;
            sleeve = new string('.', sleeveWidth);
            armpit = new string('.', armpitCount);
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", sleeve, armpit, waist);
            armpitCount += 2;
        }

        sidesCount = N - 1;
        midCount = N;
        for (int k = 0; k < N - 1; k++) 
        {
            side = new string('.', sidesCount);
            middle = new string('.', midCount);
            Console.WriteLine("{0}*{1}*{0}", side, middle);
            sidesCount--;
            midCount += 2;          
        }

        Console.WriteLine(skirtBorder); 
    }
}

