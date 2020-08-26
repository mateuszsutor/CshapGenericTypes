using System;
using System.Collections.Generic;

namespace _2_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {


            //Array();
            //List();
            //Queue();
            //Stack();

        }

        private static void Array()
        {
            Employee[] employees = new Employee[]
            {
                new Employee { FirstName = "Jan", LastName = "Kowalski" },
                new Employee { FirstName = "Tomasz", LastName = "Nowak" },
                new Employee { FirstName = "Ela", LastName = "Zawadzka" },
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].FirstName + " - " + employees[i].LastName);
            }

            // resize old array lenght
            System.Array.Resize(ref employees, 10);

            employees[8] = new Employee { FirstName = "Ala", LastName = "Kot" };

            Console.WriteLine(employees.Length);
        }

        private static void List()
        {
            List<Employee> employessList = new List<Employee>

            {
                new Employee { FirstName = "Jan", LastName = "Kowalski" },
                new Employee { FirstName = "Tomasz", LastName = "Nowak" },
                new Employee { FirstName = "Ela", LastName = "Zawadzka" },
            };

            foreach (var employee in employees)

                employessList.Add(new Employee { FirstName = "Ania", LastName = "Kot" });

            foreach (var employee in employessList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            for (int i = 0; i < employees.Length; i++)
                for (int i = 0; i < employessList.Count; i++)
                {
                    Console.WriteLine(employees[i].FirstName + " - " + employees[i].LastName);
                    Console.WriteLine(employessList[i].FirstName + " - " + employessList[i].LastName);
                }
        }

        private static void Stack()
        {
            //Last In Last Out - LIFO
            Stack<Employee> employeesStack = new Stack<Employee>();

            employeesStack.Push(new Employee { FirstName = "Jan", LastName = "Kowalski" });
            employeesStack.Push(new Employee { FirstName = "Tomasz", LastName = "Nowak" });
            employeesStack.Push(new Employee { FirstName = "Henryk", LastName = "Kania" });
            employeesStack.Push(new Employee { FirstName = "Ewa", LastName = "Zawadzka" });

            Console.WriteLine();
            Console.WriteLine("Stos");


            while (employeesStack.Count > 0)
            {

                Console.WriteLine(employeesStack.Pop().ToString());
            }

            Console.WriteLine("Stos został wyczyszczony");
        }

        private static void Queue()
        {
            //First In Fist Out  - FIFO
            Queue<Employee> employeesQueue = new Queue<Employee>();

            //Dodawanie zawsze na koniec kolejki
            employeesQueue.Enqueue(new Employee { FirstName = "Jan", LastName = "Kowalski" });
            employeesQueue.Enqueue(new Employee { FirstName = "Tomasz", LastName = "Nowak" });
            employeesQueue.Enqueue(new Employee { FirstName = "Henryk", LastName = "Kania" });
            employeesQueue.Enqueue(new Employee { FirstName = "Ewa", LastName = "Zawadzka" });

            Console.WriteLine("Kolejka");

            while (employeesQueue.Count > 0)
            {

                Console.WriteLine(employeesQueue.Dequeue().ToString());
            }

            Console.WriteLine("Kojejka została wyczyszczona");
        }
    }
}

