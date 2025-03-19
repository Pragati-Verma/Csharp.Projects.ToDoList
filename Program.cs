namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoClass toDo = new ToDoClass();
            bool flag = false;
            char ch;
            do
            {
                toDo.displayTasks();
                Console.WriteLine();
                Console.WriteLine("Select your choice:\n1. Add\n2. Delete\n3. Update\n4. Display\n" +
                    "5. Quit/Cancel\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a task to do: ");
                        string task = Console.ReadLine();
                        toDo.AddTask(task);
                        break;
                    case 2:
                        toDo.displayTasks();
                        Console.Write("Enter task number which you want to delete: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        toDo.RemoveTask(index);
                        break;
                    case 3:
                        toDo.displayTasks();
                        Console.Write("Enter task number which you want to update: ");
                        int taskIndex = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter updated task item: ");
                        string newTaskItem = Console.ReadLine();
                        toDo.UpdateTask(taskIndex,newTaskItem);
                        break;
                    case 4:
                        toDo.displayTasks();
                        break;
                    case 5:
                        Console.WriteLine("QUITTING");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid!! Try again!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to try again?? Enter Y to continue. " +
                    "Enter N to quit.");
                ch = Convert.ToChar(Console.ReadLine());
                if(ch == 'Y' ||  ch == 'y')
                {
                    flag = true;
                }
                else if (ch == 'N' || ch == 'n')
                {
                    flag = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. QUITTING!!!!");
                    Environment.Exit(0);
                }
            } while (flag == true);
            //Console.WriteLine("QUITTING");
            Console.ReadKey();
        }
    }
}
