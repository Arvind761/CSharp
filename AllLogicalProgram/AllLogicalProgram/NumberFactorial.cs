using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberFactorial
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                long fact = 1;
                int m = num;
                for (int i = 1; i <= m; i++) 
                {
                    fact = fact * i;
                    

                }
                Console.WriteLine($"{m} of Factorial : {fact} ");
                
            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
