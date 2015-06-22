//Problem 10. Employee Data

/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console. */

using System;
using System.Collections.Generic;
using System.Linq;

public class EmployeeData
{
    #region Generate Unique Employee ID
    // the code below (line 41 to 89 and 99 to 101) generates the unique employee ID
    static Random random = new Random();

    // Note, max is exclusive here!
    public static List<int> GenerateRandom(int count, int min = 27560000, int max = 27569999)
    {
        if (max <= min || count < 0 ||
            // max - min > 0 required to avoid overflow
                (count > max - min && max - min > 0))
        {
            throw new ArgumentOutOfRangeException("Range or count " + count + " is illegal");
        }

        // generate count random values.
        HashSet<int> candidates = new HashSet<int>();

        // start count values before max, and end at max
        for (int top = max - count; top < max; top++)
        {
            // May strike a duplicate.
            // Need to add +1 to make inclusive generator
            // +1 is safe even for MaxVal max value because top < max
            if (!candidates.Add(random.Next(min, top + 1)))
            {
                // collision, add inclusive max.
                // which could not possibly have been added before.
                candidates.Add(top);
            }
        }

        // load them in to a list, to sort
        List<int> result = candidates.ToList();

        // shuffle the results because HashSet has messed
        // with the order, and the algorithm does not produce
        // random-ordered results (e.g. max-1 will never be the first value)
        for (int i = result.Count - 1; i > 0; i--)
        {
            int k = random.Next(i + 1);
            int tmp = result[k];
            result[k] = result[i];
            result[i] = tmp;
        }
        return result;
    }

    public static List<int> GenerateRandom(int count)
    {
        return GenerateRandom(count, 27560000, 27569999);
    }
    #endregion  // the code inside this region generates an unique employee ID number

    public static void Main()
    {
        int age; // will be storing the age
        long IDNumber; // will be storing the personal ID number. 
        int employeeID; // will be storing the Unique Employee ID. 
        string firstName; // will be storing the first name.
        string lastName; // will be storing the last name.
        string ageStr; // temporary string for age input. We`ll use it to check if the input is a number
        string gender; // temporary string for gender. We`ll use it to check if the input is indeed F or M
        string IdNumberStr; // temporary string for ID number. We`ll use it to check if the input is a number
        string employeeIDStr; // temporary string for Employee ID number. 

        List<int> randomId = GenerateRandom(1); // generates one random number per employee
        employeeIDStr = string.Join(", ", randomId.ToArray()); // the list of one elements is convered to string
        employeeID = Convert.ToInt32(employeeIDStr); // converts the above string to an int newEmployee.employeeId

        Console.Write("New Employee Form: \n\nFirst Name:\t\t");;  
        firstName = Console.ReadLine();
        Console.Write("Last Name:\t\t"); 
        lastName = Console.ReadLine(); 

        // validating age input
        do    
        {
            Console.Write("Age:\t\t\t");  
            ageStr = Console.ReadLine();  
        }
        while ((!int.TryParse(ageStr, out age) || age <= 0 || age >= 150));  

        // validating gender input
        do  
        {
            Console.Write("Gender: F/M?\t\t");
            gender = Console.ReadLine();  
        } while (!gender.Equals("f", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("female", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("m", StringComparison.OrdinalIgnoreCase) 
            && !gender.Equals("Male", StringComparison.OrdinalIgnoreCase));

        // if Female
        if (gender.Equals("f", StringComparison.OrdinalIgnoreCase) 
            || gender.Equals("female", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Female";
        }

        // if Male
        else if (gender.Equals("m", StringComparison.OrdinalIgnoreCase) 
            || gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            gender = "Male";
        }

        bool personalId = false;
        // validates the personal ID number input
        do 
        {
            Console.Write("Personal ID Number:\t");
            IdNumberStr = Console.ReadLine();
            personalId = long.TryParse(IdNumberStr, out IDNumber);
        } while (!personalId || IdNumberStr.Length < 10 || IdNumberStr.Length > 10);

        Console.Clear(); //clears the console of any previous text
        Console.WriteLine("Employee ID: {0} \nName: {1} {2} \nAge: {3} \nGender: {4} \nPersonal ID Number: {5}",
                employeeID, firstName, lastName, age, gender, IDNumber);
    }
}