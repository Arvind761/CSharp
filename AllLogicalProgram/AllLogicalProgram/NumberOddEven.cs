using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberOddEven
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Given Number is Even: {num}");

                }
                else
                {
                    Console.WriteLine($"Given Number is Odd: {num}");
                }

            }
            else
            {
                Console.WriteLine("Number should be Positive and greater than Zero");
            }
        }
    }
}
