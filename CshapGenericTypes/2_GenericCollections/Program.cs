using System;
using System.Collections.Generic;

namespace _2_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array info

            //Employee[] employees = new Employee[]
            //{
            //    new Employee { FirstName = "Jan", LastName = "Kowalski" },
            //    new Employee { FirstName = "Tomasz", LastName = "Nowak" },
            //    new Employee { FirstName = "Ela", LastName = "Zawadzka" },
            //};

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].FirstName + " - " + employees[i].LastName);
            //}

            //// resize old array lenght
            //Array.Resize(ref employees, 10);

            //employees[8] = new Employee { FirstName = "Ala", LastName = "Kot" };

            //Console.WriteLine(employees.Length);
            #endregion

            #region List<T> info
            //List<Employee> employessList = new List<Employee>

            //{
            //    new Employee { FirstName = "Jan", LastName = "Kowalski" },
            //    new Employee { FirstName = "Tomasz", LastName = "Nowak" },
            //    new Employee { FirstName = "Ela", LastName = "Zawadzka" },
            //};

            //foreach (var employee in employees)

            //    employessList.Add(new Employee { FirstName = "Ania", LastName = "Kot" });

            //foreach (var employee in employessList)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //}

            //for (int i = 0; i < employees.Length; i++)
            //    for (int i = 0; i < employessList.Count; i++)
            //    {
            //        Console.WriteLine(employees[i].FirstName + " - " + employees[i].LastName);
            //        Console.WriteLine(employessList[i].FirstName + " - " + employessList[i].LastName);
            //    }
            #endregion

            #region Queue<T> info

            //Queue<Employee> employeesQueue = new Queue<Employee>();

            ////Dodawanie zawsze na koniec kolejki
            //employeesQueue.Enqueue(new Employee { FirstName = "Jan", LastName = "Kowalski" });
            //employeesQueue.Enqueue(new Employee { FirstName = "Tomasz", LastName = "Nowak" });
            //employeesQueue.Enqueue(new Employee { FirstName = "Henryk", LastName = "Kania" });
            //employeesQueue.Enqueue(new Employee { FirstName = "Ewa", LastName = "Zawadzka" });


            //while (employeesQueue.Count > 0)
            //{

            //    Console.WriteLine(employeesQueue.Dequeue().ToString());
            //}

            //Console.WriteLine("Kojejka została wyczyszczona");

            #endregion
        }
    }
}

