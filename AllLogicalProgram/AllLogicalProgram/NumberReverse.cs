using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberReverse
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num > 0) {
                int m = num;
                int revNum = 0;
                int r = 0;
                while (m > 0)
                {
                    r = m % 10;
                    revNum = revNum * 10 + r;
                    m = m / 10;
                }
                Console.WriteLine($"{num} is Reverse Number : {revNum}");
                
            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
