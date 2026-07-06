namespace Task3Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Absolute Difference
            /*
            Console.Write("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int absoluteDifference = Math.Abs(num2 - num1);

            Console.Write("The Absolute Difference between {0} and {1} is: {2}", num1, num2, absoluteDifference);
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 2 - Power & Root Explorer
            /*
            Console.Write("Enter the Base Number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            double Power = Math.Pow(baseNum, 2);
            double Root = Math.Sqrt(baseNum);

            Console.WriteLine("The Power of {0} is: {1}", baseNum, Power);
            Console.WriteLine("The Square Root of {0} is: {1}", baseNum, Root);
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 3 - Name Formatter
            /*
            Console.Write("Enter your Full Name: ");
            String Name = Console.ReadLine();

            Console.WriteLine("Your Name in Upper Case: " + Name.ToUpper());
            Console.WriteLine("Your Name in Lower Case: " + Name.ToLower());
            Console.WriteLine("The Length of your Name is: " + Name.Length); 
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 4 - Subscription End Date
            /*
            Console.Write("Enter the number of days of a free trial: ");
            if (!int.TryParse(Console.ReadLine(), out int freeTrialDays))
            {
                Console.WriteLine("Invalid input. Please enter a valid number of days.");
                return;
            }

            if (freeTrialDays <= 0)
            {
                Console.WriteLine("The number of days must be greater than zero.");
                return;
            }

            DateTime Start = DateTime.Now;
            DateTime End = Start.AddDays(freeTrialDays);
            Console.WriteLine("Your free trial will end on: " + End.ToString("dd/MM/yyyy"));
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 5 - Grade Rounding System
            /*
            Console.Write("Enter your Raw Exam Score as a Decimal Number: ");
            if (!double.TryParse(Console.ReadLine(), out double rawScore))
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number for the score.");
                return;
            }

            if (rawScore < 0)
            {
                Console.WriteLine("Invalid input. The score cannot be negative.");
                return;
            }

            int roundedScore = (int)Math.Round(rawScore);
            Console.WriteLine("Rounded Score: " + roundedScore);

            if (roundedScore >= 60)
            {
                Console.WriteLine("You Passed the Exam.");
            }
            else
            {
                Console.WriteLine("You Failed the Exam.");
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 6 - Password Strength Checker
            /*
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();
            string P = password.Trim();
            string pLower = P.ToLower();

            bool longEnough = P.Length >= 8;
            bool containsForbidden = pLower.Contains("password");

            if (longEnough && !containsForbidden)
            {
                Console.WriteLine("Strong password");
            }
            else
            {
                Console.WriteLine("Weak password");
                if (! longEnough)
                
                    Console.WriteLine("Reason: must be at least 8 characters long.");

                if (containsForbidden)
                    Console.WriteLine("Reason: must not contain the word 'password'.");
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 7 - Clean Name Comparator
            /*
            Console.Write("Enter the name (First Input): ");
            string name1 = Console.ReadLine();
            Console.Write("Enter the name again (Second Input): ");
            string name2 = Console.ReadLine();

            string clean1 = (name1 ?? "").Trim().ToUpper();
            string clean2 = (name2 ?? "").Trim().ToUpper();

            Console.WriteLine(clean1 == clean2 ? "Match" : "No Match");
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 8 - Membership Expiry Checker
            /*
            Console.Write("Enter Membership Start Date (yyyy-MM-dd): ");
            string startInput = Console.ReadLine();

            DateTime startDate;

            try
            {
                startDate = DateTime.Parse(startInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Use yyyy-MM-dd.");
                return;
            }

            Console.Write("Enter number of Valid Membership days: ");
            if (!int.TryParse(Console.ReadLine(), out int validDays) || validDays < 0)
            {
                Console.WriteLine("Invalid Number of days. Enter a non-negative integer.");
                return;
            }

            DateTime expiryDate = startDate.AddDays(validDays);
            string expiryString = expiryDate.ToString("yyyy-MM-dd");

            if (expiryDate >= DateTime.Today)
            {
                Console.WriteLine("Membership Status: Active");
                Console.WriteLine("Expiry Date: " + expiryString);
            }
            else
            {
                Console.WriteLine("Membership Status: Expired");
                Console.WriteLine("Expiry Date: " + expiryString);
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 9 - Round Up / Round Down Explorer
            /*
            Console.Write("Enter a decimal number: ");
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                Console.WriteLine("Invalid input. Please enter a decimal number.");
                return;
            }

            double nearest = Math.Round(value, 0);
            double alwaysUp = Math.Ceiling(value);
            double alwaysDown = Math.Floor(value);

            Console.WriteLine("Rounded to nearest whole number: " + nearest);
            Console.WriteLine("Always rounded up (ceiling): " + alwaysUp);
            Console.WriteLine("Always rounded down (floor): " + alwaysDown);
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 10 - Word Position Finder
            /*
            Console.Write("Enter a full sentence: ");
            string sentence = Console.ReadLine() ?? "";

            Console.Write("Enter a single word to search for: ");
            string word = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("No search word provided.");
                return;
            }

            int firstIndex = sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            if (firstIndex == -1)
            {
                Console.WriteLine($"'{word}' not found in the sentence.");
            }
            else
            {
                int lastIndex = sentence.LastIndexOf(word, StringComparison.OrdinalIgnoreCase);
                Console.WriteLine("First occurrence index: " + firstIndex);
                Console.WriteLine("Last occurrence index: " + lastIndex);
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Problem 11 -  One-Time Password (OTP) Generator

            Random rnd = new Random();
            int otp = rnd.Next(1000, 10000); 
            Console.WriteLine("OTP (sent): " + otp); 

            int attempts = 0;
            bool verified = false;

            while (attempts < 3 && !verified)
            {
                attempts++;
                Console.Write("Enter the 4-digit OTP: ");
                try
                {
                    int entered = int.Parse(Console.ReadLine());
                    if (entered == otp)
                    {
                        Console.WriteLine("Verified");
                        verified = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect code. Attempts left: " + (3 - attempts));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input (non-numeric). Attempts left: " + (3 - attempts));
                }
            }

            if (!verified)
            {
                Console.WriteLine("Verification Failed");
            }
        }
    }
}

