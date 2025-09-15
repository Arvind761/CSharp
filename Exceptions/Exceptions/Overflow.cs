using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Overflow
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter A number:");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter A number:");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine($"sum is : {sum}");

            }
            catch(OverflowException e)
            {
                Console.WriteLine($"Error : Exception occur Overflow");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error:{e}");
            }

        }
    }
}
