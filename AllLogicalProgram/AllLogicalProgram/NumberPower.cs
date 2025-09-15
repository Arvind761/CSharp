using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberPower
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            long result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine($"{baseNum}^{exponent} = {result}");
        }
    }
}
