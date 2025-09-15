using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayOddEven
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Enter the Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Even numbers count: " + evenCount);
            Console.WriteLine("Odd numbers count: " + oddCount);
        }
    }
}
