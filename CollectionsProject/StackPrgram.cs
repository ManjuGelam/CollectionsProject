using System.Collections;
using System;
 namespace CollectionsProject
{
    class StackPrgram
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push('M'); s.Push(200); s.Push(false); s.Push(45.64); s.Push("NAMASTE");

            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Pop());
            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Peek());
            foreach (object obj in s)
            {
                Console.Write(obj + "  ");
            }
           
        }
    }


}

