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

        // ===================== BANKING SERVICE FUNCTIONS =====================
        // Each function performs one banking operation by reading user input,
        // validating the data, updating the account lists, and displaying the result.

        // Service 1: Adds a new bank account after validating the customer information
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

        // Service 2: Deposits money into an existing account after validating the account number and deposit amount
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

        // Service 3: Withdraws money from an existing account if the account has sufficient balance
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

        // Service 4: Displays the customer's account information and current balance
        static void ShowBalance() 
        {
            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("The Account does not Exist.");
                return;
            }

            Console.WriteLine("Customer Name: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine($"Balance: {balances[index]:F2}");
        }

        // Service 5: Transfers money from one account to another after validating both accounts and the transfer amount
        static void TransferAmount() 
        {
            Console.Write("Enter Sender Account Number: ");
            String senderAccountNumber = Console.ReadLine();

            int SenderIndex = accountNumbers.IndexOf(senderAccountNumber);

            if (SenderIndex == -1)
            {
                Console.WriteLine("The Account does not Exist.");
                return;
            }

            Console.Write("Enter Receiver Account Number: ");
            string receiverAccountNumber = Console.ReadLine();

            int ReceiverIndex = accountNumbers.IndexOf(receiverAccountNumber);

            if (ReceiverIndex == -1)
            {
                Console.WriteLine("The Account does not Exist.");
                return;
            }

            if (senderAccountNumber == receiverAccountNumber)
            {
                Console.WriteLine("Sender and receiver accounts cannot be the same.");
                return;
            }

            double transferAmount = 0;

            try
            {
                Console.Write("Enter Transfer Amount: ");
                transferAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Numbers Only.");
                return;
            }

            if (transferAmount <= 0) 
            {
                Console.WriteLine("Transfer amount must be greater than zero.");
                return;
            }

            if (transferAmount > balances[SenderIndex])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[SenderIndex] -= transferAmount;

            balances[ReceiverIndex] += transferAmount;

            Console.WriteLine($"Transfer completed successfully!" +
                  $"\nSender Account Balance: {balances[SenderIndex]:F2}" +
                  $"\nReceiver Account Balance: {balances[ReceiverIndex]:F2}");
        }

        static void ListAllAccounts() { }

        static void CloseAccount() { }
    }
}
