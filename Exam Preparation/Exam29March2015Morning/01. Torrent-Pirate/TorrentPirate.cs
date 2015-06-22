/* Problem 1 – Torrent Pirate
Captain Jack Sparrow is a famous pirate. He loves to steal different stuff just for fun and he loves watching movies. 
 * He recently discovered a brand new technology called peer-to-peer or torrent. After he browsed a famous site, 
 * he made a collection of movies he would like to download. Assume 1 movie has a size of 1500MB. 
 * Jack doesn’t want to pay for the internet, so he decided to go to the mall and use the free Wi-Fi there. 
 * The Wi-Fi has a fixed speed of 2MB/s. Unfortunately for Jack, 
 * his wife will be going with him to the mall and this means that the download would not be free at all. 
 * She likes to buy sandals and other useless stuff. You are given the money his wife spends per hour at the mall.
Your task is to help Jack calculate whether it is cheaper to go to the mall and download the movies 
 * or go to the cinema to watch them. If the amount is the same, Jack still wants to make his wife happy, so he goes to the mall.
Input
The input data should be read from the console. It consists of three input values, each at a separate line:
•	Download data d: how much megabytes in total Jack should download.
•	Price of cinema p: how much money would cost Jack to go to the cinema to watch one movie.
•	Wife spending	 w: how much money per hour does Jack’s wife spend.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print “{place to go} -> {price to pay}lv”.
•	The price to pay should be formatted with 2 digits after the decimal sign.
Constraints
•	d is an integer number in range [0...2,147,483,647]. p is an integer number in range [0…30]. w is an integer number in range [0…200].
 */

using System;

class TorrentPirate
{
    static void Main()
    {
        decimal d = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal w = decimal.Parse(Console.ReadLine());

        decimal numberOfMovies = d / 1500;
        decimal hoursInMall = d / 7200;

        decimal cinemaCosts = numberOfMovies * p;
        decimal mallCosts = hoursInMall * w;

        if (cinemaCosts < mallCosts)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaCosts);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", mallCosts);
        }
    }
}

