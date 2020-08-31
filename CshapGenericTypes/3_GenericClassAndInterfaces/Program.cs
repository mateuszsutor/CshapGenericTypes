using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _3_GenericClassAndInterfaces.QueueExtensions;

namespace _3_GenericClassAndInterfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            //Action<double> printing = delegate (double data)
            //{
            //    Console.WriteLine(data);
            //};

            Action<double> printing = x => Console.WriteLine(x);
            printing(7.89);

            Action<int, int, int> testSum = (a, b, c) => Console.WriteLine(a + b + c);
            testSum(1,2,3);

            var queue = new CircleQueue<double>();

            InputData(queue);

            queue.Print(p => Console.WriteLine(p));

            ProcessingData(queue);

            Console.ReadKey();
        }

        private static void ProcessingData(IQueue<double> queue)
        {
            var sum = 0.0;
            Console.WriteLine("Suma wszystkich elementów znajdujących się w naszej kolejce to : ");

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
