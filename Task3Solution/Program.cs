namespace Task3Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Absolute Difference

            Console.Write("Enter the First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int absoluteDifference = Math.Abs(num2 - num1);

            Console.Write("The Absolute Difference between {0} and {1} is: {2}", num1, num2, absoluteDifference);
        }
    }
}
