/* Problem 1 – Fruit Market
The local fruit market offers fruits and vegetables with the following standard price list:
•	banana  1.80
•	cucumber  2.75
•	tomato  3.20
•	orange  1.60
•	apple  0.86	The market owner decided to introduce the following discounts:
•	Friday  10% off for all products
•	Sunday  5% off for all products
•	Tuesday  20% off for fruits
•	Wednesday  10% off for vegetables
•	Thursday  30% off for bananas
Write a program that helps the fruit market owner to calculate the total price for orders that consist of day, 3 products with quantities.
Input
The input data should be read from the console. The input data consists of exactly 7 lines:
•	At the first line you will be given the day of week. 
•	At the next 6 lines you will be given: quantity1, product1, quantity2, product2, quantity3, product3.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
You have to print at the console the total price for the specified 3 products at the specified day of week.
Constraints
•	The day of week is one of the values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday. 
•	The product quantities (quantity1, quantity2, quantity3) will be a number in the range [1…100], with up to 2 digits after the decimal point. 
 * The will be used "." as decimal separator.
•	The products names (product1, product2, product3) is one of the values: banana, cucumber, tomato, orange, and apple.
•	The total price should be rounded to exactly 2 digits after the decimal point (use "." as decimal separator).
  */

using System;
using System.Collections.Generic;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        double totalPrice = 0;
        //Dictionary<double, string> orders = new Dictionary<double, string>();
        for (int i = 0; i < 3; i++)
        {
            double quantity = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            
            if (dayOfWeek == "Friday" || dayOfWeek == "Sunday")
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Tuesday" && (product == "banana" || product == "apple" || product == "orange"))
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Wednesday" && (product == "tomato" || product == "cucumber"))
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else if (dayOfWeek == "Thursday" && product == "banana")
            {
                totalPrice += quantity * PriceList(product) * Discounts(dayOfWeek);
            }
            else
            {
                totalPrice += quantity * PriceList(product);
            }

        }
        Console.WriteLine("{0, 0:F2}", totalPrice);
    }

    public static double Discounts(string dayOfWeek)
    {
        Dictionary<string, double> discounts = new Dictionary<string, double>()
        {
            {"Friday", 0.9},
            {"Sunday", 0.95},
            {"Tuesday", 0.8},
            {"Wednesday", 0.9},
            {"Thursday", 0.7}
        };

        return discounts[dayOfWeek];
    }

    public static double PriceList(string product)
    {
        Dictionary<string, double> priceList = new Dictionary<string, double>()
        {
            {"banana", 1.80},
            {"cucumber", 2.75},
            {"tomato", 3.20},
            {"orange", 1.60},
            {"apple", 0.86}
        };

        return priceList[product];
    }

}

