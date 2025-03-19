using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoClass
    {
        // just adding this comment line for committing this file
        private List<string> list = new List<string>()
        {
            "Leetcode","Web dev","Angular", "C#"
        };
        public void AddTask(string enteredTask)
        {
            //list.Add(enteredTask);
            string file = @"D:\Practice\C#\$$PROJECTS\ToDoList\ListItems.txt";
            displayTasks();
        }
        public void RemoveTask(int index)
        {
            list.RemoveAt(index - 1);
            displayTasks();
        }
        public void UpdateTask(int index, string updatedTask)
        {
            //list.ElementAt(index);
            list.RemoveAt(index - 1);
            list.Insert(index-1, updatedTask);
            displayTasks();
        }
        public void displayTasks()
        {
            Console.WriteLine("\nTO DO TASKS: ");
            string file = @"D:\Practice\C#\$$PROJECTS\ToDoList\ListItems.txt";
            if(File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File does not exist. Please recreate");
                Environment.Exit(0);
            }
            //int i = 1;
            //foreach (var task in list)
            //{
            //    Console.WriteLine(i+ ". " + task);
            //    i++;
            //}
            Console.WriteLine();
        }
        public void writeTasksToFile()
        {
            string file = @"D:\Practice\C#\$$PROJECTS\ToDoList\ListItems.txt";
            string[] tasks = File.ReadAllLines(file);
            List<string> taskList = new List<string>();
            taskList = tasks.ToList();
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            } 
        }
        public void ReadFileItems()
        {
            string file = @"D:\Practice\C#\$$PROJECTS\ToDoList\ListItems.txt";
            string[] tasks = File.ReadAllLines(file);
            List<string> taskList = new List<string>();
            taskList = tasks.ToList();
        }
    }
}
