using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArraayMergeTwo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the Array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Length of the Array: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n+m];
           
            Console.Write("Enter the Element of the Array: ");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Element of the Array1: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            
            int[] arr2 = new int[m];
            Console.WriteLine("Enter the Element of the Array: ");
           
            for (int i = 0; i < m; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" Element of the Array1: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            int j = 0;
            for (int i = n; i < (m + n); i++)
            {
                arr1[i] = arr2[j];
                j++;
            }

            Console.Write("After Find Element of the Array: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                
                    Console.Write($"{arr1[i]} ");
               
            }

        }

    }
}
