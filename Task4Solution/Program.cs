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
        /*
        public static double CelsiusToFahrenheit (double C)
        {
            return (C * 9 / 5) + 32;
        }
        */

        ////////////////////////////////////////////////////////////////////////

        // Problem 4 - Fixed Menu Display Function
        /*
        public static void DisplayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
        }
        */

        ////////////////////////////////////////////////////////////////////////

        // Problem 5 - Even or Odd Function
        /*
        public static bool IsEven (int n)
        {
            return n % 2 == 0;
        }
        */

        ////////////////////////////////////////////////////////////////////////

        // Problem 6 - Rectangle Area & Perimeter Functions
        /*
        public static double CalculateArea (double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter (double length, double width)
        {
            return 2 * (length + width);
        }
        */

        ////////////////////////////////////////////////////////////////////////

        // Problem 7 - Grade Letter Function

        public static string GetGradeLetter (int grade)
        {
            if (grade >= 0 && grade <= 49)
            {
                return "F";
            }
            else if (grade >= 50 && grade <= 59)
            {
                return "D";
            }
            else if (grade >= 60 && grade <= 69)
            {
                return "C";
            }
            else if (grade >= 70 && grade <= 79)
            {
                return "B";
            }
            else if (grade >= 80 && grade <=100)
            {
                return "A";
            }
            else
            {
                return "Invalid Grade";
            }
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
            /*
            Console.Write("Enter a Temperature Value in Celsius: ");
            double C = double.Parse(Console.ReadLine());

            double ResultInF = CelsiusToFahrenheit(C);

            Console.WriteLine("Temperature in Fahrenheit = " + ResultInF);
            */

            ////////////////////////////////////////////////////////////////////////

            // Problem 4 - Fixed Menu Display Function
            /*
            DisplayMenu();
            */

            ////////////////////////////////////////////////////////////////////////

            // Problem 5 - Even or Odd Function
            /*
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());

            if (IsEven(n))
            {
                Console.WriteLine("The Number is Even.");
            }
            else
            {
                Console.WriteLine("The Number is Odd.");
            }
            */

            ////////////////////////////////////////////////////////////////////////

            // Problem 6 - Rectangle Area & Perimeter Functions
            /*
            Console.Write("Enter Rectangle Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rectangle Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Rectangle Area: " + area);
            Console.WriteLine("Rectangle Perimeter: " + perimeter);
            */

            ////////////////////////////////////////////////////////////////////////

            // Problem 7 - Grade Letter Function

            Console.Write("Enter your Grade: ");
            int grade = int.Parse(Console.ReadLine());

            string letter = GetGradeLetter(grade);

            if (letter == "Invalid Grade")
            {
                Console.WriteLine("Please enter a grade between 0 and 100.");
            }
            else
            {
                Console.WriteLine("Your Grade is: " + letter);
            }
        }
    }
}
