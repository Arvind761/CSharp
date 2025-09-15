using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static void Main()
        {
          int revs=CheckNumber.Reverse(1234);
            Console.WriteLine($"Reverse Number: {revs}");
            Console.WriteLine($"Sum of the Digit:{CheckNumber.Sum(1234)}");
            bool isprime = CheckNumber.IsPrime(11);
            if (isprime)
            {
                Console.WriteLine($"Is a Prime Number");

            }
            else
            {
                Console.WriteLine($"Is Not  a Prime Number");
            }
            Console.WriteLine(CheckNumber.IsArmstrong(153));
            //bool isarm = CheckNumber.IsArmstrong(153);
            //if (isarm)
            //{
            //    Console.WriteLine($"Is a Armstrong Number");

            //}
            //else
            //{
            //    Console.WriteLine($"Is Not  a Armstrong Number");
            //}

            Console.WriteLine(CheckNumber.IsNeon(9));


        }
    }
}
