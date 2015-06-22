// Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class BankAccountData // the class which will be further used to create bank account objects
{
    // these are the properties of the bank account object
    public string HolderName = "Dimitrina Nikolova Yaneva";
    public string BankName = "Bulgarian National Bank";
    public string IBAN = "BG80 BNBG 9661 1020 3456 78";

    public long CreditCardNumber1 = 4000001234567891;
    public decimal CCBalance1 = 2564.48m;
    public long CreditCardNumber2 = 4000001234567781;
    public decimal CCBalance2 = 10000.28m;
    public long CreditCardNumber3 = 4000001234567561;
    public decimal CCBalance3 = 24.01m;

    public decimal salary;

    public void PrintBankAccountData()  //this method can be called on a bank account object, and prints this object's bank account data
    {
        Console.WriteLine("This program will access your fictional Bank Account. \nPlease enter your first middle and last name, \nso that you can retrieve your Bank Account Data:\n");
        HolderName = Console.ReadLine();
        Console.WriteLine("\nBank Account Holder Name: {0} \nBank Name: {1} \nIBAN: {2} \nCredit Card №: 1: {3} \nCredit Card №: 2: {4} \nCredit Card №: 3: {5}",
            HolderName, BankName, IBAN, CreditCardNumber1, CreditCardNumber2, CreditCardNumber3);
    }

    public void PrintCCOneBalance() // can be called on a bank account object, prints Credit Card №: 1 properties
    {
        Console.WriteLine("Credit Card №: {0} \nCredit Card Balance: {1}", CreditCardNumber1, CCBalance1);
    }

    public void PrintCCTwoBalance() // can be called on a bank account object, prints Credit Card №: 2 properties
    {
        Console.WriteLine("Credit Card №: {0} \nCredit Card Balance: {1}", CreditCardNumber2, CCBalance2);
    }

    public void PrintCCThreeBalance() // can be called on a bank account object, prints Credit Card №: 3 properties
    {
        Console.WriteLine("Credit Card №: {0} \nCredit Card Balance: {1}", CreditCardNumber3, CCBalance3);
    }

    public void PrintTotalBalance() // can be called on a bank account object, prints this bank account's balance
    {
        Console.WriteLine("Total Balance: {0}", (CCBalance1 + CCBalance2 + CCBalance3));
    }

    public void GetSalary() // this method is for you specifically, so that you can choose your software developper salary :)
    {
        Console.WriteLine("Please choose a software developper salary for yourself and enter the number below :) \n");
        salary = decimal.Parse(Console.ReadLine());
    }

    public void Debit() // adds your salary to your Credit Card №: 2, and prints the final balance
    {
        CCBalance2 += salary;
        Console.WriteLine("\nCredit Card №: 2: {0} \nSalary: {1} \nFinal Balance: {2}", CreditCardNumber2, salary, CCBalance2);
    }
}
class AccountHolders
{

    static void Main()
    {
        BankAccountData accountHolder = new BankAccountData();  // creates an account holder object

        // call all methids below on the account holder object
        accountHolder.PrintBankAccountData();
        Console.WriteLine();
        accountHolder.PrintCCOneBalance();
        Console.WriteLine();
        accountHolder.PrintCCTwoBalance();
        Console.WriteLine();
        accountHolder.PrintCCThreeBalance();
        Console.WriteLine();
        accountHolder.PrintTotalBalance();

        // calling the methods below:
        accountHolder.GetSalary();

        accountHolder.Debit();

        accountHolder.PrintTotalBalance();

        Console.WriteLine("\nThank you for testing my program!");
        Console.CursorVisible = false;
        Console.ReadLine();
    }
}


