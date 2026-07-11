using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

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

        static void AddAccount() 
        {
            Console.Write("Enter Your Full Name: ");
            string customerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                Console.WriteLine("Customer Name Cannot be Empty.");
                return;
            }

            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine("Account Number Cannot be Empty.");
                return;
            }

            if (accountNumbers.Contains(accountNumber)) 
            {
                Console.WriteLine("Account Number Already Exists.");
                return;
            }
            double initialBalance = 0;
            try 
            {
                Console.Write("Enter Initial Balance: ");
                initialBalance = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Numbers Only.");
                return;
            }


            if (initialBalance < 0) 
            {
                Console.WriteLine("The Initial Balance Must Not be Negative");
                return;
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(initialBalance);

            Console.WriteLine("\nAccount Created Successfully!");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + initialBalance);
        }

        static void DepositMoney() 
        {
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("The Account does not Exist.");
                return;
            }

            double depositAmount = 0;

            try
            {
                Console.Write("Enter Deposit Amount: ");
                depositAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please Enter Numbers Only.");
                return;
            }

            if (depositAmount <= 0) 
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balances[index] += depositAmount;

            Console.WriteLine($"Deposit successful!\nUpdated Balance: {balances[index]:F2}");
        }

        static void WithdrawMoney() 
        {
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("The Account does not Exist.");
                return;
            }

            double withdrawAmount = 0;

            try
            {
                Console.Write("Enter Withdraw Amount: ");
                withdrawAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Numbers Only.");
                return;
            }

            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than zero.");
                return;
            }

            if (withdrawAmount > balances[index]) 
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[index] -= withdrawAmount;

            Console.WriteLine($"Withdrawal successful!" +
                  $"\nWithdraw Amount: {withdrawAmount:F2}" +
                  $"\nUpdated Balance: {balances[index]:F2}");
        }

        static void ShowBalance() { }

        static void TransferAmount() { }

        static void ListAllAccounts() { }

        static void CloseAccount() { }
    }
}
