namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Personal Info Card
            /*
            String name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.Write("Name: " + name);
            Console.Write(", Age: " + age);
            Console.Write(", Height: " + height);
            Console.Write(", Student: " + isStudent);
            */

            ////////////////////////////////////////////////////////

            // Problem 2 - Rectangle Calculator
            /*
            Console.Write("Please Enter the Length of a Rectangle: ");
            float RLength = float.Parse(Console.ReadLine());
            Console.Write("Please Enter the Width of a Rectangle: ");
            float RWidth = float.Parse(Console.ReadLine());

            float Area = RLength * RWidth;
            float Perimeter = 2 * (RLength + RWidth);

            Console.Write("Rectangle Area = " + Area + " , Rectangle Perimeter = " + Perimeter);
            */

            ////////////////////////////////////////////////////////

            // Problem 3 - Even or Odd Checker

            int i;
            Console.Write("Enter a Number To Check Whether it's an Odd or Even: ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }
        }
    }
}
