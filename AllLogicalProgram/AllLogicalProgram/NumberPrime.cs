using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberPrime
    {
        public static void Main(string[] args)
        {
            Console.Write($"Enter the Number : ");
            int num=Convert.ToInt32( Console.ReadLine() );
            int Fc = 0;
            for(int  i=1; i<=num; i++)
            {
                if (num % i == 0)
                {
                    Fc++;
                }
            }
            if (Fc > 2)
            {
                Console.WriteLine($"Number is not prime Number");
            }
            else
            {
                Console.WriteLine($"Number is  prime Number");
            }
        }
    }
}
