using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArraySortedAscDsc
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
            bool ascending = true;
            bool descending = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    ascending = false;

                if (arr[i] < arr[i + 1])
                    descending = false;
            }

            if (ascending)
                Console.WriteLine("Array is sorted in Ascending order");
            else if (descending)
                Console.WriteLine("Array is sorted in Descending order");
            else
                Console.WriteLine("Array is not sorted");
        }
    }
}
