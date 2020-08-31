using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _3_GenericClassAndInterfaces
{
    public static class QueueExtensions
    {
        public delegate void Printer<T>(T data);

        public static IEnumerable<Tout> SaveElementByNewType<T, Tout>(this IQueue<T> queue)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in queue)
            {
                var result = converter.ConvertTo(item, typeof(Tout));
                yield return (Tout)result;

            }

        }



        public static void Print<T>(this IQueue<T> queue,Printer<T> printout)
        {
            foreach (var item in queue)
            {
                printout(item);
            }
        }


    }
}
