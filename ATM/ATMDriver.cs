using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectATM
{
    class ATMDriver
    {
        static void Main(string[] args)
        {
            // The following Constructor gets customer name and his/her initial balance.
            var customer1Checking = new CheckingAccount("Emre Dursun", 1000);
            var customer1Saving = new SavingsAccount(500);

        //Console.WriteLine($"\nThe account with the number {customer1.Number} was created for {customer1.Owner} with the initial balance of EURO {customer1.CheckingBalance}.");

        BACKTOTOP:
            // Ask the user whether to add or eat withdraw the money and also capture wrong inputs
            string userActionChoice;
            string Greetings;
            do
            {
                var time = DateTime.Now.Hour;
                if (time < 6) Greetings = "Good night";
                else if (time >= 6 && time < 12) Greetings = "Goodmorning"; 
                else if (time >= 12 && time <= 19) Greetings = "Good afternoon";
                else Greetings = "Good evening";
                Console.Clear();
                Console.WriteLine(" -------------------------------------------------- ");
                Console.WriteLine($"| {Greetings}, Welcome to SuperBank Secure Menu |");
                Console.WriteLine("|                                                  |");
                Console.WriteLine("| 1. Check balance                                 |");
                Console.WriteLine("| 2. Deposit                                       |");
                Console.WriteLine("| 3. Withdraw                                      |");
                Console.WriteLine("| 4. Transfer                                      |");
                Console.WriteLine("| 5. Transactions                                  |");
                Console.WriteLine("| 6. Quit                                          |");
                Console.WriteLine("|                                                  |");
                Console.WriteLine(" -------------------------------------------------- ");
                Console.Write("Enter your option: ");
                userActionChoice = Console.ReadLine().ToUpper();
            }
            while 
            (
                !userActionChoice.Equals("1") && 
                !userActionChoice.Equals("2") && 
                !userActionChoice.Equals("3") &&
                !userActionChoice.Equals("4") &&
                !userActionChoice.Equals("5") &&
                !userActionChoice.Equals("6")
            );


            // If user action choice is 'Check Balance'
            if (userActionChoice.Equals("1"))
            {
                Console.Clear();
                Console.WriteLine($"\nThe current balance in your 'Checking Account' is now {customer1Checking.CheckingBalance} Euro.");
                Console.WriteLine($"\nThe current balance in your 'Savings Account' is now {customer1Saving.SavingBalance} Euro.");

            TRYAGAIN:
                Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {
                    Console.Clear();
                    goto BACKTOTOP;
                }
                else if (userChoice == "N")
                {
                    Console.WriteLine("\nThank you for your business. Goodbye!");
                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid value! Please try again.");
                    goto TRYAGAIN;
                }
            }


            // If user action choice is 'Make Deposit'
            if (userActionChoice.Equals("2"))
            {
                Console.Clear();
                string userAccountChoice;
                do
                {
                    Console.Clear();
                    Console.WriteLine(" -------------------------- ");
                    Console.WriteLine("|     Deposit Menu         |");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("| 1. To Checking Account   |");
                    Console.WriteLine("| 2. To Savings  Account   |");
                    Console.WriteLine("| 3. Quit                  |");
                    Console.WriteLine("|                          |");
                    Console.WriteLine(" -------------------------- ");
                    Console.Write("Enter your option: ");
                    userAccountChoice = Console.ReadLine().ToUpper();
                } while (!(userAccountChoice.Equals("1")) && !(userAccountChoice.Equals("2")) && !(userAccountChoice.Equals("3")));

                // If user choose the Checking Account
                if (userAccountChoice.Equals("1")) 
                {
                    // Ask user about the amount of money
                    Console.Clear();
                    Console.Write("\nHow much would you like to deposit? ");
                    decimal depositAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out depositAmount)))
                    {
                        Console.Write(
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nPlease fill in an amount that is larger than EURO 0,-: ");
                    }
                    try
                    {
                        customer1Checking.MakeDeposit(depositAmount, DateTime.Now, "New deposit");
                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine($"\nThe current balance in your 'Checking Account' is now {customer1Checking.CheckingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                // If user choose the Savings Account
                if (userAccountChoice.Equals("2"))
                {
                    // Ask user about the amount of money
                    Console.Clear();
                    Console.Write("\nHow much would you like to deposit? ");
                    decimal depositAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out depositAmount)))
                    {
                        Console.Write(
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nPlease fill in an amount that is larger than EURO 0,-: ");
                    }
                    try
                    {
                        customer1Saving.MakeDeposit(depositAmount, DateTime.Now, "New deposit");
                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine($"\nThe current balance in your 'Savings Account' is now {customer1Saving.SavingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                if (userAccountChoice.Equals("3"))
                {
                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }
            }


            // If user action choice is 'Make Withdraw'
            if (userActionChoice.Equals("3"))
            {
                Console.Clear();
                string userAccountChoice;
                do
                {
                    Console.Clear();
                    Console.WriteLine(" -------------------------- ");
                    Console.WriteLine("|     Withdraw Menu        |");
                    Console.WriteLine("|                          |");
                    Console.WriteLine("| 1. From Checking Account |");
                    Console.WriteLine("| 2. From Savings  Account |");
                    Console.WriteLine("| 3. Quit                  |");
                    Console.WriteLine("|                          |");
                    Console.WriteLine(" -------------------------- ");
                    Console.Write("Enter your option: ");
                    userAccountChoice = Console.ReadLine().ToUpper();
                } while (!(userAccountChoice.Equals("1")) && !(userAccountChoice.Equals("2")) && !(userAccountChoice.Equals("3")));

                // If user choose Checking Account
                if (userAccountChoice.Equals("1"))
                {
                    Console.Clear();
                    Console.Write("\nHow much would you like to withdraw? ");
                    decimal withdrawelAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out withdrawelAmount)))
                    {
                        Console.Write(
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\nPlease fill in an amount that is larger than EURO 0,-: ");
                    }

                    try
                    {
                        customer1Checking.MakeWithdraw(withdrawelAmount, DateTime.Now, "New withdrawel");

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine($"\nThe current balance in your 'Checking Account' is now {customer1Checking.CheckingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                // If user chooses Saving Account
                if (userAccountChoice.Equals("2"))
                {
                    Console.Clear();
                    Console.Write("\nHow much would you like to withdraw? ");
                    decimal withdrawelAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out withdrawelAmount)))
                    {
                        Console.Write(
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\nPlease fill in an amount that is larger than EURO 0,-: ");
                    }

                    try
                    {
                        customer1Saving.MakeWithdraw(withdrawelAmount, DateTime.Now, "New withdrawel");

                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine($"\nThe current balance in your 'Savings Account' is now {customer1Saving.SavingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                // If user chooses the Quit option
                if (userAccountChoice.Equals("3"))
                {
                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }
            }

            // If user action choice is 'Transfer'
            if (userActionChoice.Equals("4"))
            {
                Console.Clear();
                string userTransferChoice;
                do
                {
                    Console.WriteLine(" -------------------------------- ");
                    Console.WriteLine("|         Transfer Menu          |");
                    Console.WriteLine("|                                |");
                    Console.WriteLine("| 1. From Checking to Savings    |");
                    Console.WriteLine("| 2. From Savings to Checking    |");
                    Console.WriteLine("| 3. Quit                        |");
                    Console.WriteLine("|                                |");
                    Console.WriteLine(" -------------------------------- ");
                    Console.Write("Enter your option: ");
                    userTransferChoice = Console.ReadLine().ToUpper();
                } while (!(userTransferChoice.Equals("1")) && !(userTransferChoice.Equals("2")) && !(userTransferChoice.Equals("3")));

                // If user chooses From Checking to Savings
                if (userTransferChoice.Equals("1"))
                {
                    Console.Clear();
                    Console.Write("\nAmount to transfer? ");
                    decimal transferAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out transferAmount)))
                    {
                        Console.Clear();
                        Console.Write(
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nPlease re-enter the transfer amount: ");
                    }
                    try
                    {
                        customer1Checking.MakeWithdraw(transferAmount, DateTime.Now, "Transfer (To Saving Account)");
                        customer1Saving.MakeDeposit(transferAmount, DateTime.Now, "Transfer (From Checking Account)");
                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.Clear();
                        Console.WriteLine(
                            $"\nYour Checking Account has {customer1Checking.CheckingBalance} Euro." +
                            $"\nYour savings account has {customer1Saving.SavingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                // If user choose From Savings to Checking 
                if (userTransferChoice.Equals("2"))
                {
                    Console.Clear();
                    Console.Write("\nAmount to transfer? ");
                    decimal transferAmount;
                    while (!(decimal.TryParse(Console.ReadLine(), out transferAmount)))
                    {
                        Console.Write(
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nThis is the wrong input. You can't use other characters than numbers." +
                            "\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                            "\nPlease re-enter the transfer amount: ");
                    }
                    try
                    {
                        customer1Saving.MakeWithdraw(transferAmount, DateTime.Now, "Transfer (To Checking Account)");
                        customer1Checking.MakeDeposit(transferAmount, DateTime.Now, "Transfer (From Saving Account)");
                    }
                    catch (ArgumentException argEx)
                    {
                        Console.WriteLine("\nOOPS! Something went wrong!");
                        Console.WriteLine(argEx.Message);
                    }
                    finally
                    {
                        Console.WriteLine(
                            $"\nYour checking account has {customer1Checking.CheckingBalance} Euro." +
                            $"\nYour savings account has {customer1Saving.SavingBalance} Euro.");
                    }

                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

                if (userTransferChoice.Equals("3"))
                {
                TRYAGAIN:
                    Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                    string userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "Y")
                    {
                        Console.Clear();
                        goto BACKTOTOP;
                    }
                    else if (userChoice == "N")
                    {
                        Console.WriteLine("\nThank you for your business. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou entered an invalid value! Please try again.");
                        goto TRYAGAIN;
                    }
                }

            }


            // If user action choice is 'History of Transactions'
            if (userActionChoice.Equals("5"))
            {
                Console.Clear();
                Console.WriteLine($"\nYou can see all you account transactions below.\n");
                Console.WriteLine(customer1Checking.GetTransactions());
                Console.WriteLine(customer1Saving.GetTransactions());
                Console.WriteLine($"The current balance in your Checking Account for accountnumber {customer1Checking.Number} is EURO {customer1Checking.CheckingBalance}.");
                Console.WriteLine($"The current balance in your Savings Account for accountnumber {customer1Checking.Number} is EURO {customer1Saving.SavingBalance}.");

            TRYAGAIN:
                Console.Write("\n\tWould you like to do any further action on your account? Please enter (Y)es or (N)o : ");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {
                    Console.Clear();
                    goto BACKTOTOP;
                }
                else if (userChoice == "N")
                {
                    Console.WriteLine("\nThank you for your business. Goodbye!");
                }
                else
                {
                    Console.WriteLine("\nYou entered an invalid value! Please try again.");
                    goto TRYAGAIN;
                }
            }



            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
    }
}
