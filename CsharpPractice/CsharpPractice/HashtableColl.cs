using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class HashtableColl
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 101);
            ht.Add("Name", "Arvind");
            ht.Add("Job", "Tech Lead");
            ht.Add("Dept", "IT");
            ht.Add("Salary", 67000);
            ht["Id"] = 102;
            Console.Write(ht["Id"]);
            Console.WriteLine($"Containkey : {ht.ContainsKey("Job")}");
            Console.WriteLine($"containsValue : {ht.ContainsValue("IT")}");
            ht.Remove("Id");
            Console.WriteLine($"Remove : ");
            Console.WriteLine($"Count : {ht.Count}");

           


            foreach (object key in ht.Keys) { 
                Console.WriteLine($"{key} : {ht[key]}");
            }
            ht.Clear();
            Console.WriteLine($"Count : {ht.Count}");
        }
    }
}
