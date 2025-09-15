using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayReverse
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Length of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter the Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" Before Reverse Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for(int i=0; i < n/2; i++)
            {
                int temp=arr[i];
                arr[i]=arr[n - 1 - i];
                arr[n - 1 - i] =temp;

            }
            Console.Write("After Reverse Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}

