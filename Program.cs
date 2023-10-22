

       // Filip Nilsson NET23


using System.ComponentModel.Design;

namespace OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating 5 objects of the Employee class
            Employee Peon1 = new Employee(101, "Ariok", "Male", 4000);
            Employee Peon2 = new Employee(102, "Arnokk", "Male", 6000);
            Employee Peon3 = new Employee(103, "Ashka", "Female", 5000);
            Employee Peon4 = new Employee(104, "Gaula", "Female", 7000);
            Employee Peon5 = new Employee(105, "Angrun", "Male", 3000);


            // ---- Part 1 - Stack ----


            // Creates a stack and adds all peons with Push() method
            Stack<Employee> peonStack = new Stack<Employee>();

            peonStack.Push(Peon1);
            peonStack.Push(Peon2);
            peonStack.Push(Peon3);
            peonStack.Push(Peon4);
            peonStack.Push(Peon5);


            // Prints info about each peon and displays how many peons still remaining in stack
            foreach (Employee peon in peonStack)
            {
                Console.WriteLine(peon);
                Console.WriteLine($"Peons remaining in the stack: {peonStack.Count}");
            }

            Console.WriteLine("---------------------------------------------------");

            // Retrieves each peon in the stack and displays how many peons still remaining in stack
            while (peonStack.Count > 0)
            {
                Employee peon = peonStack.Pop();
                Console.WriteLine(peon);
                Console.WriteLine($"Peons remaining in the stack: {peonStack.Count}");
            }

            Console.WriteLine("---------------------------------------------------");


            // Adding each peon back to the stack
            peonStack.Push(Peon1);
            peonStack.Push(Peon2);
            peonStack.Push(Peon3);
            peonStack.Push(Peon4);
            peonStack.Push(Peon5);


            // Retrieves two objects with peek() method
            for (int i = 0; i < 2; i++)
            {
                Employee peon = peonStack.Peek();
                Console.WriteLine(peon);
                Console.WriteLine($"Peons remaining in the stack: {peonStack.Count}");
            }


            Console.WriteLine("---------------------------------------------------");


            // Checking if Peon3 is in the stack using Contains() method
            if (peonStack.Contains(Peon3))
            {
                Console.WriteLine("Peon3 is in the stack.");
            }


            Console.WriteLine("---------------------------------------------------");


            // ---- Part 2 - List ----


            // Creating a list and adding all peons using Add() method
            List<Employee> peonList = new List<Employee>();

            peonList.Add(Peon1);
            peonList.Add(Peon2);
            peonList.Add(Peon3);
            peonList.Add(Peon4);
            peonList.Add(Peon5);


            // Checks if a certain employee exists in the list
            if (peonList.Contains(Peon2))
            {
                Console.WriteLine("Peon2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Peon2 object does not exists in the list.");
            }


            Console.WriteLine();


            // Finds the first male peon in the list using Find() method
            Console.WriteLine(peonList.Find(male => male.Gender == "Male"));

            Console.WriteLine();


            // Creates a new list and finds all males in peonList and adds them to the new list malePeons
            List<Employee> malePeons = peonList.FindAll(male => male.Gender == "Male");

            foreach (Employee male in malePeons)
            {
                Console.WriteLine(male);
            }

            Console.ReadKey();
        }
    }
}