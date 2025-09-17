using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CsharpPractice
{
    internal class ArrayListColl
    {
        public static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            Console.WriteLine($"Capacity is {al.Capacity}");
            al.Add(45);
            al.Add("Apple");
            al.Add(100);        // int
            al.Add(3.14);
            Console.WriteLine($"Capacity is {al.Capacity}");// double
            al.Add(true);
            

            

            
            al.Add(43);
            al.Add(44);
            al.Add(47);
            al.Add(48);
            Console.WriteLine($"Capacity is {al.Capacity}");
            al.Add(50);

            al.Remove(43);
            al.RemoveAt(0);
            al.Insert(0, 70);
            foreach (var item in al)
            {
                Console.Write($"{item}  ");
            }


        }
    }
}
