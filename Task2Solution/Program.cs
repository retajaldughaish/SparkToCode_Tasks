namespace Task2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Countdown Timer

            Console.Write("Enter the Starting Number for Countdown: ");
            int startingNumber = int.Parse(Console.ReadLine());

            for (int i = startingNumber; i> 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
