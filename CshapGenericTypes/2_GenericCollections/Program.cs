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
            //Dictionary();
            //SortetDictionary();
            //SortedList();
            //SortedSet();

            var employees = new DepartmentCollection();


            employees.Add("Księgowość", new SortedSet<Employee>(new EmployeeComparer()));

            // dodawanie spos 1
            employees["Księgowość"].Add(new Employee { FirstName = "Jan", LastName = "Kowalski" });
            employees["Księgowość"].Add(new Employee { FirstName = "Barbara", LastName = "Nowak" });
            employees["Księgowość"].Add(new Employee { FirstName = "Urszula", LastName = "Stanek" });
            employees["Księgowość"].Add(new Employee { FirstName = "Bartosz", LastName = "Jarema" });


            // dodawanie spos 2
            employees.Add("Sprzedaż", new Employee { FirstName = "Anna", LastName = "Cięciel" })
                     .Add("Sprzedaż", new Employee { FirstName = "Piotr", LastName = "Krzystanek" })
                     .Add("Sprzedaż", new Employee { FirstName = "Jakub", LastName = "Nowak" })
                     .Add("Sprzedaż", new Employee { FirstName = "Dominik", LastName = "Krzystanek" })
                     .Add("Sprzedaż", new Employee { FirstName = "Dominik", LastName = "Krzystanek" })
                     .Add("Sprzedaż", new Employee { FirstName = "Adam", LastName = "Krzystanek" });





            foreach (var department in employees)
            {
                Console.WriteLine(department.Key);

                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.LastName + " " + employee.FirstName);
                }
            }

        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();

            set.Add(7);
            set.Add(66);
            set.Add(32);
            set.Add(4);
            set.Add(4);
            set.Add(2);
            set.Add(1);
            set.Add(5);
            set.Add(3);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            var set2 = new SortedSet<string>();

            set2.Add("ewa");
            set2.Add("piotrek");
            set2.Add("alan");
            set2.Add("zbigniew");
            set2.Add("tadeusz");
            set2.Add("ewelina");
            set2.Add("adam");
            set2.Add("urszula");
            set2.Add("monika");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var sortedList = new SortedList<int, string>();

            sortedList.Add(7, "siedem");
            sortedList.Add(3, "trzy");
            sortedList.Add(1, "jeden");
            sortedList.Add(4, "cztery");
            sortedList.Add(2, "dwa");

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortetDictionary()
        {
            var employees = new SortedDictionary<string, List<Employee>>();

            employees.Add("Sprzedaż", new List<Employee> { new Employee { FirstName = "Jan", LastName = "Kowalski" },
                                                           new Employee { FirstName = "Bartosz", LastName = "Nowak" },
                                                           new Employee { FirstName = "Marek", LastName = "Kot" }});


            employees.Add("Informatyka", new List<Employee> { new Employee { FirstName = "Marcin", LastName = "Lutek" },
                                                              new Employee { FirstName = "Anna", LastName = "Zawadzka" }});


            employees.Add("Księgowość", new List<Employee> { new Employee { FirstName = "Renata", LastName = "Wyszko" },
                                                             new Employee { FirstName = "Elżbieta", LastName = "Karaś" },
                                                             new Employee { FirstName = "Halina", LastName = "Prusak" },
                                                             new Employee { FirstName = "Marta", LastName = "Anieli" }});

            foreach (var item in employees)
            {
                Console.WriteLine($"Ilośc pracowników w dziale {item.Key} wynosi {item.Value.Count}");

                Console.WriteLine($"Dział: {item.Key}");
                foreach (var employe in item.Value)
                {
                    Console.WriteLine($"Pracownik: {employe.FirstName} {employe.LastName}");
                }
                Console.WriteLine();
            }
        }

        private static void Dictionary()
        {
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

