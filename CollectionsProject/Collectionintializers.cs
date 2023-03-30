using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class Collectionintializers
    {
        static void Main()                   //collection intializers by using list
        {
            //Copying values < 40 from 1 list to another list and arranging them in descending order
            List<int> coll1 = new List<int>() { 9, 4, 6, 7, 3, 2, 12, 10, 56, 23, 45 };
            List<int> coll2 = new List<int>();

            foreach (int i in coll1)
            {
                if (i < 10)
                {
                    coll2.Add(i);
                }
            }
            coll2.Sort();
            coll2.Reverse();
            Console.WriteLine(String.Join(", ", coll2));
            Console.ReadLine();
        }
    }

}

