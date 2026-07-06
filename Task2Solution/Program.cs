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
            /*
            Console.Write("Enter a positive integer N for multiplication table: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= 10; i++) 
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 4 - Password Retry
            /*
            string correctPassword = "Spark2026";

            while (true)
            {
                Console.Write("Enter the password: ");
                string userInput = Console.ReadLine();
                
                if (userInput == correctPassword)
                {
                    Console.WriteLine("Access granted.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            }
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 5 - Number Guessing Game
            /*
            int secretNumber = 42;
            int guessCount = 0;

            do
            {
                Console.Write("Guess the secret number (between 1 and 100): ");
                int userGuess = int.Parse(Console.ReadLine());
                guessCount++;
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the secret number.");
                    break;
                }

            } while (true);
            Console.WriteLine("Attempts made: " + guessCount);
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 6 - Safe Division Calculator
            /*
            try
            {
                Console.Write("Enter the First Number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the Second Number: ");
                int num2 = int.Parse(Console.ReadLine());
                
                int result = num1 / num2;
                Console.WriteLine("Division Result: " + result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            */

            /////////////////////////////////////////////////////////////////////////

            // Problem 7 - Repeating Menu with Exit Option

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Current Time-of-day Greeting ");
                Console.WriteLine("3. Exit");
                try
                {
                    Console.Write("Enter your choice (1-3): ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;

                        case 2:
                            Console.WriteLine("Good Morning! Have a great day!");
                            break;

                        case 3:
                            Console.WriteLine("Exiting the program.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }   
        }
    }
}
