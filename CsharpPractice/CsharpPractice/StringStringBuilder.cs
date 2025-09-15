using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class StringStringBuilder
    {
        public static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string str = "";
            for(int i = 0; i < 1000; i++)
            {
                str += i;
            }
            sw1.Stop();
            StringBuilder strb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for(int i = 0; i < 100000; i++)
            {
                strb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine($"Time take for String: {sw1.ElapsedMilliseconds}");
            Console.WriteLine($"Time take for String Builder: {sw2.ElapsedMilliseconds}");
        }
    }
}
