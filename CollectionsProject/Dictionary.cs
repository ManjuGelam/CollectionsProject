using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class Dictionary                                //DICTIONARY
    {
        static void Main()
        {
            Dictionary<string, object> Emp = new Dictionary<string, object>();
            Emp.Add("Emp-Id", 301938);
            Emp.Add("Emp-Name", "Manju");
            Emp.Add("Job", "trainee");
            Emp.Add("Mgr-Id", null);
            Emp.Add("Salary", 20000.00);
            Emp.Add("Commission", 0.00f);
            Emp.Add("Dept-Id", 5);
            Emp.Add("Dept-Name", "training");
            Emp.Add("Location", "vijayawada");
            Emp.Add("Status", true);
            Emp.Add("PAN", "HSGPM 1969D");
            Emp.Add("Adhar No.", "6203 3140 9155");
            Emp.Add("Mobile", "93987 77267");
            Emp.Add("Home Phone", "2718 6547");
            Emp.Add("Email", "manju.gelam@aptonline.in");

            foreach (string key in Emp.Keys)
            {
                Console.WriteLine($"{key}: {Emp[key]}");
            }
            Console.ReadLine();
        }
    }

}

