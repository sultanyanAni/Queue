using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T>
    {
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        T[] Data;

        int head = 0;
        int tail = 0;

        public Queue(int capacity)
        {
            Capacity = capacity;
            Count = 0;
            Data = new T[Capacity];
        }

        public void View()
        {
            for (int i = head; i >= tail; i--)
            {
                Console.WriteLine($"{Data[i]}");
            }
        }
        public void Resize(int size)
        {
            T[] tempArray = new T[Data.Length * size];
            int tempIndexCount = tempArray.Length - 1;
            for (int i = head; i >= tail; i--)
            {
                tempArray[tempIndexCount] = Data[i];
                tempIndexCount--;
            }
            tail = tempIndexCount;
            
            Data = tempArray;
           // head = Data.Length - 1;

        }
        public void Enqueue(T itemToAdd)
        {

            if (Count == Data.Length)
            {

                Resize(2);
                Data[tail] = itemToAdd;

                Count++;

                tail = (Data.Length - 1) - Count;
                head = Data.Length - 1;

            }
            else
            {
                Data[tail] = itemToAdd;
                tail = (Data.Length - 1) - Count;
                Count++;
                return;
            }

        }

        public T Dequeue()
        {
            head--;

        }

    }
}
