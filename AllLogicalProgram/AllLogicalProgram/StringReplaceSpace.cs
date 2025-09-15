using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class StringReplaceSpace
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A string");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    result[i] = '_';
                }
                else
                {
                    result [i] = str[i];
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }

        }
    }
}
