using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberCountDigit
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int c = 0,m;
                m = num;
                while (m > 0)
                {
                    c++;
                    m = m / 10;
                }
                Console.Write($"Total Digit Count: {c}");
            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
