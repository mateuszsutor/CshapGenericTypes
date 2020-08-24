using System;
using System.Collections.Generic;

namespace _2_GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Array info

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
            Array.Resize(ref employees, 10);

            employees[8] = new Employee { FirstName = "Ala", LastName = "Kot" };

            Console.WriteLine(employees.Length);
            #endregion


            

        }
    }
}
