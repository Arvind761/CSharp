using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberDigitSum
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int num=number;
            if (num > 0)
            {
                int sum = 0,r=0;
                while (num > 0) {
                    r = num % 10;
                    sum += r;
                    num /= 10;
                
                }
                Console.WriteLine($"{number} Digit Sum is {sum}");

            }
            else
            {
                Console.WriteLine("Number should be Positive and greater than Zero");
            }
        }
    }
}
