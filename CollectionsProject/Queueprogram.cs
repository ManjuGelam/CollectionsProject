using System;
using System.Collections;

namespace CollectionsProject
{
    class Queueprogram
    {
        static void Main()
        {

            Queue q = new Queue();

            q.Enqueue('m'); q.Enqueue(200); q.Enqueue(false); q.Enqueue(67.87); q.Enqueue("namaste");

            foreach (object obj in q)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(q.Dequeue());
            foreach (object obj in q)
            {
                Console.Write(obj + "  ");
            }
            Console.ReadLine();
        }
    }
}
