using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class NumberPrimeAll
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.Write($"Number is not prime Number: ");
                for (int i = 2; i <= num; i++)
                {
                    int newNum = i;
                    int Fc = 0;
                    for (int j = 2; j <= newNum; j++)
                    {
                        if (newNum % j == 0)
                        {
                            Fc++;
                        }
                    }
                    if (Fc < 2)
                        Console.Write($"{newNum} ");


                }

            }
            else
            {
                Console.WriteLine("Number Should be Positive");
            }
        }
    }
}
