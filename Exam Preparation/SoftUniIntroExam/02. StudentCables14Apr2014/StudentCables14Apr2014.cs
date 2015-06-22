/* Problem 2 – Student Cables
Once at the Software University (SoftUni) we had problems with the Wi-Fi network. It was working well in the previous days 
 * even with a few hundred students browsing Internet in the same time, but at the exam all the students came with their laptop 
 * at fixed time and tried to establish a wireless connection simultaneously. This flooded the Wi-Fi access points and 
 * as a result some of the students were unable to get an IP address from the DHCP server. They of course established 
 * a Wi-Fi Internet connection after a few reconnects in next 5-10 minutes, but were highly stressed because 
 * they didn't had Internet immediately before the start the exam start.
Nakov, the main driver of SoftUni, decided to solve the problem by connecting some of the students through a standard network cables. 
 * He installed a few network switches in the exam lab and started to prepare cables for the students. His idea was to use 5 meters long cables 
 * (called student cables) between the switches and the student's laptops. Nakov wanted to create as much as possible cables of size 5 meters. 
 * He had a lot of cables of different sizes, e.g. a big roll of 300 meters, another big roll of 130 meters and a few small cables of 30 cm, 15 cm and 10 cm. 
 * The cables had different sizes and was measured in different measures (meters or centimeters). Nakov calculated that he needed 
 * 2 cm for crimping each RJ45 connector and 3 cm for joining each two pieces of cable. It was complex to calculate how much cables 
 * Nakov can create so he needs your help.
Write a program that takes as an input a sequence of N cables of different sizes and calculates how many student cables 
 * Nakov can create by first joining them all together, then cut them into 5 meters and 4 cm, and finally crimp the RJ45 connectors 
 * to obtain 5 meters long student network cables. Calculate also the length of the unused remaining cable. 
 * Note that cables shorter than 20 cm in the input will be thrown away, so please discard therm.
Input
The input data should be read from the console.
•	At the first line an integer number n specifying the number of cables will be given.
•	At the next 2 * n lines the cables will be given: first comes the cable length; second comes the measure.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of exactly 2 lines:
•	The first line should hold the number of student cables.
•	The second line should hold the length of the remaining cable.
 */

using System;

class StudentCables14Apr2014
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        int totalLength = 0;
        int joints = 0;
        for (int i = 0; i < n; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();

            if (measure == "meters")
            {
                length *= 100;
            }

            if (length >= 20)
            {                
                totalLength += length;
                joints++;
            }          
        }

        int lengthForJoints = 3 * (joints - 1);
        int usableLength = totalLength - lengthForJoints;
        int singleCable = 504;

        //int studentCables = usableLength / singleCable;
        int remainingCable;
        int studentCables = Math.DivRem(usableLength, singleCable, out remainingCable);

        Console.WriteLine(studentCables);
        Console.WriteLine(remainingCable);
    }
}

