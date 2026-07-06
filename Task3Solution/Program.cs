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

        }
    }
}

