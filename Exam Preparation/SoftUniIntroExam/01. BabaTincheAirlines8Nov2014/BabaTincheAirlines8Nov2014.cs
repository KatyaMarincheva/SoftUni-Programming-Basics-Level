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

