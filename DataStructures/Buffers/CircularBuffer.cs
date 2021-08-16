using System;
using System.Net.Http;
using DataStructures.Buffers;

namespace DataStructures
{
    public class CircularBuffer<T> : IBuffer<T>
    {
        //Buffer Array
        T[] _buffer;

        //Header Pointers
        int _start;
        int _end;

        // Constuctor : Default capacity id 10
        public CircularBuffer() : this(10)
        {

        }
        //Overloaded constuctor with option of passing capacity
        public CircularBuffer(int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;

        }
        // Write to 'end' index of the buffer
        public void Write(T value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;

            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }
        // Read last unread data
        public T Read()
        {
            var value = _buffer[_start];
            _start = (_start + 1) % _buffer.Length;
            return value;
        }
        // Capacity of the buffer
        public int Capacity
        {
            get { return _buffer.Length; }
        }
        public bool IsEmpty
        {
            get { return _end == _start; }
        }
        // Check if Buufere has been fully writen on
        public bool IsFull
        {
            get { return (_end + 1) % _buffer.Length == _start; }
        }

    }
}