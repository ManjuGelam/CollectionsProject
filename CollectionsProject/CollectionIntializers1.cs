using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollectionsProject
{
    class CollectionIntializers1 // collection intializers by using linq 
    {
         static void Main()
            {
                List<int> coll1 = new List<int>() {9,4,6,7,3, 2,12,10,56 ,23,45};
                var coll2 = from i in coll1 where i > 10 orderby i descending select i;
                Console.WriteLine(String.Join(", ", coll2));

                int[] arr = { 9, 4, 6, 7, 3, 2, 12, 10, 56, 23, 45 };
                var brr = from i in arr where i > 10 orderby i descending select i;
               Console.WriteLine(String.Join(", ", brr));
                Console.ReadLine();
            }
        }

    }

