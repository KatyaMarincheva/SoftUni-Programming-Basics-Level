// Problem 5. Boolean Variable

// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
// Print it on the console.

using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = true;

        // condition ? if true: message 1 : else: message 2
        Console.WriteLine(isFemale ? "My gender is female." : "My gender is male.");

    }
}
