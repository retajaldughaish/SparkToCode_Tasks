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
            /*
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
            */

            ////////////////////////////////////////////////////////

            // Problem 4 - Voting Eligibility
            /*
            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please Enter whether you hold a valid national ID (yes/no): ");
            String HoldID = Console.ReadLine();

            bool hasID = false;
            if (HoldID == "yes")
            {
                hasID = true;
            }
            else if (HoldID == "no")
            {
                hasID = false;
            }
            else
            {
                Console.WriteLine("Invalid input for national ID. Please enter 'yes' or 'no'.");
            }

            if(age >= 18 && hasID)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            */

            ////////////////////////////////////////////////////////

            // Problem 5 - Grade Letter Lookup
            /*
            Console.Write("Please Enter Your Grade ('A', 'B', 'C', 'D', or 'F'): ");
            String grade = Console.ReadLine();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;

                case "B":
                    Console.WriteLine("Veery Good");
                    break;

                case "C":
                    Console.WriteLine("Good");
                    break;

                case "D":
                    Console.WriteLine("Pass");
                    break;

                case "F":
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade entered.");
                    break;
            }
            */

            ////////////////////////////////////////////////////////

            // Problem 6 - Temperature Converter
            /*
            Console.Write("Please Enter the Temperature in Celsius: ");
            float celsius = float.Parse(Console.ReadLine());

            float fahrenheit = (celsius * 9 / 5) + 32;

            String classification;

            if (celsius < 10)
            {
                classification = "Cold";
            }
            else if (celsius >= 10 && celsius <= 30)
            {
                classification = "Mild";
            }
            else
            {
                classification = "Hot";
            }

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            Console.WriteLine("Weather classification is " + classification);
            */

            ////////////////////////////////////////////////////////

            // Problem 7 - Movie Ticket Pricing
            /*
            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            String category;
            double price;

            if (age >=0 && age <=12)
            {
                category = "Child";
                price = 2.000;
            }
            else if (age >=13 && age <= 59)
            {
                category = "Adult";
                price = 5.000;
            }
            else if (age >= 60)
            {
                category = "Senior";
                price = 3.000;
            }
            else
            {
                category = "Invalid age";
                price = 0.000;
            }

            Console.WriteLine("You are in the " + category + " category. Your ticket price is " 
                + price + " OMR");
            */

            ////////////////////////////////////////////////////////

            // Problem 8 - Restaurant Bill with Membership Discount
            /*
            Console.Write("Please Enter the Total Bill Amount: ");
            double totalBill = double.Parse(Console.ReadLine());
            Console.Write("Please Enter Whether you are a loyalty member (yes/no): ");
            String membershipStatus = Console.ReadLine();

            int discountPercentage = 15;

            if (totalBill >20 && membershipStatus == "yes")
            {
                double discountAmount = (discountPercentage / 100.0) * totalBill;
                double finalBill = totalBill - discountAmount;
                Console.WriteLine("Your Original bill is: " + totalBill + " OMR");
                Console.WriteLine("You are eligible for a " + discountPercentage + "% discount.");
                Console.WriteLine("Discount amount: " + discountAmount + " OMR");
                Console.WriteLine("Your final bill amount after discount is: " + finalBill + " OMR");
            }
            else if (totalBill >=0)
            {
                Console.WriteLine("Your Orginal bill is: " + totalBill + " OMR");
                Console.WriteLine("You are not eligible for a discount.");
                Console.WriteLine("Your total bill amount is: " + totalBill + " OMR");

            }
            else
            {
                Console.WriteLine("Invalid input. Please ensure the bill amount is non-negative " +
                    "and membership status is either 'yes' or 'no'.");
            }
            */

            ////////////////////////////////////////////////////////

            // Problem 9 - Day Name Finder
            /*
            Console.Write("Please Enter a Number (1-7) to Find the Corresponding Day of the Week: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is Sunday.");
                    break;

                case 2:
                    Console.WriteLine("The day is Monday.");
                    break;

                case 3:
                    Console.WriteLine("The day is Tuesday.");
                    break;

                case 4:
                    Console.WriteLine("The day is Wednesday.");
                    break;

                case 5:
                    Console.WriteLine("The day is Thursday.");
                    break;

                case 6:
                    Console.WriteLine("The day is Friday.");
                    break;

                case 7:
                    Console.WriteLine("The day is Saturday.");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
            */

            ////////////////////////////////////////////////////////

            // Problem 10 - Mini Calculator
            /*
            Console.Write("Please Enter the First Number: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Please Enter the Second Number: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Please Enter the Operation (+, -, *, /, Or %): ");
            String operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("The Result of " + n1 + " + " + n2 + " = " + (n1 + n2));
                    break;

                case "-":
                    Console.WriteLine("The Result of " + n1 + " - " + n2 + " = " + (n1 - n2));
                    break;

                case "*":
                    Console.WriteLine("The Result of " + n1 + " * " + n2 + " = " + (n1 * n2));
                    break;

                case "/":
                    if (n2 != 0)
                    {
                        Console.WriteLine("The Result of " + n1 + " / " + n2 + " = " + (n1 / n2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                case "%":
                    if (n2 != 0)
                    {
                        Console.WriteLine("The Result of " + n1 + " % " + n2 + " = " + (n1 % n2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Modulus by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please enter one of the following:" +
                        "" +
                        " '+', '-', '*', '/', '%'.");
                    break;
            }
            */

            ////////////////////////////////////////////////////////

            // Problem 11 -  Loan Eligibility System

            Console.Write("Please Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Your Monthly Income: ");
            double monthlyIncome = double.Parse(Console.ReadLine());
            Console.Write("Do you have an existing loan (yes/no): ");
            String existingLoanInput = Console.ReadLine();

            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else if (monthlyIncome < 0)
            {
                Console.WriteLine("Monthly income cannot be negative.");
            }
            else if (existingLoanInput != "yes" && existingLoanInput != "no")
            {
                Console.WriteLine("Invalid input. Please enter only 'yes' or 'no'.");
            }
            else if (age >= 21 && age <= 60 && monthlyIncome >= 400 && existingLoanInput == "no")
            {
                Console.WriteLine("You are eligible for a loan.");
            }
            else if (age < 21 || age > 60)
            {
                Console.WriteLine("You are not eligible due to age restrictions.");
            }
            else if (monthlyIncome < 400)
            {
                Console.WriteLine("You are not eligible due to insufficient income.");
            }
            else
            {
                Console.WriteLine("You are not eligible because you have an existing loan.");
            }
        }
    }
}

