using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_GenericType
{
    public class CircleQueue
    {
        private double[] buffer;
        private int startBuffer;
        private int endBuffer;

        public CircleQueue() : this(capacity: 5)
        {

        }

        public CircleQueue(int capacity)
        {
            buffer = new double[capacity + 1];
            startBuffer = 0;
            endBuffer = 0;
        }

        public void SaveValue(double value)
        {
            buffer[endBuffer] = value;
            endBuffer = (endBuffer + 1) % buffer.Length;

            if (endBuffer == startBuffer)
            {
                startBuffer = (startBuffer + 1) % buffer.Length;
            }

        }

        public double ReadValue()
        {
            var result = buffer[startBuffer];
            startBuffer = (startBuffer + 1) % buffer.Length;

            return result;
        }

        public int BufferCapacity
        {
            get
            {
                return buffer.Length;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return endBuffer == startBuffer;
            }
        }

        public bool IsFull
        {
            get
            {
                return (endBuffer + 1) % buffer.Length == startBuffer;
            }
        }

    }
}
