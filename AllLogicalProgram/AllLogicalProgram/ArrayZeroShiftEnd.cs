using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLogicalProgram
{
    internal class ArrayZeroShiftEnd
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
            int[] result = new int[arr.Length];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    result[index++] = arr[i];
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
