using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        static List <string> customerNames = new List <string>();
        static List <string> accountNumbers = new List <string>();
        static List <double> balances = new List <double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close Account");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddAccount();
                            break;

                        case 2:
                            DepositMoney();
                            break;

                        case 3:
                            WithdrawMoney();
                            break;

                        case 4:
                            ShowBalance();
                            break;

                        case 5:
                            TransferAmount();
                            break;

                        case 6:
                            ListAllAccounts();
                            break;

                        case 7:
                            CloseAccount();
                            break;

                        case 8:
                            exitApp = true;
                            Console.WriteLine("Thank you for banking with Spark Bank.");
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter numbers only.");
                }
            }
        }

        static void AddAccount() { }

        static void DepositMoney() { }

        static void WithdrawMoney() { }

        static void ShowBalance() { }

        static void TransferAmount() { }

        static void ListAllAccounts() { }

        static void CloseAccount() { }
    }
}
