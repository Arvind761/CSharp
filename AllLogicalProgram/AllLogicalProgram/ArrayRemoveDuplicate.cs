using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayRemoveDuplicate
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
            Console.Write("Before Remove Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                      
                        for(int k = j; k < n-1; k++)
                        {
                            arr[k] = arr[k + 1];
                            n--;
                            j--;
                        }
                    }
                }
            }
            Console.Write("After Remove Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");

            }
        }

    }
}
