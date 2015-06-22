/*  Problem 13.	* – Work Hours
This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
Lelia Vanche is a very keen freelance developer. She is well known for her outstanding skills, but she is 
 * also known for being pretty moody, which often affects her productivity. She also has a passion for bicycles 
 * and 10% of the normal work days she goes mountain-biking instead of working.
You are asked to calculate whether Lelia Vanche can finish a project on time. 
 * You will be given the number of hours required to finish the project, 
 * the days that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) 
 * and her average productivity during the given period. Assume that a normal work day for Lelia Vanche has 12 hours. 
 * Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).
Input
Input data should be read from the console. 
•	The number h (the required work hours to finish the project) is on the first input line.
•	The number d (the days available to finish the project) is on the second input line.
•	The number p (the productivity in percent) is on the third input line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
•	On the first output line you should print ‘Yes’ or ‘No’ if Lelya Vanche can complete the project.
•	On the second output line you should print the difference, between the project hours and the work hours.
 */

using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        // days available = d
        // days remainings after 10% biking = d - d/10
        // work hours per day = 12
        // total work hours = (d - d/10) * 12
        // after p% productivity: total productive work hours = ((d - d/10) * 12) * p/100
        // hours necessary = h
        double workhours = ((d - d / 10) * 12) * p / 100;
        int difference = (int)workhours - h;

        if (difference >= 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(difference);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(difference);
        }
    }
}


