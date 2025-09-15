using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class StringReverse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String ");
            string str = Console.ReadLine();

         
            int len = 0;
            foreach (char c in str)
            {
                    len++;

            }
            string strRev = "";
            for (int i = len-1; i>=0; i--)
            {
                strRev += str[i];
            }
            Console.WriteLine($"String is {str}");
            Console.WriteLine($"Revesere String = {strRev}");
        }

    }
}
