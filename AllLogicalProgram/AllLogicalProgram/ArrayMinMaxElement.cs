using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayMinMaxElement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the Array: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter the Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());            
            }
            Console.Write("Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            int min = arr[0],max = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.Write($"Max element {max} and Min element {min}");

        }
    }
}
