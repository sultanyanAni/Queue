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
        T[] Data;
        int head;
        int tail;

        public Queue()
        {
            Count = 0;
            Data = new T[0];
        }
        public Queue(T firstItem)
        {
            Data = new T[1];
            Data[0] = firstItem;
            head = 0;
            tail = 0;
        }
        public void View()
        {
            for (int i = head; i >= tail; i--)
            {
                Console.WriteLine($"{Data}");
            }
        }
        public void Enqueue(T itemToAdd)
        {

            if (Count == Data.Length)
            {
                T[] tempArray;
                if (Data.Length > 0)
                {
                    tempArray = new T[Data.Length * 2];
                    int tempIndexCount = tempArray.Length - 1;
                    for (int i = head; i >= tail; i--)
                    {
                        tempArray[tempIndexCount] = Data[i];
                        tempIndexCount--;
                    }
                    tail = tempIndexCount;
                }
                else
                {
                    tempArray = new T[Data.Length + 1];
                    tempArray[0] = itemToAdd;
                    tail = 0; 
                }


                Data = tempArray;
                head = Data.Length - 1;
            }
            else
            {
                Data[tail - 1] = itemToAdd;
                tail -= 1;
                return;
            }

        }
    }
}
