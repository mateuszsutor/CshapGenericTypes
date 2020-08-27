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
            //HashSet();
            //LinkedList();
            //LinkedListNodeExample();


            // w javie Mapa, Key - musi być unikalny
            //Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            var employees = new Dictionary<string, List<Employee>>();

            employees.Add("Kadry", new List<Employee>() { new Employee { FirstName = "Marek", LastName = "Nowak" } });
            employees["Kadry"].Add(new Employee { FirstName = "Joanna", LastName = "Nowak" });
            employees["Kadry"].Add(new Employee { FirstName = "Marta", LastName = "Nowak" });


            employees.Add("Ksiegowosc", new List<Employee>() { new Employee { FirstName = "Jan", LastName = "Kowalski" },
                                                               new Employee { FirstName = "Bartosz", LastName = "Kowalski"},
                                                               new Employee { FirstName = "Marek", LastName = "Kowalski" }});


            foreach (var item in employees)
            {
                Console.WriteLine("Dział " + item.Key);
                foreach (var employee in item.Value)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
                Console.WriteLine();

            }
            Console.WriteLine("Pracowwnicy ksiegowosci (employees[Ksiegowosc])");

            foreach (var employee in employees["Ksiegowosc"])
            {
                Console.WriteLine(employee.ToString());
            }
           

        }

        private static void LinkedListNodeExample()
        {
            LinkedList<int> listInt = new LinkedList<int>();
            listInt.AddFirst(5);
            listInt.AddFirst(6);
            listInt.AddFirst(7);

            var firstElement = listInt.First;
            var lastElement = listInt.Last;


            listInt.AddAfter(firstElement, 10);
            listInt.AddBefore(firstElement, 50);

            var node = listInt.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> listInt = new LinkedList<int>();
            listInt.AddFirst(5);
            listInt.AddFirst(6);
            listInt.AddFirst(7);
            listInt.AddLast(1);
            listInt.AddLast(2);

            foreach (var item in listInt)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashSet()
        {
            #region HashSet <int>
            //Nie pozwala na dublowanie wartości, nie gwarantuje identycznej kolejności wzg. dodawania elementu.
            //Będzie bardo dobrze wiedział jak pracować z typami wartości /int, double, dateTime.../ (wie jak je porównać)
            HashSet<int> setNumbers = new HashSet<int>();
            setNumbers.Add(1);
            setNumbers.Add(2);
            setNumbers.Add(3);
            setNumbers.Add(4);
            setNumbers.Add(5);
            setNumbers.Add(6);
            setNumbers.Add(7);
            setNumbers.Add(8);
            setNumbers.Add(9);
            setNumbers.Add(10);
            bool result = false;

            for (int i = 1; i < 100; i++)
            {
                result = setNumbers.Add(i);
                Console.WriteLine($"Czy udało się dodać liczbę: {i} do setu? {result}");
            }

            #endregion 

            #region HashSet <Employee>
            HashSet<Employee> employeesHashSet = new HashSet<Employee>();

            var employee1 = new Employee { FirstName = "Tomasz", LastName = "Nowak" };

            employeesHashSet.Add(new Employee { FirstName = "Jan", LastName = "Kowalski" });
            employeesHashSet.Add(new Employee { FirstName = "Jan", LastName = "Kowalski" }); // domyśnie pozwoli dodać, ponieważ są to inne(new) obiekty
            employeesHashSet.Add(employee1);
            employeesHashSet.Add(employee1); // w tym przypadku nie będzie dubla ponieważ dodajemy ten sam obiekt
            employeesHashSet.Add(new Employee { FirstName = "Ela", LastName = "Zawadzka" });


            foreach (var item in employeesHashSet)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion
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


            employessList.Add(new Employee { FirstName = "Ania", LastName = "Kot" });

            foreach (var employee in employessList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }


            for (int i = 0; i < employessList.Count; i++)
            {

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

