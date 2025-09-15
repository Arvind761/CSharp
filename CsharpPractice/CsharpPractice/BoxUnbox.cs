using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class BoxUnbox
    {
        public static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //object obj = a;
            object obj1 = 19;
            int c = Convert.ToInt32(obj1);

            Console.WriteLine(c);
            //Console.WriteLine(obj);
            Console.WriteLine(obj1);
            //Console.WriteLine(b);
        }
    }
}
