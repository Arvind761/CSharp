using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberLargDigit
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int m, r;
                int maxDigit = 0;
                m = num;
                while (m > 0)
                {
                    r = m % 10;
                    if (r > maxDigit)
                    {
                        maxDigit = r;
                    }
                    m = m / 10;
                }
                Console.Write($"{num} in Max digit is : {maxDigit}");
            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
