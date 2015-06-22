/* Problem 1 – Currency Check
Te4o is a big Battlefield fan. He's been saving money for months to buy the new Battlefield Hardline game. 
 * However, he has five options to buy the game from. The first one is a shady Russian site selling games in rubles (Russian currency). 
 * Another option is an American site selling games in dollars (American currency). 
 * Te4o's third option is the official site of the game - selling games in euros (European Union currency). 
 * The final 2 options are Bulgarian sites B and M. Both of them sell in leva (Bulgarian currency). 
 * B offers a very special deal - 2 copies of the game for the price of one. M sells games for normal prices. 
 * Te4o is very bad with math and can't calculate the game prices in leva. But he wants to impress his girlfriend 
 * by showing her he bought the cheapest game.
Assume that Te4o has a girlfriend, all games are identical, 100 rubles are 3.5 leva, 1 dollar is 1.5 leva, 1 euro is 1.95 leva 
 * and if Te4o buys 2 special games from B he can sell one of them for exactly half of the money he paid for both. 
 * Your task is to write a program that calculates the cheapest game.
Input
The input data should be read from the console. It consists of five input values, each at a separate line:
•	The number r – amount of rubles Te4o has to pay for the game at the Russian site.
•	The number d – amount of dollars Te4o has to pay for the game at the American site.
•	The number e – amount of euro Te4o has to pay for the game at the official site.
•	The number b – amount of leva Te4o has to pay for the special offer at B.
•	The number m – amount of leva Te4o has to pay for the game at M's site.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console. On the only output line you must print the cheapest game price 
 * rounded up (removed "up") to the second digit after the decimal mark.
Constraints
•	The numbers r, d, e, b, m are integer numbers in range [0... 4,294,967,295].
 */

using System;
using System.Linq;

class CurrencyCheck
{
    static void Main()
    {
        decimal r = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        decimal[] prices = new decimal[5];
        prices[0] = r * 0.035m;
        prices[1] = d * 1.5m;
        prices[2] = e * 1.95m;
        prices[3] = b / 2m;
        prices[4] = m;

        decimal cheapestGame = prices.Min();
        Console.WriteLine("{0:F2}", Math.Round(cheapestGame, 2, MidpointRounding.AwayFromZero));
    }
}

