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
            /*
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
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 3 - Browsing History Stack
            /*
            Stack <string> browserspagehistory = new Stack<string>();
            
            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Enter Website URL: ");
                browserspagehistory.Push(Console.ReadLine());
            }

            string removedPage = browserspagehistory.Pop();

            Console.WriteLine("Back from: " + removedPage);
            Console.WriteLine("Current page: " + browserspagehistory.Peek());
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 4 - Customer Service Queue
            /*
            Queue <string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Customer Name: ");
                customers.Enqueue(Console.ReadLine());
            }

            String servedCustomer = customers.Dequeue();
            Console.WriteLine("\nServed Customer Name: " +  servedCustomer);
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 5 - Array Grade Range
            /*
            int[] StudentGrade = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Grade {i + 1} : ");
                StudentGrade[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(StudentGrade);

            int total = 0;

            for (int i = 0; i < StudentGrade.Length; i++)
            {
                total += StudentGrade[i];
            }

            double averageStudentGrade = total / 5.0;

            Console.WriteLine("The Lowest Grade is: " + StudentGrade[0]);
            Console.WriteLine("The Highest Grade is: " + StudentGrade[4]);
            Console.WriteLine("The Average Grade is: " + averageStudentGrade.ToString("F2"));
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 6 - Filtered Shopping List
            /*
            List <string> shoppinglist = new List <string> ();

            string item = "";

            while (item != "done")
            {
                Console.Write("Enter an item (or type 'done'): ");
                item = Console.ReadLine();
                if (item != "done") 
                {
                    shoppinglist.Add(item);
                }
                
            }

            Console.WriteLine("\nShopping List");
            Console.WriteLine();

            foreach (string itemInList in shoppinglist)
            {
                Console.WriteLine(itemInList);
            }

            Console.WriteLine();
            Console.Write("What Item You Want to Remove: ");
            string remove = Console.ReadLine();
            shoppinglist.Remove(remove);

            Console.WriteLine("\nShopping List After Removing an Item");
            Console.WriteLine();

            foreach (string After in shoppinglist)
            {
                Console.WriteLine(After);
            }
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 7 - High Score Podium
            /*
            List<int> gameScores = new List <int> ();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Game {i+1} Score: ");
                gameScores.Add (int.Parse (Console.ReadLine()));
            }

            gameScores.Sort ();
            gameScores.Reverse ();

            Console.WriteLine();

            Console.WriteLine("1st place: " + gameScores[0]);
            Console.WriteLine("2nd place: " + gameScores[1]);
            Console.WriteLine("3rd place: " + gameScores[2]);
            */

            ///////////////////////////////////////////////////////////////////////////

            // Problem 8 - Undo Last Action

            Stack <string> actions = new Stack<string>();

            string action = "";

            while (action != "stop")
            {
                Console.Write("Enter an action (or type 'stop'): ");
                action = Console.ReadLine();

                if (action != "stop")
                {
                    actions.Push(action);
                }
            }

            Console.WriteLine();

            String Undo1 = actions.Pop();
            Console.WriteLine("First Undo: " + Undo1);

            string Undo2 = actions.Pop();
            Console.WriteLine("Second Undo: " + Undo2);

            Console.WriteLine("\nRemaining Actions After Two Undos:");
            Console.WriteLine();

            foreach (string remainingAction in actions)
            {
                Console.WriteLine(remainingAction);
            }
        }
    }
}
