using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayKthLeftRotate
    {
        static void Main()
        {
            Console.Write("Enter array length: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter k (positions to rotate): ");
            int k = Convert.ToInt32(Console.ReadLine());
           
            for (int r = 0; r < k; r++)
            {
                int first = arr[0];  
                for (int i = 0; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = first;
            }

            Console.WriteLine("Array after left rotation: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
