using System;

namespace _1_GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            //var queue = new CircleQueue<double>(capacity: 3);

            var pesonsQueue = new CircleQueue<Person>();
            pesonsQueue.SaveValue(new Person { FirstName = "Jan", LastName = "Kowalski" });
            pesonsQueue.SaveValue(new Person { FirstName = "Tomasz", LastName = "Nowak" });
            pesonsQueue.SaveValue(new Person { FirstName = "Ewa", LastName = "Zawadzka" });
            pesonsQueue.SaveValue(new Person { FirstName = "Ala", LastName = "Kot" });


            while (!pesonsQueue.IsEmpty)
            {

                var person = pesonsQueue.ReadValue().FirstName;
                Console.WriteLine(person);
            }

            //while (true)
            //{

            //    var value = 0.0;
            //    var startValue = Console.ReadLine();

            //    if (double.TryParse(startValue, out value))
            //    {
            //        queue.SaveValue(value);
            //        continue;
            //    }
            //    break;

            //}

            //var sum = 0.0;
            //Console.WriteLine("W naszej kolejce znajdują się: ");

            //while (!queue.IsEmpty)
            //{

            //    sum += queue.ReadValue();

            //}

            //Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
