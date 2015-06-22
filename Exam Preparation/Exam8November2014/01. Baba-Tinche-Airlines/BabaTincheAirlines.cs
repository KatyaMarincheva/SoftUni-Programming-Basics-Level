/* Problem 1 – Baba Tinche Airlines
Every month Baba Tinche travels to the Republic of Tajikistan to meet her boyfriend. 
 * But the tickets are so expensive that she decides to establish her own airline instead called Baba Tinche Airlines. 
 * There are three travel classes in Baba Tinche Airlines:
•	First Class which accommodates 12 passengers. The ticket price is $7000.
•	Business Class which accommodates 28 passengers. The ticket price is $3500.
•	Economy Class which accommodates 50 passengers. The ticket price is $1000.
Please note that some passengers are Frequent Flyers and their tickets are 70% off ($1000 ticket will cost $300). 
 * Also some passengers purchase a meal on the flight, which costs 0.5% of the ticket price for the travel class they are in. 
 * Please help Baba Tinche calculate her income and calculate the difference between her income and the maximum possible income 
 * (the maximum possible income being all seats taken, no Frequent Flyers and everyone purchasing meals). 
 * You will be given the number of passengers for each class, the number of passengers who are Frequent Flyers in that class, 
 * and the number of passengers who purchase a meal in that class.
Input
The input data should be read from the console. It consists of exactly 3 lines:
•	The first line holds the number of all passengers in First Class
•	The second line holds the number of all passengers in Business Class
•	The third line holds the number of all passengers in Economy Class
•	The second and third number on all lines will be the number of Frequent Flyers and the number of passengers 
 * who will purchase a meal in the given class.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 2 lines.
•	The first line will  hold Baba Tinche’s income cast to an integer
•	The second line holding the difference between the maximum possible profit and baba Tinche’s actual profit cast to an integer
Constraints
•	The first number in the first line will be in the range [0…12]. 
•	The first number in the second line will be in the range [0…28]. 
•	The first number in the third line will be in the range [0…50]. 
•	The second and third numbers on all lines will be less or equal to the first number.
 */

using System;
using System.Linq;

class BabaTincheAirlines
{
    // constant values
    const int fCPassenger = 12;
    const int fCTicket = 7000;

    const int bCPassenger = 28;
    const int bCTicket = 3500;

    const int eCPassenger = 50;
    const int eCTicket = 1000;

    static void Main()
    {
        // 233160 
        int maxIncome = (int)(fCPassenger * fCTicket + fCPassenger * (fCTicket * 0.005)) + (int)(bCPassenger * bCTicket + bCPassenger * (bCTicket * 0.005)) + (int)(eCPassenger * eCTicket + eCPassenger * (eCTicket * 0.005));

        // input
        string first = Console.ReadLine();
        string business = Console.ReadLine();
        string economy = Console.ReadLine();

        // calculate and print actual profit
        int actualProfit = FirstClProfit(first) + BusinessClProfit(business) + EconomyClProfit(economy);
        Console.WriteLine(actualProfit);

        // print difference between maximal and actual profit
        Console.WriteLine(maxIncome - actualProfit);
    }

    static int FirstClProfit(string first)
    {
        // splitting the input string into a number arrray
        int[] firstClass = first.Split(' ').Select(int.Parse).ToArray();

        // using the const values above and the input arra values in this actual profit formula for first class
        int profit = (firstClass[0] - firstClass[1]) * fCTicket + (int)(firstClass[1] * (fCTicket * 0.3)) + (int)(firstClass[2] * (fCTicket * 0.005));

        return profit;
    }

    static int BusinessClProfit(string business)
    {
        // splitting the input string into a number arrray
        int[] businessClass = business.Split(' ').Select(int.Parse).ToArray();

        // using the const values above and the input arra values in this actual profit formula for business class
        int profit = (businessClass[0] - businessClass[1]) * bCTicket + (int)(businessClass[1] * (bCTicket * 0.3)) + (int)(businessClass[2] * (bCTicket * 0.005));

        return profit;
    }

    static int EconomyClProfit(string economy)
    {
        // splitting the input string into a number arrray
        int[] economyClass = economy.Split(' ').Select(int.Parse).ToArray();

        // using the const values above and the input arra values in this actual profit formula for economy class
        int profit = (economyClass[0] - economyClass[1]) * eCTicket + (int)(economyClass[1] * (eCTicket * 0.3)) + (int)(economyClass[2] * (eCTicket * 0.005));

        return profit;
    }
}
