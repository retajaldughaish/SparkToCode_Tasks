namespace Task4Solution
{
    internal class Program
    {
        // Problem 1 -  Personalized Welcome Function

        public static void PrintWelcome (string name)
        {
            Console.WriteLine("Welcome, " + name + "! Have a great day!");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome (name);
        }
    }
}
