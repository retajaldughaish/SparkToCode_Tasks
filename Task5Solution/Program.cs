namespace Task5Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Fixed Grades Array

            int[] StudentGrade = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Grade {i + 1} : ");
                StudentGrade [i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("\n Student Grades");
            Console.WriteLine();

            foreach (int grade in StudentGrade) 
            {
                Console.WriteLine("Grades: " + grade);
            }
        }
    }
}
