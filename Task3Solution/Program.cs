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

            Console.Write("Enter your Full Name: ");
            String Name = Console.ReadLine();

            Console.WriteLine("Your Name in Upper Case: " + Name.ToUpper());
            Console.WriteLine("Your Name in Lower Case: " + Name.ToLower());
            Console.WriteLine("The Length of your Name is: " + Name.Length); 
        }
    }
}
