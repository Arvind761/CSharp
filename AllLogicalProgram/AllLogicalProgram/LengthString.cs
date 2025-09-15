using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class LengthString
    {
        public static void Main(string[] args)
        {
            Console.Write($"Enter A String : ");
            string str=Console.ReadLine();
            int length = 0;
            foreach(char ch in str)
            {
                length++;
            }
            Console.Write($"Orignal String: {str}");
            Console.WriteLine($"String Length is: {length}");

        }
    }
}
