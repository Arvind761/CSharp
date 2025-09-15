using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProjectSir
{
    internal class Exception
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("The result of division is: " + z);
            Console.WriteLine("End of the Program.");
            Console.ReadLine();
        }
    }
}
