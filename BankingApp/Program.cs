/*
 * Class name: Banking App
 * Version 1
 * Author: Malshi Savidya Mahatenne
 */

// Funcation and methods should be verbs
// With C#, Pascal case should be used with function names
// starting with a capital letter for each word. 
// Function names should not have underscores in their names.

void BuildBankingApp()
{
    // Initialise the variable
    // Note that an amount is not assigned to the variable
    int choice;
    double depositAmount;
    double withdrawAmount;
    double accountBalance = 1000.00;

    //  Display the main screen
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read users choice menu choice
    // Convert the string to an integer
    // use explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    // The || in the loop represents OR
    // which means that a menu choice of 1 OR 2
    // is accepted for this logical operation
    if (choice == 1|| choice == 2)
    {
        // Valid menu choice
        if (choice == 1)
        {
            // Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("=======================");
            Console.WriteLine("1 - Deposit funds");
            Console.WriteLine("2 - Withdraw funds");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Deposit funds
                Console.WriteLine("How much do you want to deposit?");
                Console.WriteLine("Enter amount including pence using a decimal point");

                // Typically a currency value is input as a decimal value
                // so the "double" type is required to store the
                // deposit amount.

                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                // This line of code is interpreted as
                // account balance = account balance + deposit amount
                // This is an example of an assignment operator
                accountBalance += depositAmount;
                Console.WriteLine($"Your new account balance is {accountBalance}");
            }
            if (choice == 2)
            {
                // Withdraw funds
                Console.WriteLine("How much do you want to withdraw?");
                Console.WriteLine("Enter amount including pence using a decimal point");

                withdrawAmount = Convert.ToDouble(Console.ReadLine());

                // check if the withdraw amount is less than the account balance
                if (withdrawAmount < accountBalance)
                {
                    Console.WriteLine($"Your original account balance was {accountBalance}");
                    accountBalance -= withdrawAmount;
                    Console.WriteLine($"Your new account balance is {accountBalance}");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient funds to withdraw this amount");
                    Console.WriteLine($"Your current account balance is {accountBalance}");
                }
            }
            else
            {
                // Invalid menu choice
                Console.WriteLine("Invalid choice, please choose 1 or 2");
            }
        }
        // if (choice == 2)
        else
        {
            // View current account information
            Console.WriteLine("You have chosen to view current account information");
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
        /* 
         * This code was in the tutorial but it is not required.
         * 
         else
        {
             View current account information
            Console.WriteLine("You have chosen to view current account information");
        }
        */  
    }
    else
    {
        // Invalid menu choice
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();