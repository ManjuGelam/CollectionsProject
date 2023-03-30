using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class GenericMethods
    {
         public bool AreEqual<T>(T a, T b)
            {
                if (a.Equals(b))
                    return true;
                else
                    return false;
            }
            static void Main()
            {
                GenericMethods obj = new GenericMethods();
                Console.WriteLine(obj.AreEqual<int>(100, 200));
                Console.WriteLine(obj.AreEqual<bool>(true, true));
                Console.WriteLine(obj.AreEqual<double>(56.78, 90.87));
                Console.WriteLine(obj.AreEqual<string>("NAMASTE", "NAMASTE"));
                Console.ReadLine();
            }
        }

    }

