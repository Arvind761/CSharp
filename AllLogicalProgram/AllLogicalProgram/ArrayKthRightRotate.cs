using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayKthRightRotate
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
                int last = arr[n - 1];

                for (int i = n - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;
            }

            Console.WriteLine("Array after right rotation: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
