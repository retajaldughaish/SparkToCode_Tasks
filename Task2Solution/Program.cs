namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Countdown Timer
            /*
            Console.Write("Enter the Starting Number for Countdown: ");
            int startingNumber = int.Parse(Console.ReadLine());

            for (int i = startingNumber; i> 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 2 - Sum of Numbers 1 to N
            /*
            Console.Write("Enter a positive integer N: ");
            int n = int.Parse(Console.ReadLine());

            int i;

            int sum = 0;

            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum of numbers from 1 to " + n + " is: " + sum);
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 3 - Multiplication Table

            Console.Write("Enter a positive integer N for multiplication table: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++) 
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
        }
    }
}
