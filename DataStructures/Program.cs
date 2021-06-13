using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var buffer = new CircularBuffer<double>(capacity: 3);
            var values = new[] { 1.0, 2.0, 3.0, 4.0, 5.0 };

            foreach (var value in values)
            {
                buffer.Write(value);
            }
            while (!buffer.IsEmpty)
            {
                Console.WriteLine(buffer.Read());
            }
        }
    }
}
