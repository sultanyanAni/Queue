using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < 5; i++)
            {
                queue.Enqueue(i);
            }

            queue.View();

        }
    }
}
