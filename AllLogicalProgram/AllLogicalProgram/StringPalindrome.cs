using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class StringPalindrome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string str = Console.ReadLine();

            Console.WriteLine(str);
            int len = 0;
            foreach (char ch in str)
            {
                len++;
            }
            string strRev = "";
            for (int i = len - 1; i >= 0; i--)
            {
                strRev += str[i];
            }
            if (str == strRev)
            {
                Console.WriteLine($"{str} string is palindrome {strRev}");
            }
            else
            {
                Console.WriteLine($"{str} string is not palindrome  {strRev}");
            }
        }
    }
}
