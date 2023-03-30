using System;
using System.Collections;
using System.Text;

namespace CollectionsProject
{
    class Class1
    {
        static void Main()
        {
            int[] arr = { 10,23,20,50,55};
            Console.WriteLine(" the elements divisible by 10 in arr is : ");
            for(int i = 0;i< arr.Length;i++)
            {
                if(arr[i]%10 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ReadLine();
            }
        }

    }
}
