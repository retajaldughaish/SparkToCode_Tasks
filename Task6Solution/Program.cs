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
            if (Balance >= amount)
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
        static void Main(string[] args)
        {
            
        }
    }
}
