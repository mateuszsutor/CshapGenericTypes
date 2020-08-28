using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GenericClassAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new CircleQueue<double>(capacity: 5);

            InputData(queue);
            ProcessingData(queue);

            Console.ReadKey();
        }

        private static void ProcessingData(IQueue<double> queue)
        {
            var sum = 0.0;
            Console.WriteLine("W naszej kolejce znajdują się: ");

            while (!queue.IsEmpty)
            {

                sum += queue.ReadValue();

            }

            #region personQueue
            //var pesonsQueue = new CircleQueue<Person>();
            //pesonsQueue.SaveValue(new Person { FirstName = "Jan", LastName = "Kowalski" });
            //pesonsQueue.SaveValue(new Person { FirstName = "Tomasz", LastName = "Nowak" });
            //pesonsQueue.SaveValue(new Person { FirstName = "Ewa", LastName = "Zawadzka" });
            //pesonsQueue.SaveValue(new Person { FirstName = "Ala", LastName = "Kot" });


            //while (!pesonsQueue.IsEmpty)
            //{

            //    var person = pesonsQueue.ReadValue().FirstName;
            //    Console.WriteLine(person);
            //}

            #endregion

            Console.WriteLine(sum);
        }

        private static void InputData(IQueue<double> queue)
        {
            while (true)
            {

                var value = 0.0;
                var startValue = Console.ReadLine();

                if (double.TryParse(startValue, out value))
                {
                    queue.SaveValue(value);
                    continue;
                }
                break;
            }

        }
    }
}
