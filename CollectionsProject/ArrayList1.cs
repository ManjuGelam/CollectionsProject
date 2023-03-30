
using System;
using System.Collections;

namespace CollectionsProject
{
   //arraylist program
     class ArrayList1
    {
        static void Main()
        {
            ArrayList Coll1 = new ArrayList();
            Console.WriteLine($"Initial capacity: {Coll1.Capacity}");

            Coll1.Add('M');
            Console.WriteLine($"Capacity of the collection after adding 1st item: {Coll1.Capacity}");

            Coll1.Add(100); Coll1.Add(false); Coll1.Add(78.98);
            Console.WriteLine($"Capacity of the collection after adding 4th item: {Coll1.Capacity}");

            Coll1.Add("Hello");
            Console.WriteLine($"Capacity of the collection after adding 5th item: {Coll1.Capacity}");

            for (int i = 0; i < Coll1.Count; i++)
            {
                Console.Write(Coll1[i] + "  ");
            }
            Console.WriteLine();

            //Coll1.Remove(false); 
            //Coll1.RemoveAt(2); 
            Coll1.RemoveRange(2, 1);
            foreach (object obj in Coll1)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();

            Coll1.Insert(2, true);
            foreach (object obj in Coll1)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine("\n");

            ArrayList Coll2 = new ArrayList(Coll1);
            foreach (object obj in Coll2)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            Console.WriteLine($"Initial capacity of new collection: {Coll2.Capacity}");
            Coll2.Add(false);
            Console.WriteLine($"Capacity of new collection after adding new item: {Coll2.Capacity}");
            Coll2.TrimToSize();
            Console.WriteLine($"Capacity of new collection after calling TrimToSize: {Coll2.Capacity}");
            Console.ReadLine();
        }
    }




}

