using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class collectionintilizers2                                   // collection intializers by using array
    {
        static void Main()
        {
            //Copying values < 40 from 1 array to another array and arranging them in descending order
            int[] arr = { 34,27,39,45,1,2,7,16 ,78,89,56,99};

            int Count = 0, Index = 0;
            foreach (int i in arr)
            {
                if (i < 50)
                {
                    Count += 1;
                }
            }
            int[] brr = new int[Count];
            foreach (int i in arr)
            {
                if (i > 50)
                {
                    brr[Index] = i;
                    Index += 1;
                }
            }

            Array.Sort(brr);
            Array.Reverse(brr);
            Console.WriteLine(String.Join(", ", brr));
            Console.ReadLine();
        }
    }

}

