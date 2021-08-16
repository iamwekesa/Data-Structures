using System;
namespace DataStructures.Buffers
{
    public interface IBuffer<T>
    {
        bool IsEmpty { get; }
        void Write(T value);
        T Read();
    }
}
