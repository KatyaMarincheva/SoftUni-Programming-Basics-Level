using System;

class DeckOf52Cards
{
    static void Main()
    {
        // declarations
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';

        // draw the columns
        for (int i = 2; i <= 14; i++)
        {
            // new line after each column is complete, and start new column
            Console.WriteLine();

            // append row values to columns
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write("{0,2}", 2);
                        break;
                    case 3: Console.Write("{0,2}", 3);
                        break;
                    case 4: Console.Write("{0,2}", 4);
                        break;
                    case 5: Console.Write("{0,2}", 5);
                        break;
                    case 6: Console.Write("{0,2}", 6);
                        break;
                    case 7: Console.Write("{0,2}", 7);
                        break;
                    case 8: Console.Write("{0,2}", 8);
                        break;
                    case 9: Console.Write("{0,2}", 9);
                        break;
                    case 10: Console.Write("{0,2}", 10);
                        break;
                    case 11: Console.Write("{0,2}", "J");
                        break;
                    case 12: Console.Write("{0,2}", "Q");
                        break;
                    case 13: Console.Write("{0,2}", "K");
                        break;
                    case 14: Console.Write("{0,2}", "A");
                        break;
                    default: Console.WriteLine("Error !");
                        break;
                }

                switch (j)
                {
                    case 1: Console.Write("{0} ", spades);
                        break;
                    case 2: Console.Write("{0} ", hearts); 
                        break;
                    case 3: Console.Write("{0} ", diamonds);
                        break;
                    case 4: Console.Write("{0} ", clubs);
                        break;
                    default: Console.WriteLine("Error !");
                        break;
                }
            }
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

