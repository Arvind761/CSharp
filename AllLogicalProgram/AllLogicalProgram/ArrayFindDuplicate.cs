using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayFindDuplicate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter the Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Before find Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != -1)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            arr[j] = -1;
                        }
                    }
                }
            }
            Console.Write("After Find Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != -1)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

        }
    }
}
