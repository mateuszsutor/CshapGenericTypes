using System;

namespace _1_GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new CircleQueue(capacity: 3);

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

            Console.WriteLine("W naszej kolejce znajdują się: ");

            while (!queue.IsEmpty)
            {
                Console.WriteLine("\t\t" + queue.ReadValue());
            }
            Console.ReadKey();
        }
    }
}
