namespace Task5Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Fixed Grades Array
            /*
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
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 2 - Dynamic To-Do List

            List <string> toDo = new List <string> ();

            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"Enter a Task {i + 1} : ");
                toDo.Add (Console.ReadLine());
            }

            Console.WriteLine("\n To-Do List");
            Console.WriteLine();

            foreach (string Task in toDo)
            {
                Console.WriteLine("- " + Task);
            }
        }
    }
}
