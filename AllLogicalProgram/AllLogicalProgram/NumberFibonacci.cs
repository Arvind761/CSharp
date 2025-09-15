using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberFibonacci
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1,n3=0;
            Console.Write($"Fibonacci Series : ");
            if (num > 0)
            {

               for(int i =1; i <=num; i++)
                {
                    Console.Write($"  {n1}  ");
                    n3 = n1 + n2;
                   
                    n1 = n2;
                    n2 = n3;
                }

            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
