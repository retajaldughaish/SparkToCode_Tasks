using System;

namespace Task6Solution
{
    // BankAccount Class Created
    public class BankAccount
    {
        public int AccountNumber { get; set;  }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
            }
            else if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public double CheckBalance ()
        {
            PrintInformation();
            return Balance;     
        }
        private void PrintInformation()
        {
            Console.WriteLine("Account Holder Name: " + HolderName);
            Console.WriteLine($"Current Balance: {Balance:F2}");
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Notification Sent.");
        }
    }

    // Student Class Created
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }
        int age { get; set; }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Notification Sent.");
        }
    }

    // Product Class Created
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not Enough Stock.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            if (quantity > 0)
            {
                StockQuantity += quantity;
                LogTransaction();
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine($"Product Price: {Price:F3}");
            Console.WriteLine("Product Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction Has Been Logged Successfully.");
        }
    }

    public class Program
    {
        // Create BankAccount Class Objects
        static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Retaj", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        // Create Student Class Objects
        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 75 };

        // Create Product Class Objects
        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            // Created The Main Menu With Options 1–20.
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press Any Key");
                Console.ReadKey();
                Console.Clear();
            }
        
        }

        // Select and Return a Bank Account Object.
        static BankAccount ChooseAccount()
        {
            Console.Write("Choose Account (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input == 1)
                    return account1;

                if (input == 2)
                    return account2;
            }

            Console.WriteLine("Invalid input. Defaulting to Account 1.");
            return account1;
        }

        // Select and Return a Student Object.
        static Student ChooseStudent()
        {
            Console.Write("Choose Student (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input == 1)
                    return student1;

                if (input == 2)
                    return student2;
            }

            Console.WriteLine("Invalid input. Defaulting to Student 1.");
            return student1;
        }

        // Select and Return a Product Object.
        static Product ChooseProduct()
        {
            Console.Write("Choose Product (1 or 2): ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input == 1)
                    return product1;

                if (input == 2)
                    return product2;
            }

            Console.WriteLine("Invalid input. Defaulting to Product 1.");
            return product1;
        }

        // --------------------------------- Cases 1-5 (Easy) -------------------------------------------------

        // Display the Selected Account Information and Balance.
        static void ViewAccountDetails() 
        {
            BankAccount chosen = ChooseAccount();
            chosen.CheckBalance();
        }

        // Update the Address of the Selected Student.
        static void UpdateStudentAddress() 
        {
            Student selectedStudent = ChooseStudent();

            Console.Write("Enter The New Address: ");
            string newAddress = Console.ReadLine();

            string oldAddress = selectedStudent.Address;

            selectedStudent.Address = newAddress;

            Console.WriteLine("Address Updated Successfully.");
            Console.WriteLine("Old Address: " + oldAddress);
            Console.WriteLine("Updated Address: " + selectedStudent.Address);
        }

        // Deposit Money into the Selected Bank Account.
        static void MakeDeposit()
        {
            BankAccount chosen = ChooseAccount();
            Console.Write("Enter Amount to Deposit: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                chosen.Deposit(amount);
                Console.WriteLine($"New Balance: {chosen.Balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        // Withdraw Money from the Selected Bank Account.
        static void MakeWithdrawal() 
        {
            BankAccount chosen = ChooseAccount();
            Console.Write("Enter Amount to Withdraw: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                chosen.Withdraw(amount);
                Console.WriteLine($"New Balance: {chosen.Balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid amount entered.");
            }
        }

        // Display the Selected Product Details and Inventory Value.
        static void ViewProductDetails() 
        {
            Product chosen = ChooseProduct();

            double inventoryValue = chosen.GetInventoryValue();

            Console.WriteLine($"Inventory Value: {inventoryValue:F3}");
        }

        // --------------------------------- Cases 6-8 (Medium) -------------------------------------------------

        // Register the Selected Student Using an Email Address.
        static void RegisterStudent() 
        {
            Student chosen = ChooseStudent();

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();

            chosen.Register(email);
            Console.WriteLine("Email has been added successfully.");

        }

        // Compare the Balances of Both Bank Accounts.
        static void CompareAccountBalances() 
        {
            if (account1.Balance > account2.Balance)
            {
                Console.WriteLine($"{account1.HolderName} (Account {account1.AccountNumber}) currently holds more money.");
            }
            else if (account2.Balance > account1.Balance)
            {
                Console.WriteLine($"{account2.HolderName} (Account {account2.AccountNumber}) currently holds more money.");
            }
            else
            {
                Console.WriteLine("Both accounts currently hold the same amount of money.");
            }
        }

        // Restock the Selected Product and Display Its Stock Level.
        static void RestockProduct() 
        {
            Product chosen = ChooseProduct();

            Console.Write("Enter Quantity: ");
            if (int.TryParse(Console.ReadLine(), out int quantity))
            {
                chosen.Restock(quantity);

                int updatedStock = chosen.StockQuantity;
                Console.WriteLine($"Updated Stock: {updatedStock}");

                if (updatedStock < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (updatedStock >= 10 && updatedStock <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else 
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }
            else
            {
                Console.WriteLine("Invalid quantity entered.");
            }
        }

        // --------------------------------- Cases 9-13 (Hard) -------------------------------------------------


        static void TransferBetweenAccounts() { }
        static void UpdateStudentGrade() { }
        static void StudentReportCard() { }
        static void AccountHealthStatus() { }
        static void BulkSaleWithRevenue() { }

        // --------------------------------- Cases 14-15 (Advanced) -------------------------------------------------

        static void ScholarshipEligibilityCheck() { }
        static void FullBalanceTopUpFlow() { }


        // --------------------------------- Cases 16-19 (Self-Research) -------------------------------------------------

        static void QuickAccountOpening() { }
        static void TotalStudentsCounter() { }
        static void OverdrawnAccountCheck() { }
        static void SetStudentSecurityPin() { }
    }
}
