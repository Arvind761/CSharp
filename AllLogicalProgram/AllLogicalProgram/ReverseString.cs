using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ReverseString
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter A string:");
            string str=Console.ReadLine();
            Console.WriteLine(str);
            string reverse = "";
            foreach(char ch in str)
            {
                reverse= ch+reverse;
            }
            Console.WriteLine($"Orignal String is: {str}");
            Console.WriteLine($"Reverse String is : {reverse}");

        }
    }
}
