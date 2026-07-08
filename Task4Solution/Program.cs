namespace Task4Solution
{
    internal class Program
    {
        // Problem 1 - Personalized Welcome Function
        /*
        public static void PrintWelcome (string name)
        {
            Console.WriteLine("Welcome, " + name + "! Have a great day!");
        }
        */

        ////////////////////////////////////////////////////////////////////////

        // Problem 2 - Square Number Function
        /*
        public static int Square (int n)
        {
            return n * n;
        }
        */

        ////////////////////////////////////////////////////////////////////////

        //Problem 3 - Celsius to Fahrenheit Function

        public static double CelsiusToFahrenheit (double C)
        {
            return (C * 9 / 5) + 32;
        }

        static void Main(string[] args)
        {
            // Problem 1 - Personalized Welcome Function
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome (name);
            */

            ////////////////////////////////////////////////////////////////////////

            // Problem 2 - Square Number Function
            /*
            Console.Write("Enter a Number to be Squared: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int Result = Square(n);

            Console.WriteLine("Squared Result = " + Result);
            */

            ////////////////////////////////////////////////////////////////////////

            //Problem 3 - Celsius to Fahrenheit Function

            Console.Write("Enter a Temperature Value in Celsius: ");
            double C = double.Parse(Console.ReadLine());

            double ResultInF = CelsiusToFahrenheit(C);

            Console.WriteLine("Temperature in Fahrenheit = " + ResultInF);
        }
    }
}
